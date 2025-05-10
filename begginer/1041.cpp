#include <iostream>

using namespace std;

string position(double x, double y) {
    string position = "Origem";

    if(x != 0 && y == 0) {
        position = "Eixo X";
        return position;
    }

    if(x == 0 && y != 0) {
        position = "Eixo Y";
        return position;
    }

    if(x > 0 && y > 0) {
        position = "Q1";
        return position;
    }

    if(x > 0 && y < 0) {
        position = "Q4";
        return position;
    }

    if(x < 0 && y > 0) {
        position = "Q2";
        return position;
    }

    if(x < 0 && y < 0) {
        position = "Q3";
        return position;
    }

    return position;
}

int main() {
    double x, y;

    cin >> x >> y;

    string pos = position(x, y);

    cout << pos << endl;

    return 0;
}
