// Написать программу копирования массива
int N=12;
int[] a=new int[N];
int[] b=new int[N];

Random random=new Random();
for (int i=0;i<a.Length;i++)
   {
     a[i]=random.Next(1,10);
   }

for (int i=0;i<a.Length;i++)
{
    b[i]=a[i];
} 


for (int i=0;i<a.Length;i++)
System.Console.Write($"{a[i]} ");
System.Console.WriteLine();
for (int i=0;i<a.Length;i++)
System.Console.Write($"{b[i]} ");


