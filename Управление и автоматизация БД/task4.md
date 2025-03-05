```
-- Создание таблиц
CREATE DATABASE shop_db;
USE shop_db;

CREATE TABLE Customers (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    city VARCHAR(50),
    registration_date DATE
);

CREATE TABLE Products (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    category VARCHAR(50),
    price DECIMAL(10,2) NOT NULL,
    stock_quantity INT NOT NULL
);

CREATE TABLE Orders (
    id INT AUTO_INCREMENT PRIMARY KEY,
    customer_id INT,
    order_date DATE,
    status ENUM('В обработке', 'Отправлен', 'Доставлен') NOT NULL,
    FOREIGN KEY (customer_id) REFERENCES Customers(id)
);

CREATE TABLE Order_Items (
    id INT AUTO_INCREMENT PRIMARY KEY,
    order_id INT,
    product_id INT,
    quantity INT NOT NULL,
    price DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (order_id) REFERENCES Orders(id),
    FOREIGN KEY (product_id) REFERENCES Products(id)
);

-- Вставка тестовых данных
INSERT INTO Customers (name, email, city, registration_date) VALUES
('Иван Петров', 'ivan.petrov@example.com', 'Москва', '2023-01-15'),
('Мария Иванова', 'maria.ivanova@example.com', 'Санкт-Петербург', '2022-11-20'),
('Сергей Смирнов', 'sergey.smirnov@example.com', 'Казань', '2023-02-10'),
('Елена Орлова', 'elena.orlova@example.com', 'Новосибирск', '2022-12-05');

INSERT INTO Products (name, category, price, stock_quantity) VALUES
('Ноутбук', 'Электроника', 60000.00, 10),
('Смартфон', 'Электроника', 40000.00, 15),
('Пылесос', 'Бытовая техника', 12000.00, 5),
('Чайник', 'Бытовая техника', 3000.00, 20),
('Телевизор', 'Электроника', 50000.00, 8);

INSERT INTO Orders (customer_id, order_date, status) VALUES
(1, '2024-02-10', 'Доставлен'),
(2, '2024-02-12', 'Отправлен'),
(3, '2024-02-15', 'В обработке'),
(1, '2024-02-20', 'Доставлен');

INSERT INTO Order_Items (order_id, product_id, quantity, price) VALUES
(1, 1, 1, 60000.00),
(1, 2, 1, 40000.00),
(2, 3, 2, 12000.00),
(3, 4, 1, 3000.00),
(4, 5, 1, 50000.00);

-- Запрос 1: Сколько заказов сделал каждый клиент
SELECT c.name, COUNT(o.id) AS order_count
FROM Customers c
LEFT JOIN Orders o ON c.id = o.customer_id
GROUP BY c.name;

-- Запрос 2: Самые продаваемые товары
SELECT p.name, SUM(oi.quantity) AS total_sold
FROM Products p
JOIN Order_Items oi ON p.id = oi.product_id
GROUP BY p.name
ORDER BY total_sold DESC;

-- Запрос 3: Клиенты, потратившие более 5000
SELECT c.name, SUM(oi.quantity * oi.price) AS total_spent
FROM Customers c
JOIN Orders o ON c.id = o.customer_id
JOIN Order_Items oi ON o.id = oi.order_id
GROUP BY c.name
HAVING total_spent > 5000;

-- Запрос 4: Полный список заказов с именем клиента
SELECT o.id, c.name, o.order_date, o.status
FROM Orders o
INNER JOIN Customers c ON o.customer_id = c.id;

-- Запрос 5: Найти товары, которые ни разу не были проданы
SELECT p.name
FROM Products p
LEFT JOIN Order_Items oi ON p.id = oi.product_id
WHERE oi.id IS NULL;

-- Запрос 6: Количество заказов по каждому статусу
SELECT o.status, COUNT(o.id) AS order_count
FROM Orders o
GROUP BY o.status;
```