#include <iostream>

using namespace std;

int main() {
    double weight;
    double height;  

    cout << "Введите ваш вес (в килограммах): ";
    cin >> weight;

    cout << "Введите ваш рост (в сантиметрах): ";
    cin >> height;

    double heightInMeters = height / 100.0;

    double indexmassbody = weight / (heightInMeters * heightInMeters);

    cout << "Ваш индекс массы тела (ИМТ) составляет: " << indexmassbody << endl;

    return 0;
}