const delay = ms => {
    return new Promise(resolve => setTimeout(() =>resolve, ms));
}

delay(2000).then(()=> console.log('2 sec'))

const url = 'https://jsonplaceholder.typicode.com/todos/1'

// Пример 1 
function fetchTodos(){
    console.log('Fetch todo started...')
    return delay(2000)
        .then(()=>{
            // fetch(url).then(res => res.json())
            return fetch(url)
    }).then(res => res.json())
}

fetchTodos()
    .then(data => {
        console.log('Data: ', data)
    })
    .catch(e => console.error(e))


// ASYNC | AWAIT 
// Пример 2 
async function fetchAsyncTodos(){
    console.log('Fetch todo started...')
    try{
        await delay(2000)
        const response = await fetch(url)
        const data = await response.json()
        console.log('Data: ', data)
    } catch(e){
        console.error(e)
    } finally {
        console.log('finally')
    }
}

fetchAsyncTodos()
