using System;

namespace MethodWork
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am and argument and am called from a method!" + "\n");

            Console.WriteLine(Add(15,31));
            Console.WriteLine(Add(Add(1, 2), Add(10, 5)));
            Console.WriteLine(Multiply(2, 3));
            Console.WriteLine(Divide(25, 13));
        }
        //access modifier, (static), return type, method name (parameter1, parameter2,...)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method.");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        //----------------------------------------------------

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        //----------------------------------------------------


    }
}
