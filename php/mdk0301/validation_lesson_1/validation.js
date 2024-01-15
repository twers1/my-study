document.addEventListener("DOMContentLoaded", function () {
    const form = document.querySelector("registrationForm");
    const usernameInput = document.getElementById("username");
    const passwordInput = document.getElementById("password");
    const emailInput = document.getElementById("email");

    form.addEventListener("submit", async function (event) {
        event.preventDefault();

        const response = await fetch(form.action, {
            method: "POST",
            body: new FormData(form)
        })

        const errors = await response.json()

        if(errors) {
            dispatchEvent('usernameError', errors.username)
            dispatchEvent('passwordError', errors.password)
            dispatchEvent('emailError', errors.email)
        } else {
            hideError('usernameError')
            hideError('passwordError')
            hideError('emailError')
        }
    })

    function displayError(elementId, message) {
        const errorElement = document.getElementById(elementId)
        errorElement.textContent = message
        errorElement.style.display = 'block'
    }

    function hideError(elementId){
        const errorElement = document.getElementById(elementId)
        errorElement.textContent = '';
        errorElement.style.display = 'none'
    }
})