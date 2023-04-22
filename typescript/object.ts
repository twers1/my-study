type TypeUser = {
    name: string,
    age: number
}

type TypeAddress = {
    city: string,
    country: string
}

const user:TypeUser = {
    name: "--",
    age: 1
}

const address:TypeAddress = {
    city: "--",
    country: "--"
}

// const common = {
//     ...user, ...address
// }

let common:TypeUser & TypeAddress = {
    ...user,
    ...address
}