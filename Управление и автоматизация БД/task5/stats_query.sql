
SELECT 
    Мастера.ФИО AS 'ФИО мастера',
    COUNT(Заказы.id) AS 'Количество выполненных заказов',
    SUM(Заказы.Общая_стоимость) AS 'Общая выручка (₽)'
FROM Заказы
JOIN Мастера ON Заказы.Мастер_id = Мастера.id
WHERE Заказы.Статус = 'Завершено'
AND Дата_создания BETWEEN '2024-02-01' AND '2024-02-29' -- Пример для февраля 2024
GROUP BY Мастера.ФИО
ORDER BY 'Общая выручка (₽)' DESC;
