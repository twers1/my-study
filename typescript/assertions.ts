// Утверждения Assertions

const inputElement = document.querySelector('input')
const value1 = (inputElement as HTMLInputElement).value
const value2 = (<HTMLInputElement>inputElement).value

const getLength = (test: string | null) => {
    return text!.length
}

getLength('werger')
getLength(null)