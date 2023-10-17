#include <iostream>

int main() {
    double exchangeRate;
    double amountRubles;  

    std::cout << "Введите текущий курс доллара к рублю: ";
    std::cin >> exchangeRate;

    std::cout << "Введите количество рублей для конвертации: ";
    std::cin >> amountRubles;

    double amountDollars = amountRubles / exchangeRate;

    std::cout << "Сумма в долларах: " << amountDollars << std::endl;

    return 0; 
}