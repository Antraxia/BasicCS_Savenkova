//С клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

string str = "qwerty.qwe";
int countBefore = str.IndexOf('.');
int count=0;
char[] cc=str.ToArray();
for(int i=0;i<countBefore;i++)
    count++;
System.Console.WriteLine(count);