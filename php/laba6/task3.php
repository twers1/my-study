<?php
$weekdays = array(
    "ru" => array(
        1 => "Пн.",
        2 => "Вт.",
        3 => "Ср.",
        4 => "Чт.",
        5 => "Пт.",
        6 => "Сб.",
        7 => "Вс."
    ),
    "en" => array(
        1 => "Mon.",
        2 => "Tue.",
        3 => "Wed.",
        4 => "Thu.",
        5 => "Fri.",
        6 => "Sat.",
        7 => "Sun."
    )
);
$lang = "ru"; 
$day = 3;   

echo "День недели: " . $weekdays[$lang][$day] . " № " . $day;
?>