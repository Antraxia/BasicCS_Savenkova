//  Написать подпрограмму, поиска элемента в двумерном массиве, подпрограмма возвращает позицию числа. Если элемент отсутствует, подпрограмма возвращает -1.

int[,] arr; 
arr=Create2DArray(3,4);
arr[2,3]=5;
Print (arr);
System.Console.WriteLine(Find(arr,5,out i,out j));

bool Find(int[,] a,int number,out int i,out int j)
{
    for(i=0;i<a.GetLength(0);i++)
    {
        for(j=0;j<a.GetLength(1);j++)
        {
            if(a[i,j]==number)
            {
                return true;
            }
        }
        
    }
    i=-1;
    j=-1;
    return false;

}
int[,] Create2DArray (int n,int m)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for (int i=0;a<a.Length;i++) 
        for(int j=0;j<a.Length;j++)
            a[i,j]=random.Next(0,100);
    return a;
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