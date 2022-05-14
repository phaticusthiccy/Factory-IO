#include <iostream>
#include <sstream>
#include <string>
#include <cstdlib>
#include <cmath>

using namespace std;

// Headers
string toString (double);
int toInt (string);
double toDouble (string);
bool reset();

int main() {
    bool boolin0, boolin1, boolout0, boolout1, boolout2, boolout3, boolout4, boolout14, boolout15;
    
    cin >> boolin0;
    cin >> boolin1;
    cin >> boolout0;
    cin >> boolout1;
    cin >> boolout2;
    cin >> boolout3;
    cin >> boolout4;
    cin >> boolout14;
    cin >> boolout15;
    if (boolin1) {
        cout << "Stopped" << endl;
        do {
            reset();
        } while (boolin1);
    } else {
        boolin0 = true;
        cout << "Running" << endl;
        while (true) {
            cin >> boolin1;
            while (!boolin1) {
                cout << "Stopped" << endl;
                do {
                    reset();
                } while (boolin1);
            }
        }
    }
    return 0;
}

bool reset() {
    reset();
    
    return ;
}

string toString (double value) { //int also
    stringstream temp;
    temp << value;
    return temp.str();
}

int toInt (string text) {
    return atoi(text.c_str());
}

double toDouble (string text) {
    return atof(text.c_str());
}
