```
CREATE DATABASE SupermarketDB;
USE SupermarketDB;

CREATE TABLE Products (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Артикул VARCHAR(255),
    Название VARCHAR(255),
    Цвет VARCHAR(255),
    Паттерн VARCHAR(255),
    Состав VARCHAR(255),
    Категория VARCHAR(100),
    Цена DECIMAL(10,2),
    Количество INT
);

CREATE TABLE Suppliers (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Название VARCHAR(255),
    Город VARCHAR(100),
    Контактное_лицо VARCHAR(100)
);

CREATE TABLE Customers (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Имя VARCHAR(100),
    Фамилия VARCHAR(100),
    Email VARCHAR(255),
    Город VARCHAR(100)
);

CREATE TABLE Sales (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Дата_продажи DATE,
    Клиент_ID INT,
    Товар_ID INT,
    Количество INT,
    Сумма_покупки DECIMAL(10,2),
    FOREIGN KEY (Клиент_ID) REFERENCES Customers(ID),
    FOREIGN KEY (Товар_ID) REFERENCES Products(ID)
);

```