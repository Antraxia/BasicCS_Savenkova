//Создать подпрограмму Create2DArray(m,n), которая возвращает двумерный массив следующим правилом: Aij = i+j, где i и j - индексы элементов массива, а m и n - размеры массива

int[,] arr;
int m=Convert.ToInt32(Console.ReadLine());
int n=Convert.ToInt32(Console.ReadLine());
arr=Create2DArray(m,n);

Print(arr);
System.Console.WriteLine();

int[,] Create2DArray(int m,int n)
{
    int[,] a=new int[m,n];
    Random random=new Random();
    for (int i=0;i<a.GetLength(0);i++) 
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=i+j;
    return a;
}
void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4} ");
        System.Console.WriteLine();
    }
}