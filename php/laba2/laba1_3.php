<?php
$usdToRubExchangeRate = 78.9;  
$rubToCnyExchangeRate = 0.08; 

$usdAmount = 1000;

$rubAmount = $usdAmount * $usdToRubExchangeRate;

$cnyAmount = $rubAmount * $rubToCnyExchangeRate;

echo "1000 USD в рублях: " . $rubAmount . " RUB";
echo "1000 USD в юанях: " . $cnyAmount . " CNY";
?>