<?php
$multidimensionalArray = array(
    "CMS" => array("Joomla", "Drupal"),
    "color" => array("Зеленый", "Красный")
);

echo $multidimensionalArray["CMS"][0] . " " . $multidimensionalArray["CMS"][1] . " " . $multidimensionalArray["color"][0] . " " . $multidimensionalArray["color"][1];
?>