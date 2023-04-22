// типизация функции правильно
type TypeChannelReturn = {
    name:string
}

function getChannel(name:string):TypeChannelReturn {
    return {
        name
    }
}

const getChannelName = (name:string):TypeChannelReturn => {
    return {
        name
    }
}

type TypeChannelFunction = (name:string) => TypeChannelReturn

const getChannelName: TypeChannelFunction = name => {
    return {name}
}

// rest параметры и типы
const getNumbers = (...numbers: number[]) => {
    return numbers
}

// Функциональные перегрузки

function getCar(name:string): string
function getCar(name:string, price:number):string 

function getCar(name:string, price?: number): string {
    return price ? `Название ${name}, Цена ${price} ` : `Название ${name}`
}

const car1 = getCar('bmw')
const car2 = getCar("bmw", 10000)
// const car3 = getCar("bmw", 1000, 100) так не будет работать, так как это перегрузка параметров
