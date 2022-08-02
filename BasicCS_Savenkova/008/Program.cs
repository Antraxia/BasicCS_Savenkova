// вывести на экран числа от -N до N

int N,M;
 System.Console.WriteLine("Введите число: ");
 string a=Console.ReadLine();
 N=Convert.ToInt32(a);
 M=-N;

 while (M<=N);
 
 {
    System.Console.Write($"{M} ");
    M++;
 }
