"""
case_manager.py - stores and searches the Case Report records (COMP 2210 Project Part 1).
The C# form runs it with one command: add, update <id>, delete <id>, search <by> <text>, or list.
Each record is one line in case_reports.txt, values separated by "|".
"""
import os
import sys

# the data file is in the same folder as this script
DATA_FILE = os.path.join(os.path.dirname(os.path.abspath(__file__)), "case_reports.txt")


def read_records():
    """Read all records from the file."""
    records = []
    try:
        with open(DATA_FILE, encoding="utf-8") as f:
            for line in f:
                if line.strip() != "":
                    records.append(line.strip())
    except FileNotFoundError:
        pass   # no file yet means no records
    return records


def write_records(records):
    """Rewrite the file with the given records."""
    with open(DATA_FILE, "w", encoding="utf-8") as f:
        for line in records:
            f.write(line + "\n")


def next_id(records):
    """Make the next id, like CR-0001."""
    biggest = 0
    for line in records:
        number = line.split("|")[0].replace("CR-", "")
        if number.isdigit() and int(number) > biggest:
            biggest = int(number)
    return "CR-" + str(biggest + 1).zfill(4)


def add_record(values):
    """Add a new record and print its id."""
    new_id = next_id(read_records())
    with open(DATA_FILE, "a", encoding="utf-8") as f:   # "a" adds to the end
        f.write(new_id + "|" + values + "\n")
    print(new_id)


def update_record(record_id, values):
    """Replace the record with this id."""
    records = read_records()
    found = False
    for i in range(len(records)):
        if records[i].split("|")[0] == record_id:
            records[i] = record_id + "|" + values
            found = True
    if not found:
        fail("Record " + record_id + " was not found.")
    write_records(records)
    print(record_id)


def delete_record(record_id):
    """Remove the record with this id."""
    records = read_records()
    kept = [line for line in records if line.split("|")[0] != record_id]
    if len(kept) == len(records):
        fail("Record " + record_id + " was not found.")
    write_records(kept)
    print(record_id)


def search_records(search_by, text):
    """Print the records whose chosen column contains the text."""
    # columns: 0 = id, 1 = student name, 2 = student number, 4 = faculty name
    columns = {"Record ID": [0], "Student Name": [1], "Student Number": [2], "Faculty Name": [4]}.get(search_by, [0, 1, 2, 4])
    text = text.strip().lower()
    for line in read_records():
        parts = line.split("|")
        for c in columns:
            if c < len(parts) and text in parts[c].lower():
                print(line)
                break   # do not print the same record twice


def fail(message):
    """Send an error message to the C# form and stop."""
    print(message, file=sys.stderr)
    sys.exit(1)


def main():
    """Run the command given on the command line."""
    # use UTF-8 for input and output
    sys.stdout.reconfigure(encoding="utf-8")
    sys.stderr.reconfigure(encoding="utf-8")

    args = sys.argv[1:]
    command = args[0] if len(args) > 0 else ""
    try:
        if command == "add":
            add_record(sys.stdin.read().strip())
        elif command == "update" and len(args) == 2:
            update_record(args[1], sys.stdin.read().strip())
        elif command == "delete" and len(args) == 2:
            delete_record(args[1])
        elif command == "search" and len(args) == 3:
            search_records(args[1], args[2])
        elif command == "list":
            for line in read_records():
                print(line)
        else:
            fail("Unknown command. Use: add, update <id>, delete <id>, search <by> <text>, list")
    except PermissionError:
        fail("You may not use the data file " + DATA_FILE)
    except OSError as error:
        fail("Could not use the data file: " + str(error))


if __name__ == "__main__":
    main()
