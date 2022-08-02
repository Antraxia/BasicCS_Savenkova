// Задать массив из 8 целых элементов и вывести их на экран

/*int[] a=new int[8];
a[0]=1;
a[1]=2;
a[2]=3;
a[3]=4;
a[4]=5;
a[5]=6;
a[6]=7;
a[7]=8;
*/

/*
int N=8;
int[] a=new int[N];

for (int i=0;i<a.Length;i++)   //Length обращение к длине массива
     a[i]=1;

 for(int i=0;i<a.Length;i++)
 System.Console.Write(a[i]);  
 */  

int N=8;
int[] a=new int[N];
Random random=new Random();    // псевдослучайные числа
for (int i=0;i<a.Length;i++)   //Length обращение к длине массива
     a[i]=random.Next(0,100);

 for(int i=0;i<a.Length;i++)
 System.Console.Write($"{a[i],4}"); 