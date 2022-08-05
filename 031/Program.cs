// Показать кубы чисел, заканчивающихся на четную цифру

System.Console.WriteLine("Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());

for (int i=1;i<=a;i++)
{
    double b=Math.Pow(i, 3);
    if(b%10%2==0)
    {
        System.Console.Write($"{b} ");
    }
}
