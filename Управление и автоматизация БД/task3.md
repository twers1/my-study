```
-- 1. Создание новой базы данных
CREATE DATABASE airline_booking_db;
USE airline_booking_db;

-- 2. Создание таблицы пассажиров
CREATE TABLE passengers (
    passenger_id SERIAL PRIMARY KEY,
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100) NOT NULL,
    birth_date DATE NOT NULL,
    passport_number VARCHAR(20) UNIQUE NOT NULL
);

-- 3. Создание таблицы авиакомпаний
CREATE TABLE airlines (
    airline_id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    airline_code VARCHAR(10) UNIQUE NOT NULL
);

-- 4. Создание таблицы аэропортов
CREATE TABLE airports (
    airport_id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    city VARCHAR(100) NOT NULL,
    airport_code VARCHAR(10) UNIQUE NOT NULL
);

-- 5. Создание таблицы рейсов
CREATE TABLE flights (
    flight_id SERIAL PRIMARY KEY,
    flight_number VARCHAR(20) UNIQUE NOT NULL,
    airline_id INT NOT NULL,
    departure_airport_id INT NOT NULL,
    arrival_airport_id INT NOT NULL,
    departure_time TIMESTAMP NOT NULL,
    arrival_time TIMESTAMP NOT NULL,
    FOREIGN KEY (airline_id) REFERENCES airlines(airline_id),
    FOREIGN KEY (departure_airport_id) REFERENCES airports(airport_id),
    FOREIGN KEY (arrival_airport_id) REFERENCES airports(airport_id)
);

-- 6. Создание таблицы бронирования
CREATE TABLE bookings (
    booking_id SERIAL PRIMARY KEY,
    passenger_id INT NOT NULL,
    flight_id INT NOT NULL,
    booking_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    status VARCHAR(20) CHECK (status IN ('Подтверждён', 'Отменён', 'Ожидает оплаты')) NOT NULL,
    FOREIGN KEY (passenger_id) REFERENCES passengers(passenger_id),
    FOREIGN KEY (flight_id) REFERENCES flights(flight_id)
);

-- 7. Заполнение таблиц тестовыми данными
INSERT INTO passengers (first_name, last_name, birth_date, passport_number) VALUES
('Иван', 'Иванов', '1990-05-15', '1234567890'),
('Мария', 'Смирнова', '1985-07-22', '0987654321'),
('Алексей', 'Кузнецов', '1992-11-30', '1122334455');

INSERT INTO airlines (name, airline_code) VALUES
('Аэрофлот', 'SU'),
('S7 Airlines', 'S7'),
('Уральские авиалинии', 'U6');

INSERT INTO airports (name, city, airport_code) VALUES
('Шереметьево', 'Москва', 'SVO'),
('Домодедово', 'Москва', 'DME'),
('Пулково', 'Санкт-Петербург', 'LED');

INSERT INTO flights (flight_number, airline_id, departure_airport_id, arrival_airport_id, departure_time, arrival_time) VALUES
('SU100', 1, 1, 3, '2024-03-10 12:00:00', '2024-03-10 14:00:00'),
('S7101', 2, 2, 3, '2024-03-11 08:30:00', '2024-03-11 10:30:00'),
('U6205', 3, 3, 1, '2024-03-12 15:45:00', '2024-03-12 17:45:00');

INSERT INTO bookings (passenger_id, flight_id, status) VALUES
(1, 1, 'Подтверждён'),
(2, 2, 'Ожидает оплаты'),
(3, 3, 'Отменён');

-- 8. Запрос для получения списка всех пассажиров, забронировавших рейсы у конкретной авиакомпании
SELECT p.first_name, p.last_name, f.flight_number, a.name AS airline_name
FROM bookings b
JOIN passengers p ON b.passenger_id = p.passenger_id
JOIN flights f ON b.flight_id = f.flight_id
JOIN airlines a ON f.airline_id = a.airline_id
WHERE a.name = 'Аэрофлот';
```