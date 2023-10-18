#include <iostream>

using namespace std;

int main() {
    double radius;
    const double pi = 3.14;

    cout << "Введите радиус круга: ";
    cin >> radius;

    double area = pi * (radius*radius);

    cout << "Площадь круга с радиусом " << radius << " равна: " << area << endl;

    return 0; 
}