// Определить, присутствует ли в заданном массиве, некоторое число

int N=12;
int[] a=new int[N];
Random random=new Random();
for (int i=0;i<a.Length;i++)
   {
     a[i]=random.Next(-9,10);
   }
   int number=400;
   a[2]=number;
//Алгоритм линейного поиска
   int j=0;
   while (j<a.Length && a[j]!=number) j++;
   if(j==a.Length) System.Console.WriteLine("No");
   else System.Console.WriteLine("yes");

for(int i=0;i<a.Length;i++)
System.Console.Write($"{a[i],4}");
System.Console.WriteLine();
