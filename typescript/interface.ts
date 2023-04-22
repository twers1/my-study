interface IUser extends IUserAge{
    name: string
    email: string
} 

const user:IUser = {
    email: '',
    name: ''
}

// разницы между типами и интерфейсами практически нет, но есть свои нюансы
type TypePerson = {
    age: number
}
type TypeUser = {
    name: string
    email: string
} & TypePerson

interface IUserAge {
    age: number
}

// интерфейсы - для масштабного использования

const users: IUser[] = [user, {

}]