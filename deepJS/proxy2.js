// Proxy. Examples

// Wrapper
const withDefaultValue = (target, defaultValue = 0) => {
    // второй параментр - handlers
    return new Proxy(target, {
        get: (obj, prop) => (prop in obj) ? obj[prop] : defaultValue
    })
}

const position = withDefaultValue({
    x: 24,
    y: 42
}, 0)

console.log(position)

// Hidden properties 
const withHiddenProps = (target, prefix = '_') => {
    return new Proxy(target, {
        has: (obj, prop) => (prop in obj) && (!prop.startsWith(prefix)),
        // ownKeys - это свойство, которое говорит какие ключи есть в объекте
        ownKeys: obj => Reflect.ownKeys(obj)
            .filter(p => !p.startsWith(prefix)),
        // reflect - это некоторый объект, который позволяет более детально работать с объектами
        // receiver - это и есть тот самый proxy, который мы возвращаем(тот самый объект, с которым мы работаем)
        get: (obj, prop, receiver) => (prop in receiver) ? obj[prop] : void 0
        // void 0 = underfined
    })
}

const data = withHiddenProps({
    name: 'Xddes',
    age: 40,
    _uid: '123'
})


// Optimizator 

const userData = [
    {id: 1, name: 'dadada', job: 'Fullstack', age: 25},
    {id: 2, name: 'Elena', job:'Student', age: 30},
    {id: 3, name: 'Victor', job: 'Backend', age: 21},
    {id: 4, name: 'Vasya', job: 'Frontend', age: 22}
]

const index = {}
userData.forEach(i => index[i.id] = i)

const IndexedArray = new Proxy(Array, {
    construct(target, [args]){
        const indexx = {}
        args.forEach(item => (indexx[item.id] = item))

        return new Proxy(new target(...args), {
            get(arr, prop){
                switch(prop){
                    case 'push':
                        return item => {
                            indexx[item.id] = item
                            arr[prop].call(arr, item)
                        } 
                    case 'findById': return id => indexx[id]
                    default: return arr[prop]
                }
            }
        })
    }
})

const users = new IndexedArray([
    {id: 1, name: 'dadada', job: 'Fullstack', age: 25},
    {id: 2, name: 'Elena', job:'Student', age: 30},
    {id: 3, name: 'Victor', job: 'Backend', age: 21},
    {id: 4, name: 'Vasya', job: 'Frontend', age: 22}
])