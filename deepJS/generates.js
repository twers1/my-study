// Генераторы. Symbol iterator, for of 
// Генераторы - это функции, которые могут последовательно нам выдавать результат ее работы


// * - обозначает то, что это генератор
// Пример 1 
function* strGenerator() {
    // ключевое слово yield - порционно выдает нам определенный результат, который мы хотим выдать наружу
    yield 'H';
    yield 'e';
    yield 'l';
    yield 'l';
    yield 'o';
}

const str = strGenerator()
// метод next() возвращает следующий объект генератора - в консоли браузера можно проверить

// Пример 2
function* numberGen(n = 10) {
    for(let i = 0; i <n; i++){
        yield i
    }
}

const num = numberGen(7)

// Пример 3
const iterator = {
    get(n = 10) {
        let i = 0;

        return {
            next() {
                if(i<n){
                    return {
                        value: i++,
                        done: false
                    }
                }
                return {value: undefined, done: true}
            }
        }
    }
}

// Пример 4
// цикл for of работает с типом данных symbol
for(let k of 'Hello'){
    console.log(k)
}

for(let k of [1,1,2,3,5,8,13]){
    console.log(k)
}

const exampleSymbol = {
    [Symbol.iterator](n = 10) {
        let i = 0;

        return {
            next() {
                if(i<n){
                    return {
                        value: i++,
                        done: false
                    }
                }
                return {value: undefined, done: true}
            }
        }
    }
}

function iter(n =10){
    for(let i=0; i<n;i++){
        yield i
    }
}

for(let k of iterator){
    console.log(k)
}

for(let k of iter(6)){
    console.log(k)
}