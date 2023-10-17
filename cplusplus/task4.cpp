#include <iostream>
#include <cmath>

int main() {
    double weight;
    double height;  

    std::cout << "Введите ваш вес (в килограммах): ";
    std::cin >> weight;

    std::cout << "Введите ваш рост (в сантиметрах): ";
    std::cin >> height;

    double heightInMeters = height / 100.0;

    double indexmassbody = weight / (heightInMeters * heightInMeters);

    std::cout << "Ваш индекс массы тела (ИМТ) составляет: " << indexmassbody << std::endl;

    return 0;
}