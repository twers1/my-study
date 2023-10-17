#include <iostream>

using namespace std;

int main() {
    double meters, miles, kilometers;

    cout << "Введите длину в метрах: ";
    cin >> meters;

    kilometers = meters / 1000.0;

    cout << "Длина в километрах: " << kilometers << " км" << endl;

    cout << "Введите длину в милях: ";
    cin >> miles;

    kilometers = miles * 1.6;

    cout << "Длина в километрах: " << kilometers << " км" << endl;

    return 0;
}