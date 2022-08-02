// Написать программу вычисления произведения чисел от 1 до N

System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int mult=1;
for (int i=1;i<=N;i++)
{
   mult=i*mult;
   
System.Console.Write($"{mult} "); 

}

