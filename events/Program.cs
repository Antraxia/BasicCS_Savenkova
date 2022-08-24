// See https://aka.ms/new-console-template for more information

namespace Zayarniy
{
    delegate void Flag(); // сигнатура void()
    class A 
    {
        public void IsFlagTrue()
        {
            System.Console.WriteLine("Flag is true");
        }

    }

    class B 
    {
        private int flage=0;
        public Flag FLAG;

        public void Work()
        {
            Random random=new Random();
            for(int i=0;i<2000;i++)
               {
                if (random.Next(1,1000)==500)
                {
                    flage=1;
                    FLAG();
                }
               }
        }
    }
    class Program
    {
        static void Main()
        {
            A a=new A();
            B b=new B();
            b.FLAG=new Flag(a.IsFlagTrue);
            b.Work();
        }
    }
}