﻿// Найти расстояние между точками в пространстве 2D

double Distance(double x1,double x2,double y1,double y2)
{
    double d;
    d=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y1-y2,2));
    return d;
}

double x1=0,x2=10,y1=0,y2=10;

System.Console.WriteLine(Distance(x1,x2,y1,y2));