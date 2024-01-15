<?php

if($_SERVER["REQUEST_METHOD"] == "POST") {
    $username = $_POST["username"];
    $password = $_POST["password"];
    $email = $_POST["email"];

    $errors = [];

    if(!validateUsername($username)) {
        $errors["username"] = "Логин должен содержать только буквы и цифры.";
    }

    if(!validatePassword($password)){
        $errors["password"] = "Пароль должен содержать не менее 6 символов.";
    }

    if(!validateEmail($email)){
        $errors["email"] = "Некорректный адрес электронной почты.";
    }

    if(empty($errors)) {
        echo "Регистрация прошла успешно";
    } else {
        echo json_encode($errors);
    }
}

function validateUsername($username) {
    return preg_match("/^[a-zA-Z0-9]+$/", $username);
}

function validatePassword($password){
    return strlen($password) >= 6;
}

function validateEmail($email){
    return filter_var($email, FILTER_VALIDATE_EMAIL);
}