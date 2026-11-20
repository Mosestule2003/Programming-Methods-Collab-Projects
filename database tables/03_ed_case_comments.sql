-- Table 3 of 3: ed_case_comments (run after ed_case_info)
USE ed5;

CREATE TABLE ed_case_comments (
    case_id VARCHAR(10) NOT NULL,
    chair_comments TEXT,
    dean_comments TEXT,
    faculty_comments TEXT,
    student_comments TEXT,
    PRIMARY KEY (case_id),
    FOREIGN KEY (case_id) REFERENCES ed_case_info (case_id) ON DELETE CASCADE
);

-- Record 1: added manually in phpMyAdmin (Insert tab)
--   case_id = CR-901, faculty_comments = Student admitted it in the meeting, all other comments NULL

-- Record 2: added with an SQL query
INSERT INTO ed_case_comments (case_id, chair_comments, dean_comments, faculty_comments, student_comments)
VALUES ('CR-902', NULL, NULL, 'Second case this term', 'I did not know it was not allowed');
