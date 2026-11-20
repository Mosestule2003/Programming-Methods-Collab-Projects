# COMP 2210 Project Part 2: Case Report Form (ED 5-0)
# Each record is saved as one line in a text file, values separated by "|"

import os

FILE_NAME = "case_reports.txt"

# All 38 editable fields of the PDF form, in order
FIELDS = [
    "Student Name", "Student Number", "Student Email", "Faculty Member Name",
    "Date (yyyy-mm-dd)", "Course Name and Number", "Assignment Number or Exam",
    "Department", "Term or Semester", "OSA use only", "Description of Violation",
    "Student advised they may bring a support person (Yes/No)",
    "Student advised they may submit a written statement (Yes/No)",
    "Step 1: Faculty Signature", "Step 1: Faculty Name", "Step 1: Signature Date",
    "Step 2: Student Name", "Student reviewed the form and evidence (Yes/No)",
    "Student MyTRU Email", "Step 2: Student Signature", "Step 2: Date",
    "Step 3: Faculty Signature", "Step 3: Faculty Name", "Step 3: Date",
    "Step 4: Chair agrees with the case (Yes/No)", "Step 4: Chair explanation if No",
    "Step 4: Chair Comments", "Step 4: Chair Signature", "Step 4: Chair Name", "Step 4: Date",
    "Step 5: Dean agrees with the case (Yes/No)", "Step 5: Dean explanation if No",
    "Step 5: Dean Comments", "Step 5: Dean Signature", "Step 5: Dean Name", "Step 5: Date",
    "Faculty Member Comments (Page 4)", "Student Comments (Page 5)",
]

# Positions in FIELDS that must be filled in (marked with *)
REQUIRED = [0, 1, 2, 3, 4, 5, 6, 7, 8, 10]


# Read every line of the file into a list (empty list if there is no file yet)
def read_records():
    records = []
    if os.path.exists(FILE_NAME) == False:
        return records
    with open(FILE_NAME, "r", encoding="utf-8") as file:
        for line in file:
            if line.strip() != "":
                records.append(line.strip())
    return records


# Replace the whole file with the given list of records
def write_records(records):
    with open(FILE_NAME, "w", encoding="utf-8") as file:
        for line in records:
            file.write(line + "\n")


# New id = biggest number in the file + 1, for example CR-3
def make_new_id(records):
    biggest = 0
    for line in records:
        number = int(line.split("|")[0].replace("CR-", ""))
        if number > biggest:
            biggest = number
    return "CR-" + str(biggest + 1)


def ask_one_field(index, old_value):
    label = FIELDS[index]
    while True:
        question = label
        if index in REQUIRED:
            question = question + " *"
        if old_value != "":
            question = question + " [" + old_value + "]"
        answer = input(question + ": ").strip().replace("|", "/")
        if answer == "":
            answer = old_value
        if answer == "" and index in REQUIRED:
            print("This field is required.")
        elif "(Yes/No)" in label and answer != "" and answer.lower() not in ["yes", "no"]:
            print("Please type Yes or No.")
        else:
            return answer


# Ask for all fields and join them into one line
def ask_all_fields(old_values):
    values = []
    for i in range(len(FIELDS)):
        values.append(ask_one_field(i, old_values[i]))
    return "|".join(values)


# Return the position of the record with this id, or -1 if it is not found
def find_record(records, record_id):
    for i in range(len(records)):
        if records[i].split("|")[0].lower() == record_id.strip().lower():
            return i
    return -1


# Display every filled-in field of one record
def show_one_record(line):
    parts = line.split("|")
    print("\nRecord " + parts[0])
    for i in range(len(FIELDS)):
        if parts[i + 1] != "":
            print(FIELDS[i] + ": " + parts[i + 1])


# Display a short summary list of records
def show_list(records):
    if len(records) == 0:
        print("No records found.")
        return
    print("\nID | Student | Number | Faculty | Course")
    for line in records:
        p = line.split("|")
        print(p[0] + " | " + p[1] + " | " + p[2] + " | " + p[4] + " | " + p[6])
    print(str(len(records)) + " record(s) found.")


# Feature 1 and 2: take all the input and save it as one new line
def add_record():
    new_id = make_new_id(read_records())
    line = ask_all_fields([""] * len(FIELDS))
    with open(FILE_NAME, "a", encoding="utf-8") as file:
        file.write(new_id + "|" + line + "\n")
    print("Saved as " + new_id)


# Feature 3 and 4: search by id / student name / student number / faculty name, then display
def search_records():
    print("Search by: 1) Record ID  2) Student Name  3) Student Number  4) Faculty Name")
    choice = input("Choose 1-4: ").strip()
    if choice == "1":
        column = 0
    elif choice == "2":
        column = 1
    elif choice == "3":
        column = 2
    elif choice == "4":
        column = 4
    else:
        print("Please choose 1, 2, 3 or 4.")
        return
    text = input("Enter the text to search for: ").strip().lower()
    found = []
    for line in read_records():
        if text in line.split("|")[column].lower():
            found.append(line)
    show_list(found)
    for line in found:
        show_one_record(line)


# Feature 5: choose a record by id and enter its fields again
def modify_record():
    records = read_records()
    i = find_record(records, input("Record ID to modify: "))
    if i == -1:
        print("Record not found.")
        return
    old_parts = records[i].split("|")
    print("Press Enter to keep the value shown in [brackets].")
    records[i] = old_parts[0] + "|" + ask_all_fields(old_parts[1:])
    write_records(records)
    print("Record " + old_parts[0] + " updated.")


# Feature 6: choose a record by id and delete it after asking to confirm
def delete_record():
    records = read_records()
    i = find_record(records, input("Record ID to delete: "))
    if i == -1:
        print("Record not found.")
        return
    show_one_record(records[i])
    if input("Delete this record? (y/n): ").strip().lower() == "y":
        records.pop(i)
        write_records(records)
        print("Record deleted.")


def main():
    running = True
    while running:
        print("\n=== Case Report Form ===")
        print("1) Add  2) Search  3) Show all  4) Modify  5) Delete  6) Exit")
        choice = input("Choose 1-6: ").strip()
        if choice == "1":
            add_record()
        elif choice == "2":
            search_records()
        elif choice == "3":
            show_list(read_records())
        elif choice == "4":
            modify_record()
        elif choice == "5":
            delete_record()
        elif choice == "6":
            running = False
        else:
            print("Please choose 1-6.")


if __name__ == "__main__":
    main()
