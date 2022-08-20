// с клавиатуры вводится строка - перевернуть ее
string s=Console.ReadLine();
// System.Console.WriteLine(new string(s.Reverse().ToArray())); или
for(int i=s.Length-1;i>=0;i--)
{
    System.Console.Write(s[i]);
}

//Даны две строки, можно ли из символов одной строки составить дргую строку

string s1=Console.ReadLine();
string s2=Console.ReadLine();
char[] cc1=s1.ToArray();
Array.Sort(cc1);
string ss1=new String(cc1);

char[] cc2=s2.ToArray();
Array.Sort(cc2);
string ss2=new String(cc1);
//System.Console.WriteLine(ss1);
//System.Console.WriteLine(ss2);
if (ss1==ss2) System.Console.WriteLine("yes");
else System.Console.WriteLine("No");

// Вводится строка. Преобразовать все латинские большие буквы в маленькие
// LATIN--->latin
string s=Console.ReadLine();
System.Console.WriteLine(s.ToLower());