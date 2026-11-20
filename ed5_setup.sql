-- Creates the ed5 database used by the Case Report Form app (COMP 2210)
CREATE DATABASE IF NOT EXISTS ed5 CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE ed5;

CREATE TABLE IF NOT EXISTS users (
    user_id VARCHAR(10) PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    email VARCHAR(25) NULL,
    department VARCHAR(35) NULL,
    user_type ENUM('student','faculty','chair','dean') NOT NULL
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS ed_case_info (
    case_id VARCHAR(10) PRIMARY KEY,
    student_id VARCHAR(10) NOT NULL,
    faculty_id VARCHAR(10) NOT NULL,
    chair_id VARCHAR(10) NULL,
    dean_id VARCHAR(10) NULL,
    Term VARCHAR(30) NOT NULL,
    Assignment_number VARCHAR(30) NOT NULL,
    ed_violation_description TEXT NOT NULL,
    violation_date DATE NOT NULL,
    FOREIGN KEY (student_id) REFERENCES users(user_id),
    FOREIGN KEY (faculty_id) REFERENCES users(user_id),
    FOREIGN KEY (chair_id) REFERENCES users(user_id),
    FOREIGN KEY (dean_id) REFERENCES users(user_id)
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS ed_case_comments (
    case_id VARCHAR(10) PRIMARY KEY,
    chair_comments TEXT NULL,
    dean_comments TEXT NULL,
    faculty_comments TEXT NULL,
    student_comments TEXT NULL,
    FOREIGN KEY (case_id) REFERENCES ed_case_info(case_id) ON DELETE CASCADE
) ENGINE=InnoDB;
