// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int N=8;
int[] a=new int[N];
Random random=new Random();    // псевдослучайные числа
for (int i=0;i<a.Length;i++)   //Length обращение к длине массива
     a[i]=random.Next(0,2);

 for(int i=0;i<a.Length;i++)
 System.Console.WriteLine($"{a[i] }"); 
