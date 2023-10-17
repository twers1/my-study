#include <iostream>

int main() {
    double radius;
    const double pi = 3.14;

    std::cout << "Введите радиус круга: ";
    std::cin >> radius;

    double area = pi * (radius*radius);

    std::cout << "Площадь круга с радиусом " << radius << " равна: " << area << std::endl;

    return 0; 
}