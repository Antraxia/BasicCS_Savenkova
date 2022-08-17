// Написать программу вывода чисмел от 1 до N без использования циклов и оператора goto

void Loop(int i,int N)
{
    System.Console.WriteLine(i);
    if (i<N) Loop(i+1,N);
}

Loop (1,10);
