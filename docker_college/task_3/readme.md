# Задание №3: Использование Docker-хранилища

## Описание задачи:
Создание и настройка тома для хранения данных веб-приложения, а также использование различных методов монтирования данных в контейнеры Docker.

### Шаги выполнения задания:

#### 1. Создание тома app_data
Для начала создадим том с именем app_data, который будем использовать для хранения данных нашего веб-приложения:
docker volume create app_data

<a href="https://ibb.co/LrLxSqX"><img src="https://i.ibb.co/LrLxSqX/image.png" alt="image" border="0"></a>


#### 2. Запуск контейнера с веб-сервером и монтированием тома
Теперь создадим и запустим контейнер на базе образа Nginx, смонтировав созданный том в директорию /usr/share/nginx/html (где обычно находятся статические файлы):
docker run -d \
  --name nginx-app \
  -p 8080:80 \
  -v app_data:/usr/share/nginx/html \
  nginx:alpine


<a href="https://ibb.co/KFtcWwj"><img src="https://i.ibb.co/KFtcWwj/2024-10-26-215029905.png" alt="2024-10-26-215029905" border="0"></a>


#### 3. Создание простого HTML-файла и размещение его в томе
На хостовой машине создадим HTML-файл с приветственным сообщением и сохраним его в директорию тома:
docker cp index.html nginx-app:/usr/share/nginx/html/

<a href="https://ibb.co/VWr5qmG"><img src="https://i.ibb.co/VWr5qmG/image.png" alt="image" border="0"></a>

#### 5. Просмотр информации о томе
Чтобы узнать, где на хосте хранится том и какие контейнеры его используют, выполним следующую команду:
docker inspect app_data

<a href="https://ibb.co/wJYjYJV"><img src="https://i.ibb.co/wJYjYJV/image.png" alt="image" border="0"></a>

#### 6. Использование bind mount для монтирования директории хоста в контейнер


Затем запустим новый контейнер Nginx, смонтировав эту директорию через bind mount:
docker run -d \
  --name nginx-bind-mount \
  -p 8090:80 \
  -v /path/to/host_dir:/usr/share/nginx/html \
  nginx:alpine

<a href="https://ibb.co/4jRzxj7"><img src="https://i.ibb.co/4jRzxj7/image.png" alt="image" border="0"></a>


#### 7. Удаление контейнера и проверка сохранения данных
Остановим и удалим контейнер с веб-сервером:
docker stop nginx-app
docker rm nginx-app

<a href="https://ibb.co/d6NzyS5"><img src="https://i.ibb.co/d6NzyS5/image.png" alt="image" border="0"></a>

Запустим новый контейнер с тем же томом:
docker run -d \
  --name new-nginx-app \
  -p 8100:80 \
  -v app_data:/usr/share/nginx/html \
  nginx:alpine


<a href="https://ibb.co/wy7gg6F"><img src="https://i.ibb.co/wy7gg6F/image.png" alt="image" border="0"></a>

#### 8. Удаление тома

docker volume rm app_data

