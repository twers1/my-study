let array:string[]

// let array2:Array<string> 
array = ['1', '2', '3']


const numbers:ReadonlyArray<number> = [0,1,2,3] // мы не сможем изменить массив, так как у нас метод readonly
number[0]

// Кортежи - это когда мы знаем количество наших элементов
type TypeArray = [number, string, null] // создаем кортеж 

const newArray: TypeArray = [1,'2',null]
