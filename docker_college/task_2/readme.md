# Задание 2

## 1.

```
docker run -d --name my_nginx -p 80:80 nginx
```

<a href="https://ibb.co/G0r50Kn"><img src="https://i.ibb.co/G0r50Kn/2024-10-26-212759994.png" alt="2024-10-26-212759994" border="0"></a>


```
docker ps
```

<a href="https://ibb.co/tJQSt69"><img src="https://i.ibb.co/tJQSt69/2024-10-26-212925829.png" alt="2024-10-26-212925829" border="0"></a>


## 2.

```
 docker stop
```
<a href="https://ibb.co/Z6QdR2k"><img src="https://i.ibb.co/Z6QdR2k/2024-10-26-213404906.png" alt="2024-10-26-213404906" border="0"></a>
```
docker start
```
<a href="https://ibb.co/6WhLzKP"><img src="https://i.ibb.co/6WhLzKP/2024-10-26-213435802.png" alt="2024-10-26-213435802" border="0"></a>

```
docker ps -a.
```
<a href="https://ibb.co/Bg2N6L3"><img src="https://i.ibb.co/Bg2N6L3/2024-10-26-213512327.png" alt="2024-10-26-213512327" border="0"></a>

## 3.

```
docker pause my_nginx
```
<a href="https://ibb.co/XyT9Hb9"><img src="https://i.ibb.co/XyT9Hb9/image.png" alt="image" border="0"></a>

```
docker unpause
```
<a href="https://ibb.co/dJbc6fQ"><img src="https://i.ibb.co/dJbc6fQ/image.png" alt="image" border="0"></a>

## 4.

```
 docker logs my_nginx
```
<a href="https://ibb.co/VVrGdwL"><img src="https://i.ibb.co/VVrGdwL/image.png" alt="image" border="0"></a>

## 5. 

```
docker stop my_nginx
```
<a href="https://ibb.co/j5hn3Xz"><img src="https://i.ibb.co/j5hn3Xz/image.png" alt="image" border="0"></a>

```
 docker rm my_nginx
```
<a href="https://ibb.co/VvgSQB1"><img src="https://i.ibb.co/VvgSQB1/image.png" alt="image" border="0"></a>

## 6.


```
docker volume create nginx_data
```
<a href="https://ibb.co/6bctpDS"><img src="https://i.ibb.co/6bctpDS/image.png" alt="image" border="0"></a>

```
docker run -d --name my_nginx_data -v nginx_data:/usr/share/nginx/html -p 8080:80 nginx
```
<a href="https://ibb.co/WkVyhQt"><img src="https://i.ibb.co/WkVyhQt/image.png" alt="image" border="0"></a>S







