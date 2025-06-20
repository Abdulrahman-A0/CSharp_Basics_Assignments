using System.Threading.Channels;

namespace C__02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // 1-Write a program that allows the user to enter a number then print it.

            //Console.WriteLine("Enter Number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(num);
            #endregion

            #region Q2
            /*2-Write C# program that converts a string to an integer, but the string contains non-numeric characters
                 * . And mention what will happen */

            //string str = "54Fwr45";
            //int.Parse(str);

            // parse function will throw an Exception becasue string contains non numeric characters 
            #endregion

            #region Q3
            /* 3-Write C# program that Perform a simple arithmetic operation with floating-point numbers 
                   And mention what will happen */

            //Console.WriteLine(3.5 + 2.8); 

            // the result will be a floating-point number
            #endregion

            #region Q4
            /*4-Write C# program that Extract a substring from a given string.*/

            //string str = "Abdulrahman Ahmed";
            //Console.WriteLine(str.Substring(0, 11)); 
            #endregion

            #region Q5
            /* 5-Write C# program that Assigning one value type variable to another and modifying the value
                 * of one variable and mention what will happen */

            //int x = 5;
            //int y = x;
            //x++;

            // the value of x will be 6 but the value of y still 5 as it doesn't refer to the same address of x variable 
            #endregion

            #region Q6
            /* 6-Write C# program that Assigning one reference type variable to another and modifying the object 
                 * through one variable and mention what will happen */

            //Test test1 = new Test() { x = 1 };
            //Test test2 = new Test();
            //test2 = test1;
            //test1.x = 5;
            //Console.WriteLine(test2.x);

            // the value of the two variables will be changed to 5 because they reference the same address in heap 
            #endregion

            #region Q7
            /* 7-Write C# program that take two string variables and print them as one variable */

            //Console.WriteLine("Enter First string: ");
            //string str1 = Console.ReadLine();
            //Console.WriteLine("Enter Second String: ");
            //string str2 = Console.ReadLine();

            //Console.WriteLine(str1 + str2); 
            #endregion

            #region Q8
            /*8-	Which of the following statements is correct about the C#.NET code snippet given below?
                int d; 
                d = Convert.ToInt32( !(30 < 20) );
            */

            //  b)A value 1 will be assigned to d.

            #endregion

            #region Q9
            /*9-	Which of the following is the correct output for the C# code given below?
                
                    Console.WriteLine(13 / 2 + " " + 13 % 2); 
            */

            // d)6 1

            #endregion

            #region Q10
            /*What will be the output of the C# code given below?
                    int num = 1, z = 5;
                    
                    if (!(num <= 0))
                        Console.WriteLine( ++num + z++ + " " + ++z ); 
                    else
                        Console.WriteLine( --num + z-- + " " + --z ); 
            */

            //d)7 7
            #endregion
        }
    }
}
