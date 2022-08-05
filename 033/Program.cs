// Задать массив из 8 элементов, заполненных нулями и единицами их на экран

int N=8;
int[] a=new int[N];
Random random=new Random();
for (int i=0;i<a.Length;i++)

    a[i]=random.Next(0,2);

    for(int i=0;i<a.Length;i++)
    System.Console.WriteLine($"{a[i]} ");