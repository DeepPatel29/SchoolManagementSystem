# School Management System

## Project Overview

The **School Management System** is a windows form application designed to manage the academic processes in a school or educational institution. 
It handles the creation and management of students, instructors, courses, and grades. It also allows for user management, with roles like **Admin** and **Teacher**.

## Features

- User authentication for **Admin** and **Teacher** roles.
- Management of **Students**, **Instructors**, and **Courses**.
- Assignment of **Grades** to students.
- Easy enrollment of students into courses.
- Ability to view student grades and course schedules.
- Genrate a pdf for student performance based on course the student is enrolled.
- Genrate a pdf by course which contains the performance of all sudents enrolled in that course and the average marks for the class.
- Send pdf reports by email.

## Database Schema

The following tables are created in the SQL database:

- **Users**: Stores user information (username, password, user type).
- **Students**: Stores student data, including student number, contact details, and enrollment information.
- **Instructors**: Stores instructor information, including their specialization.
- **Courses**: Stores course details such as name, description, instructor, and schedule.
- **StudentCourses**: Junction table for many-to-many relationship between students and courses.
- **Grades**: Stores student grades for each course.

