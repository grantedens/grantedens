CREATE TABLE instructors
(
    instructor_id INT PRIMARY KEY IDENTITY(1,1),
    instructor_name VARCHAR(50) NOT NULL
);

CREATE TABLE students
(
    student_id INT PRIMARY KEY IDENTITY(1,1),
    student_name VARCHAR(50) NOT NULL,
    major VARCHAR(50) NOT NULL,
    grade_level INT NOT NULL,
    age INT NOT NULL
);
CREATE TABLE classes
(
    class_id INT PRIMARY KEY IDENTITY(1,1),
    class_name VARCHAR(50) NOT NULL,
    class_number VARCHAR(50) NOT NULL,
    instructor_id INT NOT NULL,
    room_number VARCHAR(50) NOT NULL,
    FOREIGN KEY (instructor_id) REFERENCES instructors(instructor_id)
);





CREATE TABLE enrollments
(
    enrollment_id INT PRIMARY KEY IDENTITY(1,1),
    class_id INT NOT NULL,
    student_id INT NOT NULL,
    FOREIGN KEY (class_id) REFERENCES classes(class_id),
    FOREIGN KEY (student_id) REFERENCES students(student_id),
);
INSERT SAMPLE DATA
INSERT INTO instructors (instructor_name) VALUES ('John Doe');
INSERT INTO instructors (instructor_name) VALUES ('Jane Smith');
INSERT INTO instructors (instructor_name) VALUES ('Bob Johnson');
INSERT INTO classes (class_name, class_number, instructor_id, room_number) VALUES ('Programming 101', 'CSE-101', 1, 'B102');
INSERT INTO classes (class_name, class_number, instructor_id, room_number) VALUES ('Database Systems', 'CSE-205', 2, 'A201');
INSERT INTO classes (class_name, class_number, instructor_id, room_number) VALUES ('Web Development', 'CSE-303', 3, 'C305');


INSERT INTO students (student_name, major, grade_level, age) VALUES ('Alice', 'Computer Science', 1, 20);
INSERT INTO students (student_name, major, grade_level, age) VALUES ('Bob', 'Computer Science', 2, 21);
INSERT INTO students (student_name, major, grade_level, age) VALUES ('Charlie', 'Computer Science', 3, 22);
INSERT INTO students (student_name, major, grade_level, age) VALUES ('David', 'Computer Science', 4, 23);
INSERT INTO students (student_name, major, grade_level, age) VALUES ('Eve', 'Computer Science', 1, 20);
INSERT INTO students (student_name, major, grade_level, age) VALUES ('Frank', 'Computer Science', 2, 21);
INSERT INTO students (student_name, major, grade_level, age) VALUES ('George', 'Computer Science', 3, 22);
INSERT INTO students (student_name, major, grade_level, age) VALUES ('Harry', 'Computer Science', 4, 23);
INSERT INTO students (student_name, major, grade_level, age) VALUES ('Igor', 'Computer Science', 1, 20);
INSERT INTO students (student_name, major, grade_level, age) VALUES ('Jack', 'Computer Science', 2, 21);
student_id, class_id) VALUES (5, 2);
INSERT INTO enrollments (student_id, class_id) VALUES (1, 4);
INSERT INTO enrollments (student_id, class_id) VALUES (2, 5);
INSERT INTO enrollments (student_id, class_id) VALUES (3, 6);
INSERT INTO enrollments (student_id, class_id) VALUES (4, 4);
INSERT INTO enrollments (student_id, class_id) VALUES (5, 5);
INSERT INTO enrollments (student_id, class_id) VALUES (6, 6);
INSERT INTO enrollments (student_id, class_id) VALUES (7, 4);
INSERT INTO enrollments (student_id, class_id) VALUES (8, 5);
INSERT INTO enrollments (student_id, class_id) VALUES (9, 6);
INSERT INTO enrollments (student_id, class_id) VALUES (10, 4);
CREATE TABLE credentials (
username varchar(20) NOT NULL,
password varchar(10) NOT NULL,
PRIMARY KEY (username)

);
INSERT INTO credentials (username, password) 
VALUES ('user', 'pass');

–Add more insert statements if you want to create more rows
ALTER TABLE classes
add meeting_time varchar(10) NULL;
update classes
set meeting_time = '10AM';
–adding meeting time column and setting field values
–Let’s add instructor_name to classes to make things easier
alter table classes 
ADD instructor_name varchar(50);
update classes
set classes.instructor_name = instructors.instructor_name
from classes
join instructors
on classes.instructor_id = instructors.instructor_id;
