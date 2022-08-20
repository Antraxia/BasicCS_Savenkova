// 1.Вывести на экран кодировку символов по ASCII(с 32 до 122)

string s;
for(int i=32;i<=122;i++)
{
    System.Console.Write((char)i);
}

//2.Вывести на экран символы от A до Z как показано ниже:
//A
//BB
//CCC

for(int i=65;i<=90;i++)
{
    for(int j=0;j<i-64;j++)
        System.Console.Write((char)i);

    System.Console.WriteLine();
}