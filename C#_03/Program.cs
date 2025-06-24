using System.Threading.Channels;
using System.Transactions;

namespace C__03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*1- Write a program that takes a number from the user then print yes if that number can be divided by
              3 and 4 otherwise print no.
                Example (1)
                Input: 12 
                Output: Yes
            */
            //--------------------------------------------------------------------------------------

            //Console.WriteLine("Enter A Number: ");
            //int num;
            //if (int.TryParse(Console.ReadLine(), out num))
            //{
            //    if (num % 3 == 0 && num % 4 == 0)
            //        Console.WriteLine("Yes");
            //    else
            //        Console.WriteLine("No");
            //}
            //else
            //{
            //    Console.WriteLine("Enter A Valid Number!!");
            //}
            #endregion

            #region Q2
            /*2- Write a program that allows the user to insert an integer then print negative if it is
                negative number otherwise print positive.
                   Example (1)
                   Input: -5
                   Output: negative
                   Example (2)
                   Input: 10
                   Output: positive
             */
            //--------------------------------------------------------------------------------------

            //Console.WriteLine("Enter A Number: ");
            //int num;
            //if (int.TryParse(Console.ReadLine(), out num))
            //{
            //    if (num < 0)
            //        Console.WriteLine("Negative");
            //    else
            //        Console.WriteLine("Positive");
            //}
            //else
            //{
            //    Console.WriteLine("Enter A Valid Number!!");
            //}
            #endregion

            #region Q3
            /*3- Write a program that takes 3 integers from the user then prints the max element and the min element.
                    Example (1)
                    Input:7,8,5
                    Output:
                    max element = 8
                    min element = 5
                    Example (2)
                    Input: 3 6 9
                    Outputs:
                    Max element = 9
                    Min element = 3
            */
            //--------------------------------------------------------------------------------------

            //Console.WriteLine("Enter First Num: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Num: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Third Num: ");
            //int num3 = int.Parse(Console.ReadLine());

            //int max, min;
            ////Find Max
            //if (num1 > num2)
            //{
            //    if (num1 > num3)
            //        max = num1;
            //    else
            //        max = num3;
            //}
            //else
            //{
            //    if (num2 > num3)
            //        max = num2;
            //    else
            //        max = num3;
            //}
            ////Find Min
            //if (num1 < num2)
            //{
            //    if (num1 < num3)
            //        min = num1;
            //    else
            //        min = num3;
            //}
            //else
            //{
            //    if (num2 < num3)
            //        min = num2;
            //    else
            //        min = num3;
            //}

            //Console.WriteLine($"Max element = {max}");
            //Console.WriteLine($"Min element = {min}");
            #endregion

            #region Q4
            /*4- Write a program that allows the user to insert an integer number then check If a number is even or odd.*/
            //--------------------------------------------------------------------------------------

            //Console.WriteLine("Enter A Number: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //    Console.WriteLine("Even");
            //else
            //    Console.WriteLine("Odd");
            #endregion

            #region Q5
            /*5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u)
                then print (vowel) otherwise print (consonant).
                        Example (1)
                        Input: O
                        Output: vowel
                        Example (2)
                        Input: b
                        Output: Consonant
            */
            //--------------------------------------------------------------------------------------

            //Console.WriteLine("Enter A Character: ");
            //char c = char.Parse(Console.ReadLine());
            //switch (c)
            //{
            //    case 'a':
            //    case 'A':
            //    case 'e':
            //    case 'E':
            //    case 'i':
            //    case 'I':
            //    case 'o':
            //    case 'O':
            //    case 'u':
            //    case 'U':
            //        Console.WriteLine("Vowel");
            //        break;
            //    default:
            //        Console.WriteLine("Consonant");
            //        break;
            //}
            #endregion

            #region Q6
            /*10- Write a program to enter marks of five subjects and calculate total, average and percentage.
                    Example
                    Input: - Enter Marks of five subjects: 95 76 58 90 89
                    Output: Total marks = 408
                            Average Marks = 81
                            Percentage = 81
            */
            //--------------------------------------------------------------------------------------

            //Console.WriteLine("Enter Five Subject Marks: ");
            //string[] input = Console.ReadLine().Split();

            //int sum = 0;
            //foreach (var item in input)
            //{
            //    sum += int.Parse(item);
            //}
            //double average = sum / 5.0;
            //double percentage = sum / 500.0 * 100;

            //Console.WriteLine($"Total marks = {sum}");
            //Console.WriteLine($"Average marks = {average}");
            //Console.WriteLine($"Percentage = {percentage}");
            #endregion

            #region Q7
            /*11- Write a program to input the month number and print the number of days in that month.
                    Example
                    Input: Month Number: 1
                    Output: Days in Month: 31
            */
            //--------------------------------------------------------------------------------------

            //Console.WriteLine("Enter Month Number");
            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 2:
            //        Console.WriteLine("Days in Month: 28");
            //        break;
            //    default:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //}
            #endregion

            #region Q8
            /*12- Write a program to create a Simple Calculator.*/
            //--------------------------------------------------------------------------------------

            //Console.WriteLine("Write Your Equation in this Format: (Num) (Operation) (Num)");
            //string[] input = Console.ReadLine().Split();
            //double num1 = double.Parse(input[0]);
            //double num2 = double.Parse(input[2]);
            //char operation = char.Parse(input[1]);

            //switch (operation)
            //{
            //    case '+':
            //        Console.WriteLine($"Sum = {num1 + num2}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"Diff = {num1 - num2}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"Mult = {num1 * num2}");
            //        break;
            //    case '/':
            //        Console.WriteLine($"Div = {num1 / num2}");
            //        break;
            //}
            #endregion
        }
    }
}
