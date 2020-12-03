using System;

namespace OOP3
{
    class Program
    {
        public static void Main()
        {
            MyClass myClass = new MyClass();

            Console.WriteLine(myClass.X);
        }
    }

    class MyClass
    {
        int x;

        public int X { get { return x; } }
        public MyClass() { }
        public MyClass(int x)
        {
            this.x = x;
        }
    }
}
