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
            Console.WriteLine("\n");


            HelloFriend("Jeff", "Amanda", "Tyson");
            Console.WriteLine("\n");


            Console.WriteLine("Enter your name: ");
            string input = Console.ReadLine();
            Console.WriteLine(input);
            Addition();
            Console.WriteLine("\n");


            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();
            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exceeption, please enter the correct type next time!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an int32.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNull exception, the value was empty(null).");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }
            Division();




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

        public static void HelloFriend(string friend1, string friend2, string friend3)
        {
            Console.WriteLine("Hi " + friend1 + ", my friend.");
            Console.WriteLine("Hi " + friend2 + ", my friend.");
            Console.WriteLine("Hi " + friend3 + ", my friend.");
        }

        //-----------------------------------------------------

        public static void Addition()
        {

            Console.WriteLine("Enter the first value to add:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value to add:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int sum = input1 + input2;
            Console.WriteLine("The sum of " + input1 + " + " + input2 + " is " + sum);

        }

        //------------------------------------------------------

        public static void Division()
        { 

            Console.WriteLine("Enter the value of the dividend:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of the divisor:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                int quotient = input1 / input2;
                Console.WriteLine("The quotient of " + input1 + " / " + input2 + " is " + quotient);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("DivideByZero Exception, division by zero is not possible.");
            }
        }

        //-------------------------------------------------------
    }
}
