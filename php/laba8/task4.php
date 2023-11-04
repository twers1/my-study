<?php
$sum = 0;

for ($i = 1; $i <= 10; $i++) {
    $sum += $i;
    echo "Итерация $i: \$sum = $sum";
}

echo "Сумма чисел от 1 до 10 равна $sum";
?>