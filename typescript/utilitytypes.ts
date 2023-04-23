// Утилиты типов

interface ICar {
    id: number
    name: string
    price: number
    yearBuilt: number
}

interface ICarCreate extends Omit<ICar, 'id'> {

}
// Omit - исключает поле, которое не нужно

interface ICarId extends Pick<ICar, 'id'> {

}
// Pick - вытаскивает поле нужное

interface IOptionalCar extends Partial<ICar> {}

// Partial - делает поля необязательными

interface IReadonlyCar extends Readonly<ICar> {

}
// Readonly - делает поля только для прочтения

type TypeCarRecord = Record<'name' | 'price', string | number>

const car :TypeCarRecord = {
    
}

// Record динамически определить поле в объектном типе

interface IRequiredCar extends Required<ICar> {

}

// Required - делает все поля обязательными

type TypeGetName = () => string
type Return = ReturnType<TypeGetName>


type Any = Extract<'medved' | 'lisa' | 'volk' | 'volk'>

// Extract - возвращает только одинаковые параметры

type Any2 = Exclude<'medved' | 'lisa' | 'volk' | 'volk'>

// Exclude - исключает по первому параметру, то есть, первый параметр он оставляет, а остальные убирает

type NotNull = NonNullable<string | number | null | underfined>

// NonNullable - позволяет удалить null и underfined