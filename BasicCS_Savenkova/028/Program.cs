// Определить количество цифр в числе. Сделать подпрограмму.

int N=1234;
int k=0;

while (N!=0)
{
    //k=k+1
    k++;
    //N=N/10;
    N/=10;
}

System.Console.WriteLine(k);


/* Подпрограмма

System.Console.WriteLine(CountDigits(1223));


int CountDigits(int N)
{
    if (N==0) return 1;
    int k=0;
    while (N!=0)
    {
        k++;
        N/=10;
    }
    rerurn k;
}
*/