#include <iostream>
using namespace std;

class dog
{
    public:
        void init(int in_mood)
        {
            mood=in_mood;
        }
        void bark()
        {
            cout << "Woof" << endl;
        }
        void report_mood()
        {
            if (mood>10)
            {
                cout << "I'm cool";
            }
            else
            {
                cout << "I'm angry";
            }
        }
    private:
        int mood;
};

int main()
{
    dog Piko;
    Piko.init(6);
    
    cout << "Hello Piko, how are you today?" << endl;
    Piko.report_mood();
    cout << endl; 
    cout << "Bark for me twice Piko" << endl;
    Piko.bark();
    Piko.bark();
}