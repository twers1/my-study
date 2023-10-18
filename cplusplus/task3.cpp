#include <iostream>

using namespace std;

int main() {
    double exchangeRate;
    double amountRubles;  

    cout << "Введите текущий курс доллара к рублю: ";
    cin >> exchangeRate;

    cout << "Введите количество рублей для конвертации: ";
    cin >> amountRubles;

    double amountDollars = amountRubles / exchangeRate;

    cout << "Сумма в долларах: " << amountDollars << endl;

    return 0; 
}