// контекс this 

function hello() {
    console.log('Hello', this)
}

const person2 = {
    name: 'Sima',
    age: 18,
    sayHello2: hello,
    sayHelloWindow: hello.bind(window), // функция bind - мы можем передать тот контекс, который будет привязан к этой функции
                            // даже если мы напишем в скобках "this", то все равно будет показываться window, потому что this === window(true)
    logInfo: function(job, phone ) {
        console.group(`${this.name} info:`)
        console.log(`Name is ${this.name}`) 
        console.log(`Age is ${this.age}`) 
        console.log(`Job is ${job}`)
        console.log(`Phone is ${phone}`)
        console.groupEnd()
        // this в данном случае будет являться объектов person2
    }
}

const lena2 = {
    name: 'Elena',
    age: 23
}

// BIND

// const fnLenaLogInfo = person2.logInfo.bind(lena2, 'frontend', '8999999999')// мы воспользовались функцией logInfo, но в него мы передали другой контекст (lena2), и когда мы вызываем эту функцию - ключевое слово "this"
// // указывает на контекс объекта, который указали в скобках
// fnLenaLogInfo()

person2.logInfo.bind(lena2, 'backend', '8999999999')()

// CALL 

person2.logInfo.call(lena2, 'frontend', '8999999999')

// APPLY

person2.logInfo.apply(lena2, ['frontend', '8999999999'])

// ПРАКТИКА(prototype+this)
// Написать функцию, которая позволит умножить числа в массиве на определенное число
const array = [1, 2, 3, 4, 5]

// ПЕРВЫЙ СПОСОБ 

// function multBy(arr, n){
//     return arr.map(function(i) {
//         return i * n
//     })
// }
// console.log(multBy(array, 5))

// ВТОРОЙ СПОСОБ 
Array.prototype.multBy = function(n) {
    return this.map(function(i) {
        return i * n
    })
}

console.log(array.multBy(2))


// Конспект:

// 1. Ключевое слово this всегда динамичное, оно указывает на тот объект в контексте которого оно было вызвано
// 2. функция bind - в качестве значения этой функции му можем передать тот контекст который будет привязан у вызываемой функции
// 3. сам по this себе указывает на глобальный объект window
// 4. метод bind на самом деле не вызывает функцию, а возвращает новую функцию которая уже привязала к себе новый контекст
// 5. метод group у объекта console
// 6. С помощью метода bind, помимо того что первым параметром мы указываем контекст который должен быть привязан к новой функции, другими параметрами мы можем передавать следующие параметры которые нужны функции
// 7. Метод call. Отличие от метода bind, что он метод call сразу же вызывает эту функцию, а метод bind в свою очередь возвращает нам новую функцию, и её мы можем вызвать тогда, когда нам угодно
/* 8. Метод apply. В отличие от методов bind и call, где можно бесконечное число параметров, в метод apply мы всегда передаем два параметра.У метода apply второй параметр всегда массив, и этот массив состоит из аргументов которые попадут в эту функцию.
Метод apply сразу же вызывает эту функцию. */