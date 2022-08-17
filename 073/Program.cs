// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности 0 и 1 - 4

int num1;
num1=int.Parse(Console.ReadLine());
int num2;
num2=int.Parse(Console.ReadLine());

int F(int i)
{
    if(i<1) return num1;
    if(i==1) return num2;
    return F(i-1)+F(i-2);
}
for(int i=0; i<10; i++)
System.Console.WriteLine(F(i));