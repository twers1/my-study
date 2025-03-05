Запрос: Определить общую сумму продаж по каждой категории
```
SELECT p.Категория, SUM(s.Сумма_покупки) AS Общая_сумма_продаж
FROM Sales s
JOIN Products p ON s.Товар_ID = p.ID
GROUP BY p.Категория
ORDER BY Общая_сумма_продаж DESC;

```