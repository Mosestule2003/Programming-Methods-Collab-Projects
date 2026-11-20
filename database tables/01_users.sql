-- Table 1 of 3: users (run this one first)
USE ed5;

CREATE TABLE users (
    user_id VARCHAR(10) NOT NULL,
    name VARCHAR(50) NOT NULL,
    email VARCHAR(25),
    department VARCHAR(35),
    user_type ENUM('student', 'faculty', 'chair', 'dean') NOT NULL,
    PRIMARY KEY (user_id)
);

-- Record 1: added manually in phpMyAdmin (Insert tab)
--   user_id = T00100001, name = Sample Student, email = sample@mytru.ca,
--   department = Computing Science, user_type = student

-- Record 2: added with an SQL query
INSERT INTO users (user_id, name, email, department, user_type)
VALUES ('F001', 'Dr Jane Faculty', NULL, 'Computing Science', 'faculty');
