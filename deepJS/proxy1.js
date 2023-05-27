// Proxy. Объекты, функции, классы 


// Objects proxy
const person = {
    name: 'Person',
    age: 18, 
    job: 'Fullstack'
}


const op = new Proxy(person, {
    get(target, prop){
        console.log('Target', target)
        console.log(`Getting prop ${prop}`, prop)
        return target[prop]
    },
    // у нас теперь стоит ловушка на метод get. В качестве таргета мы получаем сам объект Perso
    // а в prop - мы получаем любое поле, которое мы вызвали 
    set(target, prop, value){
        if(prop in target){
            target[prop] = value
        } else {
            throw new Error(`No ${prop} field in target`)
        }
        // Если мы тут изменим поле, которое есть в таргете, то в конце нам выведет новое значение нашего объекта Person
    },
    has(target, prop) {
        return ['age',  'job'].includes(prop)
    },
    // метод has должен вернуть либо true, либо false 
    deleteProperty(target, prop){
        console.log('Deleting prop', prop)
        delete target[prop]
        return true
        // метод deleteProperty позволяет нам удалять какое-то свойство из объекта
    }
})

// Functons proxy

const log = text => `Log: ${text}`
const fp = new Proxy(log, {
    // target - сама функция, thisArg - это контекст вызова , args - все параметры, которые мы передали все параметры 
    apply(target, thisArg, args){
        console.log('Calling fn...')
        return target.apply(thisArg, args).toUpperCase()
    }
})


// Classes proxy

class Person {
    constructor(name, age){
        this.name = name
        this.age = age
    }
}

const PersonProxy = new Proxy(Person, {
    // для того, чтобы отследить инициализацию  какого-то нового класса - используем ловушку construct
    construct(target, args){
        console.log('Construct...')
        // return new target(...args)
        return new Proxy(new target(...args),{
            get(tar, prop){
                console.log(`Getting prop ${prop}`, prop)
                return tar[prop]
            }
        })
    }
})

const p = new PersonProxy('Xddes', 40)