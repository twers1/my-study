#include <iostream>

using namespace std;

int main() {
    int red, green, blue;

    cout << "Введите компоненту красного цвета (от 0 до 255): ";
    cin >> red;

    cout << "Введите компоненту зеленого цвета (от 0 до 255): ";
    cin >> green;

    cout << "Введите компоненту синего цвета (от 0 до 255): ";
    cin >> blue;

    int color = (red << 16) | (green << 8) | blue;

    cout << "Цвет в числовом формате: " << color << endl;

    return 0;
}