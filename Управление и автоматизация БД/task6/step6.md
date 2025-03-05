Запрос: Найти 3 самых продаваемых товара
```
SELECT p.Название, SUM(s.Количество) AS Общее_количество
FROM Sales s
JOIN Products p ON s.Товар_ID = p.ID
GROUP BY p.Название
ORDER BY Общее_количество DESC
LIMIT 3;
