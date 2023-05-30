// Метод Fecth
const requestURL = 'https://jsonplaceholder.typicode.com/users'
function sendRequest(method, url, body = null){
    const headers = {
        'Content-type': 'application/json'
    }
    return fetch(url,{
        method: method,
        body: JSON.stringify(body),
        headers: headers
    }).then(response => {
        if(response.ok) {
            // показывает все объекты в браузере
            return response.json()
        }
        // первый способ вернуть ошибку в fetch
        return response.json().then(error => {
            const e = new Error('Что-то пошло не так. Ошибочка')
            e.data = error
            throw e
        })
        
    })
}

const body =  {
    name: 'Mango',
    age: 26
}

sendRequest('POST', requestURL, body )
    .then(data => console.log(data))
    .catch(err => console.log(err))