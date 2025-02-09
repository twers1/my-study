```
-- 1. Создание новой базы данных
CREATE DATABASE business_db;
USE business_db;

-- 2. Агентство недвижимости
CREATE TABLE real_estate_agents (
    agent_id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    phone VARCHAR(20),
    email VARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE properties (
    property_id SERIAL PRIMARY KEY,
    address VARCHAR(255) NOT NULL,
    city VARCHAR(100) NOT NULL,
    price DECIMAL(15,2) NOT NULL,
    property_type VARCHAR(50),
    agent_id INT NOT NULL,
    FOREIGN KEY (agent_id) REFERENCES real_estate_agents(agent_id)
);

CREATE TABLE clients (
    client_id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    phone VARCHAR(20),
    email VARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE property_requests (
    request_id SERIAL PRIMARY KEY,
    client_id INT NOT NULL,
    property_id INT NOT NULL,
    request_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (client_id) REFERENCES clients(client_id),
    FOREIGN KEY (property_id) REFERENCES properties(property_id)
);

-- 3. Спортивная федерация
CREATE TABLE teams (
    team_id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL
);

CREATE TABLE athletes (
    athlete_id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    team_id INT,
    FOREIGN KEY (team_id) REFERENCES teams(team_id)
);

CREATE TABLE competitions (
    competition_id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    date TIMESTAMP NOT NULL,
    venue VARCHAR(255) NOT NULL
);

CREATE TABLE results (
    result_id SERIAL PRIMARY KEY,
    athlete_id INT NOT NULL,
    competition_id INT NOT NULL,
    result VARCHAR(50) NOT NULL,
    FOREIGN KEY (athlete_id) REFERENCES athletes(athlete_id),
    FOREIGN KEY (competition_id) REFERENCES competitions(competition_id)
);

-- 4. Кинокомпания
CREATE TABLE movies (
    movie_id SERIAL PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    genre VARCHAR(100),
    release_date DATE
);

CREATE TABLE actors (
    actor_id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL
);

CREATE TABLE movie_actors (
    movie_id INT NOT NULL,
    actor_id INT NOT NULL,
    FOREIGN KEY (movie_id) REFERENCES movies(movie_id),
    FOREIGN KEY (actor_id) REFERENCES actors(actor_id),
    PRIMARY KEY (movie_id, actor_id)
);

CREATE TABLE awards (
    award_id SERIAL PRIMARY KEY,
    movie_id INT NOT NULL,
    name VARCHAR(100) NOT NULL,
    year INT NOT NULL,
    FOREIGN KEY (movie_id) REFERENCES movies(movie_id)
);

-- 5. Издательство
CREATE TABLE books (
    book_id SERIAL PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    author VARCHAR(100) NOT NULL,
    publication_date DATE,
    genre VARCHAR(100)
);

CREATE TABLE sales (
    sale_id SERIAL PRIMARY KEY,
    book_id INT NOT NULL,
    copies_sold INT NOT NULL,
    revenue DECIMAL(15,2) NOT NULL,
    FOREIGN KEY (book_id) REFERENCES books(book_id)
);

-- 6. Музей
CREATE TABLE exhibits (
    exhibit_id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    description TEXT,
    period VARCHAR(100)
);

CREATE TABLE exhibitions (
    exhibition_id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    start_date DATE NOT NULL,
    end_date DATE NOT NULL
);

CREATE TABLE exhibition_exhibits (
    exhibition_id INT NOT NULL,
    exhibit_id INT NOT NULL,
    FOREIGN KEY (exhibition_id) REFERENCES exhibitions(exhibition_id),
    FOREIGN KEY (exhibit_id) REFERENCES exhibits(exhibit_id),
    PRIMARY KEY (exhibition_id, exhibit_id)
);

CREATE TABLE visits (
    visit_id SERIAL PRIMARY KEY,
    exhibition_id INT NOT NULL,
    visitor_name VARCHAR(100) NOT NULL,
    visit_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (exhibition_id) REFERENCES exhibitions(exhibition_id)
);

```