#include <iostream>
using namespace std;

double average(int a, int b);
double average(double a, double b);

int main()
{
    int int_a, int_b;
    double double_a, double_b;
    int in;

    cout << "1 για ακέραιους, 2 για πραγματικούς: ";
    cin >> in;
    if (in==1)
    {
        cout << "Δώσε 2 ακέραιους: ";
        cin >> int_a >> int_b;
        cout << average(int_a, int_b);
    }
    else if (in==2)
    {
        cout << "Δώσε 2 πραγματικούς: ";
        cin >> double_a >> double_b;
        cout << average(double_a, double_b);
    }
    else
    {
        cout << "Kopane!";
    }
}

double average(int a, int b)
{
    return (a+b)/2.0;
}
double average( double a, double b)
{
    return (a+b)/2.0;
}