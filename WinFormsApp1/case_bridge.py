
import sys
import case_manager


# Print the error message for C# to show, then stop
def fail(message):
    print(message, file=sys.stderr)
    sys.exit(1)


# Save the values as one new line (same as add_record in case_manager.py)
def add(values):
    new_id = case_manager.make_new_id(case_manager.read_records())
    file = open(case_manager.FILE_NAME, "a", encoding="utf-8")
    file.write(new_id + "|" + values + "\n")
    file.close()
    print(new_id)


# Replace one record (same as modify_record in case_manager.py)
def update(record_id, values):
    records = case_manager.read_records()
    i = case_manager.find_record(records, record_id)
    if i == -1:
        fail("Record " + record_id + " was not found.")
    old_id = records[i].split("|")[0]
    records[i] = old_id + "|" + values
    case_manager.write_records(records)
    print(old_id)


# Delete one record (same as delete_record in case_manager.py)
def delete(record_id):
    records = case_manager.read_records()
    i = case_manager.find_record(records, record_id)
    if i == -1:
        fail("Record " + record_id + " was not found.")
    old_id = records[i].split("|")[0]
    records.pop(i)
    case_manager.write_records(records)
    print(old_id)


# Print the records that contain the text in the chosen column (same as search_records in case_manager.py)
def search(choice, text):
    columns = {"0": [0, 1, 2, 4], "1": [0], "2": [1], "3": [2], "4": [4]}
    if choice not in columns:
        fail("Search choice must be 0, 1, 2, 3 or 4.")
    for line in case_manager.read_records():
        parts = line.split("|")
        for column in columns[choice]:
            if text.strip().lower() in parts[column].lower():
                print(line)
                break


def main():
    # use UTF-8 so letters like é work
    sys.stdin.reconfigure(encoding="utf-8")
    sys.stdout.reconfigure(encoding="utf-8")
    sys.stderr.reconfigure(encoding="utf-8")

    args = sys.argv[1:]
    command = ""
    if len(args) > 0:
        command = args[0]

    if command == "list":
        for line in case_manager.read_records():
            print(line)
    elif command == "add":
        add(sys.stdin.read().strip())
    elif command == "update" and len(args) == 2:
        update(args[1], sys.stdin.read().strip())
    elif command == "delete" and len(args) == 2:
        delete(args[1])
    elif command == "search" and len(args) == 3:
        search(args[1], args[2])
    else:
        fail("Unknown command. Use: list, add, update <id>, delete <id>, search <0-4> <text>")


main()
