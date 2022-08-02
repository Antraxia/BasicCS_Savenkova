// Подсчитать сумму цифр в числе

int N=1234;
int k=0;
int sum=0;


while (N!=0)
{
    
    
    sum=sum+N%10;
    N/=10;
    k++;
}

System.Console.WriteLine(sum);
