// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] arr; 
arr=Create2DArray(3,4);
int sum=0;
int middle=0;
Print (arr);
Solve (arr);


int[,] Create2DArray (int n,int m)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for (int i=0;i<a.GetLength(0);i++) 
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(0,100);
    return a;
}


void Solve (int[,] a)
{
      for (int j=0;j<a.GetLength(1);j++)
      {
        for(int i=0;i<a.GetLength(0);i++)
           {
            sum=sum+a[i,j]; 
               middle=sum/a.GetLength(0);               
           }
      
        System.Console.WriteLine($"{middle}"); 

      }                       
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