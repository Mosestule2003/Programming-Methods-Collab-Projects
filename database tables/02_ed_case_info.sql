-- Table 2 of 3: ed_case_info (run after users)
USE ed5;

CREATE TABLE ed_case_info (
    case_id VARCHAR(10) NOT NULL,
    student_id VARCHAR(10) NOT NULL,
    faculty_id VARCHAR(10) NOT NULL,
    chair_id VARCHAR(10),
    dean_id VARCHAR(10),
    Term VARCHAR(30) NOT NULL,
    Assignment_number VARCHAR(30) NOT NULL,
    ed_violation_description TEXT NOT NULL,
    violation_date DATE NOT NULL,
    PRIMARY KEY (case_id),
    FOREIGN KEY (student_id) REFERENCES users (user_id),
    FOREIGN KEY (faculty_id) REFERENCES users (user_id),
    FOREIGN KEY (chair_id) REFERENCES users (user_id),
    FOREIGN KEY (dean_id) REFERENCES users (user_id)
);

-- Record 1: added manually in phpMyAdmin (Insert tab)
--   case_id = CR-901, student_id = T00100001, faculty_id = F001, chair_id = NULL, dean_id = NULL,
--   Term = Fall 2026, Assignment_number = 1, ed_violation_description = Copied code from another student,
--   violation_date = 2026-10-15

-- Record 2: added with an SQL query
INSERT INTO ed_case_info (case_id, student_id, faculty_id, chair_id, dean_id, Term, Assignment_number, ed_violation_description, violation_date)
VALUES ('CR-902', 'T00100001', 'F001', NULL, NULL, 'Fall 2026', '2', 'Shared an answer during an exam', '2026-11-02');
