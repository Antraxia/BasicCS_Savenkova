// Generic - обобщения, шаблоны

class Program   // чтобы несколько методов с одним названием работали для разных типов данных их нужно поместить в класс
{
    static void Swap(ref int a,ref int b)
    {
        int t=a;
        a=b;
        b=t;
    }

    static void Swap(ref double a, ref double b)
    {
        double t=a;
        a=b;
        b=t;
    }

    static void Init(out int[] a)
    {
        a=new int[10];
        for(int i=0;i<10;i++)
        {
            a[i]=10;
        }
    }

    static void Main()
    {
       int[] a;
       int x=1,y=2;
       double e=2,t=4;
       Swap(ref x,ref y);
       Swap(ref e,ref t);
       Init(out a);
 
    }
}
