// weak map - это тот же map, но у него есть особенности 

// с помощью него мы можем избегать различных утечек данных в JavaScript

let obj = {
    name: 'weakMap'
}

const arr = [obj]

obj = null 
console.log(obj)

// в weakmap ключами могут быть только объекты
// const map = new WeakMap([
//     [obj, 'hello'],
// ])

// get set delete has - это все методы weakmap

const cache = new WeakMap()

function cacheUser(user){
    if(!cache.has(user)){
        cache.set(user, new Date())
    }
    return cache.get(user)
}

let lena = {name: 'Elena'}
let alex = {name: 'Alex'}

cacheUser(lena)
cacheUser(alex)

console.log(cache.has(lena))
console.log(cache.has(alex))