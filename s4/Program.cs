// Подсчитать количество цифр среди вводимых с клавиатуры символов
string s=Console.ReadLine();
int sum=0;
for(int i=0;i<s.Length;i++)
    //if (s[i]>='0' && s[i]<='9')
    if (char.IsDigit(s[i]))
        sum=sum+1;//(int)(char.GetNumericValue(s[i])); //Преобразуем s[i] в число с помощью GetNumericValue, но она приобретает тип double, чтобы преобразовать его в тип int, используется данный способ
System.Console.WriteLine(sum);        