/*char c='a';//2^16=65536

ConsoleKeyInfo ck;
do
{
    ck=Console.ReadKey();
    System.Console.WriteLine((int)ck.KeyChar); //выводит код символа
    System.Console.WriteLine("IsDigit:"+char.IsDigit(ck.KeyChar));
    System.Console.WriteLine("IsControl:"+char.IsControl(ck.KeyChar));
    System.Console.WriteLine("IsLetter:"+char.IsLetter(ck.KeyChar));
}
while(ck.Key!=ConsoleKey.Escape);

System.Console.WriteLine('a'.ToString()+'b');// 'a'+'b' сложит и выведет сумму символов, чтобы вывелась строка ab ----> 'a'.ToString()+'b'
if (c>='A' && c<='Z') System.Console.WriteLine("Latin");
if (c>='a' && c<='z') System.Console.WriteLine("Latin");

*/

/*
string str="Hello";
System.Console.WriteLine(str[0].ToString()+str[1]);
for(int i=0;i<str.Length;i++)
{
    if(str[i]>='A' && str[i]<='Z')
        System.Console.WriteLine(str[i]);
}
   
// immutable - неизменяемые
// str[0]='h';
char[] cc=str.ToArray();
cc[0]='h';
str=new string(cc);
*/

/*
string str="Hello";
str=str.Remove(0,1); //удаляет символы из строки
System.Console.WriteLine(str);
*/

System.Diagnostics.Stopwatch stopwatch=new System.Diagnostics.Stopwatch();
stopwatch.Start();
string s="";
for(int i=0;i<30000;i++)
    s=s+"abcdefghijklmnopqrstvwxyz";
stopwatch.Stop();
System.Console.WriteLine(stopwatch.ElapsedMilliseconds);
stopwatch.Reset();
stopwatch.Start();
System.Text.StringBuilder sb=new System.Text.StringBuilder("");//StringBuilder не создает каждый раз новую строку, а прибавляет к уже имеющейся, работает быстрее и тратит меньше памяти в стеке
for (int i=0;i<30000;i++)
    sb.Append("abcdefghijklmnopqrstvwxyz");
    stopwatch.Stop();
System.Console.WriteLine(stopwatch.ElapsedMilliseconds);

s.Concat("123"); //s=s+"123"
s=s.Replace('1','2'); //заменяет все символы 1 в строке на символы 2
s.Contains('1'); //Проверяет входит ли указанный символ в строку и возвращает True/False
s.Insert(1,"2");//Вставляет 2 в строку после указанного индекса знака(1)
System.Console.WriteLine(s.IndexOf("0")); //выводит на экран знак под указанным индексом

//сравнение строк, строки сравниваются только на == и !=
string s1="123";
if(s1==s);
if(s.CompareTo(s1)<0); // сравнивает по длине строки
if (String.Compare(s,s1,1,2)>0);

Random random1=new Random();
Random random2=new Random();
System.Console.WriteLine(random1==random2);
 

