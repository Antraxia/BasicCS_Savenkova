//Вывести на экран кубы чисел от 1 до N

System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());




for (int i=1;i<=N;i++)
{
       double a=Math.Pow(i, 3);
       System.Console.Write($"{a} ");
}

System.Console.WriteLine();