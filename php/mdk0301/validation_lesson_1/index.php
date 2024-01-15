<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Регистрация</title>
</head>
<body>
    <div class="container">
        <form action="process_registration.php" method="post" id="registrationForm">
            <label for="username">Логин:</label>
            <input type="text" id="username" name="username" required>
            <span id="usernameError" class="error"></span>

            <label for="password">Пароль:</label>
            <input type="password" id="password" name="password" required>
            <span id="passwordError" class="error"></label>

            <label for="email">Email:</label>
            <input type="email" id="email" name="email" required>
            <span id="emailError" class="error"></span>

            <button type="submit">Зарегистрироваться</button>
        </form>
    </div>
    <script src="validation.js"></script>
</body>
</html>