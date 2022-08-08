// С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

Console.ReadLine();
string s=Console.ReadLine();
string[] ss=s.Split(' ',System.StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss,int.Parse);
int c;
CountNumbers(a,out c);
Print(a);



void CountNumbers(int[] a,out int c)
{
    c=0;
    for(int i=0;i<a.Length;i++)
{
    if(a[i]>0) c++;
}
}

void Print(int[] a)
{
    System.Console.WriteLine(c);
}