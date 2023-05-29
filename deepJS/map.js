// ЗАПУСТИТЬ NODE В ТЕРМИНАЛЕ С ПОМОЩЬЮ КОМАНДЫ node map !

const obj = {
    name: 'Владилен',
    age: 25,
    budget: 40000
}

// Ключ + значение в массиве
const entries = [
    ['name', 'Владилен'],
    ['age', 25],
    ['budget', 40000]
]

console.log(Object.entries(obj)) // выводит массив с его значениями
console.log(Object.fromEntries(entries)) // выводит объект

// Map - структура данных 
const map = new Map(entries)

console.log(map.get('name')) // выводит значение по ключу

map
    .set('newField', 42) // добавляет новые значения в map
    .set(obj, 'Value of object')
    .set(NaN, 'NaN')

console.log(map)

map.delete('newField') // удаляет значение по ключу
console.log(map.has('newField')) // проверка наличия ключа
console.log(map.size) // количество ключей 
// map.clear() // очищает все ключи
// console.log(map.size)


// Дополнительные встроенные методы

for(let entry of map.entries()){
    console.log(entry)
}

for(let [key, value] of map.entries()){
    console.log(key, value)
}

for(let val of map.values()){
    console.log(val) // выводит значение по ключу
}

// а для того, чтобы вывести только ключи. Используем метод keys

for(let key of map.keys()){
    console.log(key)
}


map.forEach((value, key, map) => {
    console.log(value, key, map)
})



// Дополнительная информация о map

// первый способ
const array = [...map]
// второй способ 
const array1 =Array.from(map)

console.log(array)

const mapObj = Object.fromEntries(map.entries())

console.log(mapObj)


// Применение карт

const users = [
    {name: 'Владилен', age: 25},
    {name: 'Иван', age: 30},
    {name: 'Петр', age: 20}
]

const visits = new Map()

visits
    .set(users[0], new Date())
    .set(users[1], new Date(new Date().getTime() + 1000 * 60 * 60 * 24 * 2))
    .set(users[2], new Date(new Date().getTime() + 10 * 60 * 60 * 24 * 2))

function lastVisit(user){
    return visits.get(user)
}

console.log(lastVisit(users[0]))