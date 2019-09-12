using System;

namespace MethodWork
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am and argument and am called from a method!" + "\n");
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


    }
}
