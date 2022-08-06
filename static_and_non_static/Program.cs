class Program // Класс - это некоторый шаблон будущего обьекта или некоторая библиотека\набор методов, которые мы можем из этого класса вызывать
{
    static void Main() // точка входа в программу
    {
        int[] a;
        MyLibrary.Init(out a,20);

        MyClass myClass=new MyClass();
        myClass.Init(10); // Этот Init не статический, в отличии от MyLibrary.Init и для него нужно сначала создать обьект типа MyClass: MyClass myClass=new MyClass() и через этот обьект обращаться
    }

}

class MyClass
{
    int[] a;

    public void Init(int Length)
    {
        a=new int[Length];
        for (int i=0;i<Length;i++) a[i]=i;
    }

}

class MyLibrary
{
    /*
    private void Init(out int[] a,int Length) // private класс стоит по умолчанию, даже если не прописан, он означает что функцию Init можно вызвать только внутри класса MyLibrary
    {
        a=new int[Length];
        for(int i=0;i<Length;i++) a[i]=i;
    }
    */

     static public void Init(out int[] a,int Length) // public  означает что функцию Init можно вызвать в любой части кода
    {
        a=new int[Length];
        for(int i=0;i<Length;i++) a[i]=i;
    }
}