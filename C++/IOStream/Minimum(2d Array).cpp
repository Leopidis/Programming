#include <iostream>

using namespace std;

int main()
{
    int grammes, sthles, min=32768;
    do
    {
        cin >> grammes >> sthles;       
    }
    while ((grammes<sthles?grammes:sthles)<=0);

    int A[grammes][sthles];

    for (int i=0; i<grammes; i++)
        for (int j=0; j<sthles; j++)
        { 
            cin >> A[i][j];            
            if (A[i][j]<min) min=A[i][j];
        }      
    cout << min;
    return 0;               
}          