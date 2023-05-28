const people = [
    {name:'Владилен', age: 25, budget: 40000},
    {name:'Елена', age: 17, budget: 1000},
    {name:'Игорь', age: 49, budget: 4252},
    {name:'Михаил', age: 15, budget: 67474},
    {name:'Василиса', age: 23, budget: 86596},
    {name:'Виктория', age: 28, budget: 100021}
]

// ES 5 
for(let i=0; i<people.length; i++){
    console.log(people[i])
}

// ES 6
for(let i of people){
    console.log(i)
}

// ForEach
// мы делаем какую-то итерацию для каждого элемента 

// пример для ES5 синтаксиса
people.forEach(function(person, index, peopleArr){
    console.log(person)
    console.log(index)
    console.log(peopleArr)
})
// можно использовать без index и peopleArr

// пример для ES6 синтаксиса
people.forEach(person => console.log(person))


// Map
// работает схожим образом как и ForEach. Мы можем с помощью map новые массивы, и как результат - мы заносим их в новую переменнную

// если хотите написать в синтаксисе ES5, то нужно использовать обычную функцию, а не стрелочную, как в ES6
// Синтаксис ES6: 
const newPeople  = people.map(person => {
    return 'Hello ' + person.name
})
console.log(newPeople)


// Filter
// метод filter служит нам для фильтрации по какому-либо условию исходный массив

// Без метода filter, с помощью обычного цикла for
const adults = []
for(let i=0; i < people.length; i++){
    if(people[i].age >= 18){
        adults.push(people[i])
    }
}

console.log(adults)

// С помощью filter

const adultsFil = people.filter(person => person.age >= 18)

console.log(adultsFil)


// Reduce
// он служит для того, чтобы мы получили какое-то финальное значение, совершив итерацию по какому-то массиву

// Без метода reduce
let amount = 0
for(let i=0; i < people.length; i++){
    amount+=people[i].budget
}

console.log(amount)

// С помощью reduce
const amountRed = people.reduce((total, person) => {
    return total + person.budget
}, 0)
// total - изначально равен у нас нулю. И на каждой итерации мы меняем total на новое значение

console.log(amountRed)


// Find
// метод Find - служит для того, чтобы найти по условию нужный нам элемент

const igor = people.find(person => person.name === 'Игорь')
console.log(igor)


// FindIndex
// Похожим образом работает и findindex, но на выходе мы получаем индекс
const igorIndex = people.findIndex(person => person.name === 'Игорь')
console.log(igorIndex)


// Работа со всеми этими методами. 

// Эта запись называется chain(цепь вызовов)
const newPeopleArr = people
    .filter(person => person.budget > 3000)
    .map(person => {
        return {
            info: `${person.name} is ${person.age} years old`,
            budget: person.budget
        }
    })
    .reduce((total, person) => total + person.budget, 0)

console.log(newPeopleArr)



/* 
Конспект 
Отличия forEach vs Map: 
1) 
    Метод forEach() выполняет предоставленную функцию один раз для каждого элемента массива  
    Метод map() создает новый массив с результатами вызова предоставленной функции для каждого элемента в массиве, который вызывается 
     
2) 
    Метод forEach() при return возвращает undefined
    Метод map() выделяет память и создает новый массив, который в последующем можно сохранить в переменную
3) 
     Метод forEach() нельзя связывать с другими методами.  Например  forEach().reduce(...)... вернет ошибку
     Метод map() можно связывать с другими методами.  Например  map().reduce(...)...  можно использовать
4) 
     Метод forEach()  изменит текущий массив
     Метод map()  вернет новый массив с преобразованными элементами и тем же количеством данных
5)
     Во многих случаях метод forEach()  медленнее метода map()

*/ 
