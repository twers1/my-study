<?php
$num = '12345';

$digits = str_split($num);

$sum = 0;

foreach ($digits as $digit) {
    $sum += intval($digit);
}

echo "Сумма цифр числа $num равна $sum";
?>