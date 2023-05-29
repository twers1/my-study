// weakSet - значения могут быть только объекты, и он схож с weakMap

const users = [
    {name: 'Elena'},
    {name: 'Alex'},
    {name: 'John'},
]

const visits = new WeakSet()

visits.add(users[0]).add(users[1])

users.splice(1,1) // удаляет значение 

console.log(visits.has(users[0]))
console.log(visits.has(users[1]))