# Case Report Form Manager: COMP 2210 Project

## Team (Group 9)

- Tertsegha Kpughur-Tule, T00721068, kpughurtulet22@mytru.ca
- Sumaiya Shova, T00742702, shovas23@mytru.ca

COMP 2210, Programming Methods, Thompson Rivers University


TRU Academic Integrity Case Report Form (ED 5-0).
It takes the input of every editable field in the PDF form, saves each record as one
line in a text file, and lets you search, display, modify and delete records.

## Project phases

- **Phase 1:** `case_report_manager.py`, a Python console program (in the main folder).
- **Phase 2:** the `WinFormsApp1` folder, a C# Windows Forms version of the same form.
  The form looks like the PDF, the Python code (`case_manager.py` through `case_bridge.py`)
  saves each record in a text file, and `Database.cs` copies each record into a MySQL
  database called `ed5`.

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

## Phase 2: C# Windows Forms app (WinFormsApp1)

### How it works

1. The form (`Form1.cs`) collects the 38 fields and checks them (required fields, dates, emails, lengths).
2. `Form1.cs` runs `case_bridge.py` with `py`. The bridge uses `case_manager.py` to add, update, delete,
   list and search the records in `case_reports.txt` (next to the program).
3. `Database.cs` then copies the record into MySQL: `users`, `ed_case_info` and `ed_case_comments`.
   If MySQL is not running, the text file is still saved and the form shows a warning.

### Setup

1. Install Python 3 (the `py` command must work) and Visual Studio with the .NET desktop workload.
2. Install XAMPP and start **MySQL** in the XAMPP Control Panel (user `root`, empty password).
3. Create the database: open http://localhost/phpmyadmin/, click **SQL**, paste the contents of
   `ed5_setup.sql` and click **Go**.
   The same tables are also in the `database tables` folder as three separate files
   (`01_users.sql`, `02_ed_case_info.sql`, `03_ed_case_comments.sql`, run in that order), with screenshots of the tables.
4. Open `WinFormsApp1.slnx` in Visual Studio and press **Ctrl+F5** (Start Without Debugging).

### Testing the app

1. Fill in the starred fields and click **Save New Record**. A message says it was saved to the text file and the database.
2. Check phpMyAdmin: the new rows are in `users`, `ed_case_info` and `ed_case_comments`.
3. Use **Find records** to search, select a row and click **Modify Selected** (or double-click it), change a field and click **Update Record**.
4. Select a row and click **Delete Selected**. The record disappears from the text file and the database.

## Data format

One record per line, values separated by `|`:

```
CR-1|Student Name|Student Number|Student Email|Faculty Member Name|...
```