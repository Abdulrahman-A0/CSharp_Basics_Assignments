using System.Text;

namespace C__06
{
    internal class Program
    {
        #region Q1
        /*1- Explain the difference between passing (Value type parameters) by value and by reference then
             write a suitable c# example.*/
        //********************************************************************************************************


        //Passing by Value:
        // => When passing a value type parameter by value a copy of the variable is sent to the function.
        // => Changes made inside the function don't affect the original variable.
        // Pass by value
        public static void PassValueByValue(int x)
        {
            x = x + 5; // This change will NOT affect the original variable
        }

        //Passing by Reference
        // => When passing a value type parameter by reference the function gets access to the original variable.
        // => Any changes made inside the function affect the original variable.
        // Pass by reference
        public static void PassValueByReference(ref int x)
        {
            x = x + 5; // This change WILL affect the original variable
        }
        #endregion

        #region Q2
        /*2- Explain the difference between passing (Reference type parameters) by value and by reference
             then write a suitable c# example.*/
        //********************************************************************************************************

        //Passing Reference Types by Value
        // => can change the contents of the object inside the function.
        // => if assign a new object to the parameter the original variable will not be affected
        public static int SumArray(int[] Arr)//arr = [1,2,3]
        {
            int Sum = 0;
            Arr[0] = 100;
            for (int i = 0; i < Arr.Length; i++)
                Sum += Arr[i];
            return Sum; //105

        }

        //Passing Reference Types by Reference
        // => can change the contents of the object inside the function.
        // =>  assigning a new object to the parameter will update the original variable to point to the new object.
        public static int SumArray(ref int[] Arr)//arr = [1,2,3]
        {
            int Sum = 0;
            Arr[0] = 100;
            Arr = new int[] { 10, 20, 30, 40 };//the original reference will refer to the new object
            for (int i = 0; i < Arr.Length; i++)
                Sum += Arr[i];
            return Sum; //105

        }
        #endregion

        #region Q3
        /*3- Write a c# Function that accept 4 parameters from user and return result
          of summation and subtracting of two numbers */
        //***********************************************************************

        //public static void SumSubt(int num1, int num2, out int sum, out int sub)
        //{
        //    sum = num1 + num2;
        //    sub = num1 - num2;
        //}
        #endregion

        #region Q4
        ///*4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits
        // of a given number. 
        //        Output should be like Enter a number: 25 
        //        The sum of the digits of the number 25 is: 7
        //*/
        ////*****************************************************************************************************

        //public static int SumOfDigits(int num)
        //{
        //    int sum = 0;
        //    while (num > 0)
        //    {
        //        sum += num % 10;
        //        num /= 10;
        //    }
        //    return sum;
        //}
        #endregion

        #region Q5
        ///*5- Create a function named "IsPrime", which receives an integer number and returns true if it is prime,
        //     or false if it is not:*/
        ////*********************************************************************************************************

        //public static bool IsPrime(int num)
        //{
        //    if (num == 0 || num == 1)
        //        return false;

        //    for (int i = 2; i <= Math.Sqrt(num); i++)
        //    {
        //        if (num % i == 0)
        //            return false;
        //    }

        //    return true;
        //}
        #endregion

        #region Q6
        ///*6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array,
        //     using reference parameters */
        ////**********************************************************************************************************

        //public static void MinMaxArray(int[] arr, ref int max, ref int min)
        //{
        //    max = arr.Max();
        //    min = arr.Min();
        //}
        #endregion

        #region Q7
        ///*7- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter*/
        ////************************************************************************************************************

        //public static int Factorial(int num)
        //{
        //    int fact = 1;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        fact *= i;
        //    }
        //    return fact;
        //}
        #endregion

        #region Q8
        ///*8- Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string,
        //     replacing it with a different letter*/
        ////**********************************************************************************************************

        //public static string ChangeChar(string str, int position, char replace)
        //{
        //    StringBuilder sb = new StringBuilder(str);
        //    char oldChar = sb[position];
        //    sb.Replace(oldChar, replace);
        //    return sb.ToString();
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Q3 Function Call
            //int num1, num2;
            //do
            //{
            //    Console.WriteLine("Enter Num1: ");
            //} while (!int.TryParse(Console.ReadLine(), out num1));
            //do
            //{
            //    Console.WriteLine("Enter Num2: ");
            //} while (!int.TryParse(Console.ReadLine(), out num2));
            //int sum, sub;
            //SumSubt(num1, num2, out sum, out sub);
            //Console.WriteLine($"SUM = {sum} ||| SUB = {sub}");
            #endregion

            #region Q4 Function Call
            //int num;
            //do
            //{
            //    Console.WriteLine("Enter A Number: ");
            //} while (!int.TryParse(Console.ReadLine(), out num));

            //Console.WriteLine($"The sum of the digits of number {num} is: {SumOfDigits(num)}");
            #endregion

            #region Q5 Function Call
            //int num;
            //do
            //{
            //    Console.WriteLine("Enter A Number: ");
            //} while (!int.TryParse(Console.ReadLine(), out num));
            //if (IsPrime(num))
            //    Console.WriteLine($"{num} Is Prime");
            //else
            //    Console.WriteLine($"{num} Is Not Prime");
            #endregion

            #region Q6 Function Call
            //int size;
            //do
            //{
            //    Console.Write("Enter Size of Array: ");
            //} while (!int.TryParse(Console.ReadLine(), out size));

            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter element {i + 1} of array: ");
            //    } while (!int.TryParse(Console.ReadLine(), out arr[i]));
            //}
            //int min = 0, max = 0;
            //MinMaxArray(arr, ref max, ref min);
            //Console.WriteLine($"MAX = {max} ||| MIN = {min}");
            #endregion

            #region Q7 Function Call
            //int num;
            //do
            //{
            //    Console.Write("Enter A Number: ");
            //} while (!int.TryParse(Console.ReadLine(), out num));
            //Console.WriteLine($"Factorial of {num} = {Factorial(num)}");
            #endregion

            #region Q8 Function Call
            //string str;
            //do
            //{
            //    Console.Write("Enter String: ");
            //    str = Console.ReadLine();
            //} while (string.IsNullOrEmpty(str));

            //int pos;
            //do
            //{
            //    Console.Write("Enter Position to replace: ");
            //} while (!int.TryParse(Console.ReadLine(), out pos) || (pos < 0 || pos >= str.Length));

            //char newChar;
            //do
            //{
            //    Console.Write("Enter new char value: ");
            //} while (!char.TryParse(Console.ReadLine(), out newChar));

            //str = ChangeChar(str, pos, newChar);
            //Console.WriteLine($"Sting After Replacing is: {str}");
            #endregion

        }
    }
}
