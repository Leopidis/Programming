#include <iostream>
#include <vector>
#include <string>

using namespace std;

void recognizeExpression(const string& expression) {
    int xCount = 0;
    int yCount = 0;
    vector<string> steps;

    for (char character : expression) {
        if (character == 'x') {
            xCount++;
        } else {
            yCount++;
            if (yCount > xCount) {
                steps.push_back("Σφάλμα: Ο χαρακτήρας 'y' δεν μπορεί να προηγείται του χαρακτήρα 'x'");
                break;
            }
        }
        steps.push_back("X: " + to_string(xCount) + ", Y: " + to_string(yCount));
    }

    if (xCount == yCount) {
        steps.push_back("Αποδεκτή έκφραση");
    } else {
        steps.push_back("Σφάλμα: Το πλήθος των 'x' δεν ισούται με το πλήθος των 'y'");
        steps.push_back("X: " + to_string(xCount) + ", Y: " + to_string(yCount));
    }

    for (const string& step : steps) {
        cout << step << endl;
    }
}

int main() {
    string expressionToRecognize;
    cout << "Εισάγετε μία έκφραση: ";
    cin >> expressionToRecognize;

    recognizeExpression(expressionToRecognize);

    return 0;
}
