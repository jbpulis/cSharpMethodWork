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
            Console.WriteLine("\n");


            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;

            Console.WriteLine("is it sunny? {0}", !isSunny);

            //increment operator
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            //postincrement
            Console.WriteLine("num is {0}", num++);
            Console.WriteLine("num is {0}", num);
            //preincrement
            Console.WriteLine("num is {0}", ++num);

            //decrement operator
            Console.WriteLine("num is {0}", num);
            //postdecrement
            Console.WriteLine("num is {0}", num--);
            Console.WriteLine("num is {0}", num);
            //predecrement
            Console.WriteLine("num is {0}", --num);

            //additive/multiplicative operators
            int result;
            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 x num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result);

            //relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0}", isLower);

            //equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);

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
