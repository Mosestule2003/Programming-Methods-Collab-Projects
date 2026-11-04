# Case Report Form Manager - COMP 2210 Project (Part 1)

A Python console program for the TRU Academic Integrity Case Report Form (ED 5-0).
It takes the input of every editable field in the PDF form, saves each record as one
line in a text file, and lets you search, display, modify and delete records.

## Project phases

- **Phase 1 (this submission):** `case_report_manager.py`, a Python console program.
- **Phase 2:** a C# Windows Forms version of the same form. It was built at the same
  time as Phase 1, so it is being kept separate and will be reconciled with this
  code later.

## Features

1. Take input of all 38 editable fields from the PDF form (required fields are marked with `*`).
2. Save each complete record as one line in `case_reports.txt`.
3. Search by record ID, student name, student number or faculty name.
4. Display the matching records on screen.
5. Modify a selected record (press Enter to keep the old value of a field).
6. Delete a selected record (asks to confirm first).

Each major feature is its own function.

## Requirements

- Python 3 (tested with Python 3.12 on Windows)
- No extra packages are needed.

Check that Python is installed:

```
py --version
```

## Setup

Clone the repository and go into the folder:

```
git clone https://github.com/Mosestule2003/Programming-Methods-Collab-Projects.git
cd Programming-Methods-Collab-Projects
```

## Run

```
py case_report_manager.py
```

If `py` is not recognized, use `python case_report_manager.py` instead.

The data file `case_reports.txt` is created in the folder you run the program from,
the first time you save a record.

## Menu

```
1) Add  2) Search  3) Show all  4) Modify  5) Delete  6) Exit
```

## Testing

Run the program and follow these steps:

1. Type `1` to add a record. Fill in at least the 10 fields marked `*`, and press Enter to skip the rest.
   - Leave a required field blank to check that it is refused.
   - Type `maybe` in a Yes/No field to check that it is refused.
2. Type `3` to show all records. The new record should appear as `CR-1`.
3. Type `2`, then choose 1 to 4, and search by record ID, student name, student number and faculty name. Each should find the record.
4. Type `4`, enter `CR-1`, change one field and press Enter on the rest. Only that field should change.
5. Type `5`, enter `CR-1`, and answer `n`. The record should stay. Repeat and answer `y`. The record should be removed.
6. Try an ID that does not exist (for example `CR-99`) in Modify and Delete. Both should say "Record not found."
7. Type `6` to exit.

To look at the saved file after testing:

```
type case_reports.txt
```

To start again with a clean file:

```
del case_reports.txt
```

## Data format

One record per line, values separated by `|`:

```
CR-1|Student Name|Student Number|Student Email|Faculty Member Name|...
```

A `|` typed by the user is saved as `/` so each record always stays on one line.

## Team

- [Name 1]
- [Name 2]
- [Name 3]

COMP 2210 - Programming Methods, Thompson Rivers University
