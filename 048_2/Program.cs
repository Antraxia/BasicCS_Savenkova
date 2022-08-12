// Показать двумерный массив размером m×n заполненный целыми случайными числами

int[,] arr; // обьявляем массив
arr=Create2DArray(3,4);
int[,] arr2=Create2DArray(4,6);
Print (arr);

//1 способ вернуть массив
int[,] Create2DArray (int n,int m)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for (int i=0;a<a.Length;i++) // перебираем строки
        for(int j=0;j<a.Length;j++)// перебираем столбцы
            a[i,j]=random.Next(0,100);
    return a;
}

// 2 способ вернуть массив
int[,] Create2DArray (int n,int m, out int[,] a)
{
   a=new int[n,m];
    Random random=new Random();
    for (int i=0;a<a.Length;i++) // перебираем строки
        for(int j=0;j<a.Length;j++)// перебираем столбцы
            a[i,j]=random.Next(0,100);
}    

void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j]} ");
        System.Console.WriteLine();
    }
}