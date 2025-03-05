
-- Создание базы данных (если необходимо)
CREATE DATABASE IF NOT EXISTS autoservice;
USE autoservice;

-- Таблица клиентов
CREATE TABLE Клиенты (
    id INT AUTO_INCREMENT PRIMARY KEY,
    ФИО VARCHAR(255) NOT NULL,
    Телефон VARCHAR(20) NOT NULL,
    Email VARCHAR(255) UNIQUE,
    Адрес TEXT
);

-- Таблица автомобилей
CREATE TABLE Автомобили (
    id INT AUTO_INCREMENT PRIMARY KEY,
    Клиент_id INT NOT NULL,
    Марка VARCHAR(50) NOT NULL,
    Модель VARCHAR(50) NOT NULL,
    Госномер VARCHAR(15) UNIQUE NOT NULL,
    FOREIGN KEY (Клиент_id) REFERENCES Клиенты(id) ON DELETE CASCADE
);

-- Таблица мастеров
CREATE TABLE Мастера (
    id INT AUTO_INCREMENT PRIMARY KEY,
    ФИО VARCHAR(255) NOT NULL,
    Специализация VARCHAR(255) NOT NULL
);

-- Таблица менеджеров
CREATE TABLE Менеджеры (
    id INT AUTO_INCREMENT PRIMARY KEY,
    ФИО VARCHAR(255) NOT NULL,
    Контакт VARCHAR(255) NOT NULL
);

-- Таблица услуг
CREATE TABLE Услуги (
    id INT AUTO_INCREMENT PRIMARY KEY,
    Название VARCHAR(255) NOT NULL,
    Описание TEXT,
    Стоимость DECIMAL(10,2) NOT NULL
);

-- Таблица заказов
CREATE TABLE Заказы (
    id INT AUTO_INCREMENT PRIMARY KEY,
    Клиент_id INT NOT NULL,
    Автомобиль_id INT NOT NULL,
    Мастер_id INT NOT NULL,
    Менеджер_id INT NOT NULL,
    Дата_создания DATE NOT NULL,
    Статус ENUM('Создан', 'В работе', 'Готов', 'Завершено') NOT NULL,
    Общая_стоимость DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (Клиент_id) REFERENCES Клиенты(id) ON DELETE CASCADE,
    FOREIGN KEY (Автомобиль_id) REFERENCES Автомобили(id) ON DELETE CASCADE,
    FOREIGN KEY (Мастер_id) REFERENCES Мастера(id) ON DELETE CASCADE,
    FOREIGN KEY (Менеджер_id) REFERENCES Менеджеры(id) ON DELETE CASCADE
);

-- Таблица расхода запчастей
CREATE TABLE Расход_запчастей (
    id INT AUTO_INCREMENT PRIMARY KEY,
    Заказ_id INT NOT NULL,
    Запчасть_id INT NOT NULL,
    Количество INT NOT NULL,
    FOREIGN KEY (Заказ_id) REFERENCES Заказы(id) ON DELETE CASCADE
);

-- Таблица склада (запчасти)
CREATE TABLE Склад (
    id INT AUTO_INCREMENT PRIMARY KEY,
    Название VARCHAR(255) NOT NULL,
    Количество INT NOT NULL,
    Стоимость DECIMAL(10,2) NOT NULL
);

-- Таблица оплат
CREATE TABLE Оплаты (
    id INT AUTO_INCREMENT PRIMARY KEY,
    Заказ_id INT NOT NULL,
    Сумма DECIMAL(10,2) NOT NULL,
    Дата_оплаты DATE NOT NULL,
    Метод_оплаты ENUM('Наличные', 'Карта', 'Онлайн') NOT NULL,
    FOREIGN KEY (Заказ_id) REFERENCES Заказы(id) ON DELETE CASCADE
);
