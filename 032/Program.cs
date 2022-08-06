// Задать массив из 8 целых элементов и вывести их на экран

/* int[] a=new int[8];
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

for (int i=0;i<a.Length;i++)  //Length обращение к длине массива
     a[i]=1;

     for (int i=0;i<a.Length;i++)
     System.Console.Write(a[i]);

*/


//Инициализация переменных 

int[] a;

// Ввод данных
Init(out a,8,0,100);

// Обработка данных


// Вывод результатов

Print(a);





void Init(out int[] a,int Length,int min, int max) // можно задать в условии константы напрмер void Init(out int[] a,int Length=10,int min=0, int max=100), тогда  при вызове достаточно указать Init(out a); если написать Init(out a,max:100) тогда при константах в функции изменится максимум конкретно при данном вызове 
{
     a=new int[Length];
     Random random=new Random(); //псевдослучайные числа

for (int i=0;i<a.Length;i++) // Length обращение к длине массива
     a[i]=random.Next(min,max+1);
}


void Print(int[] a)
{
    for (int i=0;i<a.Length;i++)
    System.Console.WriteLine($"{a[i],4}");  
}
