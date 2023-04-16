console.log('Request data...')
// Это асинхронность с помощью callbackов
// Данный вариант плох, так как используется огромная вложенность
setTimeout(function() {
    console.log('Preparing data')

    const backendData = {
        server: 'aws',
        post: 2000,
        statuc: 'working'
    }

    setTimeout(() => {
        backendData.modifed = true
        console.log('Data receiived', backendData)
    }, 2000)
}, 2000)

// Сейчас мы сделаем то же самое, только уже с promise

const promise = new Promise(function(resolve, reject) {
    setTimeout(function() {
        console.log('Preparing data')
        const backendData = {
            server: 'aws',
            post: 2000,
            statuc: 'working'
        }
        resolve(backendData) // заверши нашу операцию 

    },2000)
})
// resolve - вызывается тогда, когда закончена асинхронная операция, и причем, она закончена успешно
// reject - возвращает Promise который был отклонён
// у каждого promise есть свои методы
promise.then(data => {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            data.modifed =true
            resolve(data)
        }, 2000)
    })

    // promise2.then(clientData => {
    //     console.log('Data receiived', clientData)
    // })
})
    .then(clientData => {
    // console.log('Data receiived', clientData)
    clientData.fromPromise = true
    return clientData
    })
    .then(data => {
        console.log('Modified', data)
    })// когда выполнится promise => сделай это 
    .catch(err => console.log('Error', err)) // catch вызывается тогда, когда будет ошибка
    .finally(() => console.log('Finally')) // он вызывается в любом случае, будь то была ошибка или же ее не было 

// тут выполниться один уровень вложенности

const sleep = ms => new Promise(resolve => setTimeout(() => resolve(), ms))

sleep(2000).then(() => {
    console.log('After 2 sec')
})
sleep(3000).then(() => {
    console.log('After 3 sec')
})

// Еще 2 возможности promise 

Promise.all([sleep(2000), sleep(5000)]) // метод all - возвращает Promise, будет выполнен только тогда, когда выполняться все промисы, которые мы указали
    .then(() => {
        console.log('All promises')
    })

Promise.race(sleep(2000), sleep(5000)).then(() => {
    console.log('Race promises')
}) // метод race - он принимает набор промисов, и самый первый промис, который сработает, тот и вызовется в консоль
 
// Promise - это определенная обертка над асинхронностью, которая просто добавляет удобства для написания кода

