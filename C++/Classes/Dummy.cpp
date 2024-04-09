#include <iostream>
using namespace std;

class dummy
{
    public:
        dummy();
        dummy(int in_x);
        ~dummy(); 
        void set_x(int in_x);
        int get_x() const;    
    private:
        int x;
};

int main()
{
    dummy ob1(10), ob2;
}

dummy::dummy()
{
    x=0;
}

dummy::dummy(int in_x)
{
    x=in_x;
}

void dummy::set_x(int in_x)
{
    x=in_x;
}

int dummy::get_x() const
{
    return x;
}

dummy::~dummy()
{
    cout << "Destructing with x=" << x << endl;
}