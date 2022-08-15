// Написать программу, которая обменивает элементы первой строки и последней строки

int[,] arr; 
arr=Create2DArray(3,4);
Print (arr);
Solve (arr,0);
System.Console.WriteLine();
Print (arr);


int[,] Create2DArray (int n,int m)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for (int i=0;i<a.GetLength(0);i++) 
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(0,100);
    return a;
}


void Solve (int[,] a, int change)
{
         for (int i=0;i<a.GetLength(0);i++) 
               for(int j=0;j<a.GetLength(1);j++)
               {
                change=a[0,j];
                   a[0,j]=a[a.GetLength(0)-1,j];
                   a[a.GetLength(0)-1,j]=change; 
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