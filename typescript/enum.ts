// enum и  его типы

enum EnumRoles {
    ADMIN = 0, GUEST = 1, USER =3
}

interface IUser {
    role: EnumRoles
    color: EnumColors
}

const user: IUser = {
    role: EnumRoles.ADMIN,
    color: EnumColors.pink
}

const enum EnumColors {
    black, pink, red
}

console.log(EnumRoles[EnumRoles.ADMIN])