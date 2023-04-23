// Расширенные типы
// extends - расширяет возможности типа, интерфейса и прочее. А также он проверяет условие
type TypeIsNumber<T> = T extends number ? 'yes' : 'no'

type Type1 = TypeIsNumber<number>
type Type2 = TypeIsNumber<string>

// если навести курсором на дженерик, то можно узнать yes или no ответ

type TypeBrand = 'bmw' | 'mers' | 'audi'
type TypePrice = '2241' | '1313' | '14142'

type TypeCar = `${TypeBrand} ${TypePrice}`

const car1: TypeCar = 'bmw 2241'