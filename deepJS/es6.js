// const animal = {
//     name: 'Animal',
//     age: 5,
//     hasTail: true
// }

class Animal {
    static type = "ANIMAL"

    constructor(name, age, hasTail) {
        this.name = name;
        this.age = age;
        this.hasTail = hasTail;
    }

    voice(){
        console.log('I am Animal!')
    }
}

// const animal = new Animal('Animal', 5, true);

class Cat  extends Animal{
    static type = "CAT"

    constructor(color){
        super('Cat', 5, true);
        this.color = color;
    }

    voice(){
        super.voice()
        console.log('Мяяяу')
    }

    get ageInfo(){
        return this.age * 7
    }

    set ageInfo(newAge){
        this.age = newAge
    }
}

const cat = new Cat('Cat', 5, true, black);