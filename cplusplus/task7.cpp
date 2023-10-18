#include <iostream>

using namespace std;

int main() {
    unsigned int color = 0x04F1A2u;

    unsigned int red = (color >> 16) & 0xFF;

    unsigned int green = (color >> 8) & 0xFF;

    unsigned int blue = color & 0xFF;

    cout << "Красная компонента: " << red << endl;
    cout << "Зеленая компонента: " << green << endl;
    cout << "Синяя компонента: " << blue << endl;

    return 0;
}