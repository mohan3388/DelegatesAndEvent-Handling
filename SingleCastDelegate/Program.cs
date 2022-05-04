using System;
using SingleCastDelegate;
using static SingleCastDelegate.Delegate;

class Program
{
    public static void Main(string[] args)
    {
        data add = new data(Add);
        Console.WriteLine("addition of 2 numbers= " + add(20, 40));
    }
}