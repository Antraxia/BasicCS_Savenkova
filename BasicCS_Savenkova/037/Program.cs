// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int N=8;
int c=0;
int b=0;
int[] a=new int[N];
Random random=new Random();    
for (int i=0;i<a.Length;i++) 
{  
     a[i]=random.Next(100,999);
    

 if (a[i]%2 != 0)
 {
    b++;
 }
 else
 {
    c++;
 }
}

 for(int i=0;i<a.Length;i++)
 
 System.Console.Write($"{a[i]} "); 
 

 System.Console.WriteLine($"четных чисел {c} нечетных чисел {b}");