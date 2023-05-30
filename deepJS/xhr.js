// Запросы на сервер. Fetch, XMLHttpRequest(XHR), Ajax
// из сайта json placeholder
const requestURL = 'https://jsonplaceholder.typicode.com/users'

const xhr = new XMLHttpRequest()
// Запросы get, post, delete, patch и многое другое 

// чтобы получить какие-то данные из сервера нужен запрос get
xhr.open('GET', requestURL)

// метод нужен для того, чтобы посмотреть в консоль какие данные пришли
xhr.onload = () => {
    // ошибка может быть выдана и в такой форме:
    // что больше 400 статуса - это ошибка 
    if (xhr.status >= 400){
        console.error(xhr.response)
    } else {
    // чтобы обратиться именно к объекту, мы используем глобальный метод JSON
    console.log(JSON.parse(xhr.response))
    // console.log(xhr.response)
    }
}

// или же другим способом: 
xhr.responseType = 'json'

// как отрабатывать ошибки? 
xhr.onerror = () => {
    console.log(xhr.response)
}

// отправляем запрос на сервер 
xhr.send()

// 
function sendRequest(method, url, body = null){
    return new Promise(() => {
        xhr.open(method, url)

        xhr.responseType = 'json'
        xhr.setRequestHeader('Content-type', 'application/json')

        xhr.onload = () => {
            if(xhr.status >= 400){
                console.error(xhr.response)
            } else {
                console.log(JSON.parse(xhr.response))
            }
        }

        xhr.onerror = () => {
            console.log(xhr.response)
        }

        xhr.send(JSON.stringify(body))
    })
}

// sendRequest('GET', requestURL)
//     .then(data => console.log(data))
//     .catch(err => console.log(err))
const body =  {
    name: 'Mango',
    age: 26
}

sendRequest('POST', requestURL, body )
    .then(data => console.log(data))
    .catch(err => console.log(err))