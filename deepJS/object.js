// Работа с объектами. Object.create. Что такое getters, setters

// первый параметр - является пропотитом данного объекта
// второй параметр - мы можем указать поля для объета
const person = Object.create(
    {
        calculateAge(){
            console.log('Age:', new Date().getFullYear()- this.birthYear)
        }
    },
    {
    name: {
        value: 'Sima',
        writable: true, // данный парамент нужен для того, чтобы мы манипулировали данным параметром(к примеру, могли бы его изменить)
        configurable: true, // мы можем  удалять какой-либо ключ из объекта
        enumerable: true //  с помощью enumerable (является ли свойство видимым при перечислениях)
    },
    birthYear: {
        value: 2005
        // writable, configurable, enumerable - по умолчанию стоят как false
    },
    age: {
        // тут мы используем getеты и setеры
        get() {
            return new Date().getFullYear()- this.birthYear
        },
        set(value) {
            document.body.style.background = 'red'
            this.birthYear = 2023 - value
        }
    }
})
// для того, чтобы вернуть дефолтные поведения для данных ключей - мы можем им выдать разные параметры

// person.name = 'Maxim'

for(let key in person) {
    if(person.hasOwnProperty(key))  {
        console.log("Key", key, person[key])
    
    }
}
    
console.log(person)

/*
Конспект: 
Чтобы итерировать по собственным свойстам объекта, отсеивая свойства прототипа(-ов), 
не обязательно проверять внутри цикла, является ли свойство собственным, 
а можно воспользоваться встроенным методом Object.keys(), 
который возвращает итерируемый объект (а именно - массив) из собственных перичесляемых свойств объекта.  Например:
for(let i of Object.keys(person)) {
	console.log(i, person[i]); 
}

В случае если значения дескриптора writable равняется false, 
а configurable - true, значение ключа возможно не только удалять, 
но также и переназначать - правда, с помощью оператора "=" это действительно сделать невозможно,
но зато возможно с помощью метода: Object.defineProperty().
Например:
    Object.defineProperty(person, 'name', 
    {value: 'Maxim'});
или 
     Object.defineProperty(person, 'name',
      {value: 'Maxim', writable: true, configurable: false});
    (результат этих двух строчек кода будет один и тот же, так как если значения дескрипторов не переназначать, сохраняются их прежние значения, а не дефолтные).
*/