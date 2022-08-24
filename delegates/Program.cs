// Подсчитать количество маленьких латинских цифр в строке
// Подсчитать количетво больших латинскиз цифр в строке
//Подсчитать количество цифр в строке


// Вариант с делегатами

namespace Zayarniy
{
    class Program
    {
        delegate bool IsChar(char c); // описали шаблон делегата проверяющий на наличие нужного знака по этому он логического типа bool

        static bool IsLatinSmall(char c)
        {
            if(c>='a' && c<='z') return true; else return false;
        }

        static bool IsLatinBig(char c)
        {
            if(c>='A' && c<='Z') return true; else return false;
        }

        static int CountChars(string s,IsChar isChar)
        {
            int k=0;
            for (int i=0;i<s.Length;i++)
                if (isChar(s[i])) k++;
            return k;
        }
        static void Main()
        {
            IsChar isChar=new IsChar(IsLatinBig);
            string s="It`s string contains BIG LATIN CHARS, small latin chars and digits (1234567890)";
            System.Console.WriteLine(CountChars(s, delegate(char c) //анонимный делегат
            {
                return (c>='A' && c<='Z');
            }));
        }
    }
}



/* Вариант без делегатов
int CountCharSmall(string s)
{
    int k=0;
    for(int i=0;i<s.Length;i++)
       if (s[i]>='a' && s[i]<='z') k++;
    return k;       
}

int CountCharBig(string s)
{
    int k=0;
    for(int i=0;i<s.Length;i++)
       if (s[i]>='A' && s[i]<='Z') k++;
    return k;       
}

int CountCharDigit(string s)
{
    int k=0;
    for(int i=0;i<s.Length;i++)
        if (char.IsDigit(s[i])) k++;
    return k;
}


string s="It`s string contains BIG LATIN CHARS, small latin chars and digits (1234567890)";
System.Console.WriteLine(CountCharDigit(s));
System.Console.WriteLine(CountCharBig(s));
System.Console.WriteLine(CountCharSmall(s));


void CountCharAll(string s,out int k1,out int k2,out int k3)
{
    k1=0;
    k2=0;
    k3=0;
    for (int i=0;i<s.Length;i++)
    {
        if(s[i]>='a'&& s[i]<='z') k1++;
        if(s[i]>='A'&& s[i]<='Z') k2++;
        if(char.IsDigit(s[i])) k3++;
    }
}
*/