// Декораторы
// - это функция, которая накладывает функционал(разные свойства, методы, аргументы) сверху

function LogClass(constructor: Function){
    console.log(constructor.name)
}

function LogMethd(target: Object,key: string, descriptor: PropertyDescriptor){
    console.log(key)
}

@LogClass
class Plane { 
    constructor(id: number) {

    }

    @LogMethd 
    getId() {
        return this.is
    }
}