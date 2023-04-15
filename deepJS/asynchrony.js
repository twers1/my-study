// Асинхронность. Что такое Event Loop. JS setTimeout 0 
console.log('Start')
console.log('Start 2')
// Как нам сделать так, чтобы console.log выводился асинхронно, к примеру, через какое-то время
// для этого есть в браузере функция setTimeout
// но в действительности она вызывается через window
setTimeout(function() {
    console.log('Inside timeout, after 2000 seconds')
}, 2000) 

function timeout2sec(){
    console.log('timeout2sec')
}

window.setTimeout(timeout2sec, 2000)

console.log('End')

// Почему поток не блокируется? Почему программа регистрирует это и в нужный момент вызывает?
// - в действительности здесь кроется простой концепт Event Loop. (здесь речь идет не только о setTimeout,
// но и про другие асинхронные функции в js)

$.on('button', 'click', function(){
    console.log('Button clicked')
}) // при вызове асинхронных функций они проходят в web apis -> потом в очередь callback -> а уже потом в call stack

// Вопрос может встретиться на собеседованиях! 
console.log('start')
setTimeout(function() {
    console.log('Inside settimeot')
}, 0) // он регистрирует функцию callback(потому что это стороннее api и закидывает ее в webapi, даже если там ноль)
// и после этого интерплитатор идет и закидывает console.log('end') в stack, но данный console.log
// попадает в очередь и ждет пока закончатся все операции, и только после этого он вызывается
console.log('end')
// почему setTimeout не вызвался после start, мы же не указали на задержку
// - 