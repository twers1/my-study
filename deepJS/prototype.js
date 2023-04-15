// PROTOTYPE

// const person = { // создаем объект(объект - это то, что находится в фигурных скобках)
//     name: 'Sima',
//     age: 18,
//     greet: function(){
//         console.log('Greet!')
//     }
// }

const person = new Object({ 
    name: 'Sima',
    age: 18,
    greet: function(){
        console.log('Greet!')
    }
})

Object.prototype.sayHello = function(){
    console.log('Hello!')
}

const lena = Object.create(person)
lena.name = 'Elena'

const str = new String('I am string')