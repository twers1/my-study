Запрос: Найти клиентов, потративших более 50 000 рублей
```
SELECT c.Имя, c.Фамилия, SUM(s.Сумма_покупки) AS Общая_сумма
FROM Sales s
JOIN Customers c ON s.Клиент_ID = c.ID
GROUP BY c.ID
HAVING Общая_сумма > 50000
ORDER BY Общая_сумма DESC;
```