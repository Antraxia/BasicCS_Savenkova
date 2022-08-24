// Определить являются ли введенные с клавиатуры символы правильной записью целого числа. Вычислить сумму цифр введенного числа

string number = Console.ReadLine();
int sum = 0;
for (int i = 0; i < number.Length; i++)
{
    if (char.IsDigit(number[i]))
    {
        sum+=number[i]-48;
    }
    else
    {
        if(i==0 && number[i]=='-')
        {
            continue;
        }
        else
        {
            System.Console.WriteLine("Это не целое число");
            return;
        }
    }
}
System.Console.WriteLine(sum); 
     