const set = new Set([1,2,3,3,3,4,5,5,6])

console.log(set) // в консоли он убрал повторяющиеся элементы. тут каждое значение находится в уникальном состоянии

// в set можно передавать что угодно, но он уберет дубликаты и сделает уникальное значение им 

// Методы set

set.add(10).add(20).add(20).add(32)

console.log(set)

console.log(set.has(30)) // проверяет ли есть ли это значение в set
console.log(set.size) // смотрит сколько элементов в set
console.log(set.delete(1)) // удаляет значение в set

// console.log(set.clear())
// console.log(set.size)


// Вспомогательные поля, которые позволяют получить его значение в разных форматах

console.log(set.values())
console.log(set.keys())

// Set - это структура данных, которая проще map'a, и поэтому, values и keys - они выдают нам одно и то же
// эти методы нужны для того, чтобы синхронизироваться с map'ом, чтобы у них была обратная совместимость

console.log(set.entries()) // тут мы получаем массив entries, в котором ключ и значение одинаковы

for(let key of set){
    console.log(key)
}


// Практический пример set. 

// Надо перебирать массив так, чтобы у всех были свои уникальные значения. 

// Первый способ 
function uniqValues(array){
    return [...new Set(array)]
}

// или же воспользоваться другим способом
function uniqValue2(array){
    return Array.from(new Set(array))
}

console.log(uniqValues([1,2,3,3,3,4,5,5,6,4,4,4,8,6]))