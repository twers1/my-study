```
-- 1. Создание новой базы данных
CREATE DATABASE college_db;
USE college_db;

-- 2. Создание таблицы студентов
CREATE TABLE students (
    student_id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    phone VARCHAR(15),
    enrollment_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- 3. Создание таблицы курсов
CREATE TABLE courses (
    course_id SERIAL PRIMARY KEY,
    course_name VARCHAR(100) NOT NULL,
    department VARCHAR(100),
    credits INT NOT NULL
);

-- 4. Создание таблицы преподавателей
CREATE TABLE instructors (
    instructor_id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    department VARCHAR(100)
);

-- 5. Создание таблицы регистрации на курсы
CREATE TABLE enrollments (
    enrollment_id SERIAL PRIMARY KEY,
    student_id INT NOT NULL,
    course_id INT NOT NULL,
    enrollment_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (student_id) REFERENCES students(student_id),
    FOREIGN KEY (course_id) REFERENCES courses(course_id)
);

-- 6. Заполнение таблиц тестовыми данными
INSERT INTO students (name, email, phone) VALUES
('Иван Иванов', 'ivan.ivanov@example.com', '+79161234567'),
('Мария Смирнова', 'maria.smirnova@example.com', '+79263334455'),
('Алексей Кузнецов', 'alexey.kuznetsov@example.com', '+79554443322'),
('Екатерина Орлова', 'ekaterina.orlova@example.com', '+79881112233'),
('Дмитрий Васильев', 'dmitry.vasilyev@example.com', '+79992223344');

INSERT INTO courses (course_name, department, credits) VALUES
('Программирование 101', 'Информатика', 3),
('Математика 101', 'Математика', 4),
('Физика 101', 'Физика', 3),
('Химия 101', 'Химия', 3),
('Литература', 'Гуманитарные науки', 2);

INSERT INTO instructors (name, email, department) VALUES
('Профессор Петров', 'petrov@example.com', 'Информатика'),
('Профессор Сидоров', 'sidorov@example.com', 'Математика'),
('Профессор Ковалев', 'kovalev@example.com', 'Физика'),
('Профессор Соколова', 'sokolova@example.com', 'Химия'),
('Профессор Романова', 'romanova@example.com', 'Гуманитарные науки');

INSERT INTO enrollments (student_id, course_id) VALUES
(1, 1),
(1, 2),
(2, 3),
(3, 4),
(4, 5);

-- 7. Проверка данных
SELECT * FROM students;
SELECT * FROM courses;
SELECT * FROM instructors;
SELECT * FROM enrollments;

-- 8. Добавление нового столбца в таблицу студентов
ALTER TABLE students ADD COLUMN address VARCHAR(255);

-- 9. Обновление данных
UPDATE students SET address = 'г. Москва, ул. Академическая, д.10' WHERE student_id = 1;

-- 10. Удаление записи
DELETE FROM enrollments WHERE enrollment_id = 1;
```
