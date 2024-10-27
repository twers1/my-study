FROM nginx:latest

COPY index.html /usr/share/nginx/html/index.html
COPY about.html /usr/share/nginx/html/about.html

COPY styles.css /usr/share/nginx/html/styles.css

COPY nginx.conf /etc/nginx/nginx.conf

RUN rm -rf /var/cache/apt/archives/*
