//Написать подпрограмму, которая в матрице чисел находит сумму элементов главной диагонали

int[,] arr;
arr=Create2DArray(3,3);
Print(arr);

int sumMain(int[,] arr)
{
int sum=0;
for(int i=0;i<arr.GetLength(0);i++)
    sum=sum+arr[i,i];
    return sum;
}
    System.Console.WriteLine($"сумма элементов главной диагонали - {sumMain(arr)}");

int sum2=0;
for(int i=0;i<arr.GetLength(0);i++)
    sum2=sum2+arr[i,(arr.GetLength(0)-i-1)];
    System.Console.WriteLine($"сумма элементов побочной диагонали - {sum2}");
    