using System.Threading.Channels;

namespace C__05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
                    Example 
                    Input: 5
                    Output: 1, 2, 3, 4, 5
             */
            //*********************************************************************

            //Console.WriteLine("Enter A Number:");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //    Console.Write($"{i} ");
            #endregion

            #region Q2
            /*2- Write a program that allows the user to insert an integer then 
                 print a multiplication table up to 12.
                    Example
                    Input: 5
                    Outputs: 5 10 15 20 25 30 35 40 45 50 55 60
             */
            //********************************************************************

            //Console.WriteLine("Enter A Number:");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //    Console.WriteLine($"{num} * {i} = {num * i}");
            #endregion

            #region Q3
            /*3- Write a program that allows to user to insert number then print all even numbers
              between 1 to this number
                     Example:
                     Input: 15
                     Output: 2 4 6 8 10 12 14
             */
            //**********************************************************************************

            //Console.WriteLine("Enter A Number: ");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.Write($"{i} ");
            //}
            #endregion

            #region Q6
            /*6- Write a program to allow the user to enter a string and print the REVERSE of it.*/
            //*************************************************************************************************

            //Console.WriteLine("Enter A String:");
            //string str = Console.ReadLine();
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(str[i]);
            //}

            #endregion

            #region Q7
            /*7- Write a program to allow the user to enter int and print the REVERSED of it.*/
            //****************************************************************************************

            //Console.WriteLine("Enter A Number:");
            //int num = int.Parse(Console.ReadLine());
            //int reversed = 0;
            //while (num > 0)
            //{
            //    reversed = (reversed * 10) + (num % 10);
            //    num /= 10;
            //}
            //Console.WriteLine(reversed);
            #endregion

            #region Q8
            /*8- Write a program in C# Sharp to find prime numbers within a range of numbers.
                    Test Data :
                    Input starting number of ranges: 1
                    Input ending number of range : 50

                    Expected Output :
                    The prime number between 1 and 50 are :
                    2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
             */
            //*********************************************************************************

            //Console.WriteLine("Enter Starting Number:");
            //int startNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Ending Number:");
            //int endingNum = int.Parse(Console.ReadLine());

            //for (int i = startNum; i <= endingNum; i++)
            //{
            //    if (i == 1)
            //        continue;

            //    bool isPrime = true;

            //    for (int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //        Console.Write($"{i} ");
            //}
            #endregion

            #region Q9
            /*9- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
                        Test Data :
                        Enter a number to convert :25
                        Expected Output :
                        The Binary of 25 is 11001.
             */
            //****************************************************************************************

            //Console.WriteLine("Enter A Number to convert:");
            //int num = int.Parse(Console.ReadLine());
            //int temp = num;
            //string binary = "";
            //while (temp > 0)
            //{
            //    int rem = temp % 2;
            //    binary = rem + binary;
            //    temp /= 2;
            //}
            //Console.WriteLine($"The Binary of {num} is {binary}");

            #endregion

            #region Q11
            /*11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from
              the user and shows the identity table of size n * n.
            */
            //**************************************************************************************************

            //Console.WriteLine("Enter Size of Matrix:");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < num; j++)
            //    {
            //        if (i == j)
            //            Console.Write($"1 ");
            //        else
            //            Console.Write($"0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q12
            /*12- Write a program in C# Sharp to find the sum of all elements of the array.*/
            //****************************************************************************************

            //Console.WriteLine("Enter Elements separated with a space:");
            //string[] arr = Console.ReadLine().Split();
            //int sum = 0;
            //foreach (var num in arr)
            //{
            //    sum += int.Parse(num);
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Q13
            /*13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.*/
            //******************************************************************************************************

            //string[] input1, input2;
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Enter two same size arrays");
            //    Console.WriteLine("Enter First Array: ");
            //    input1 = Console.ReadLine().Split();
            //    Console.WriteLine("Enter Second Array: ");
            //    input2 = Console.ReadLine().Split();
            //} while (input1.Length != input2.Length);

            ////Casting to int arrays
            //int[] array1 = new int[input1.Length];
            //int[] array2 = new int[input2.Length];
            //for (int i = 0; i < input1.Length; i++)
            //{
            //    array1[i] = int.Parse(input1[i]);
            //    array2[i] = int.Parse(input2[i]);
            //}

            ////Merging
            //int[] array3 = new int[input1.Length * 2];
            //for (int i = 0; i < input1.Length * 2; i++)
            //{
            //    if (i < input1.Length)
            //        array3[i] = array1[i];
            //    else
            //        array3[i] = array2[i - input1.Length];
            //}

            ////Sorting
            //for (int i = 0; i < array3.Length; i++)
            //{
            //    int temp = 0;
            //    for (int j = i; j < array3.Length; j++)
            //    {
            //        if (array3[i] > array3[j])
            //        {
            //            temp = array3[i];
            //            array3[i] = array3[j];
            //            array3[j] = temp;
            //        }
            //    }
            //}
            //Console.Write("array3: [ ");
            //for (int i = 0; i < array3.Length; i++)
            //{
            //    Console.Write($"{array3[i]}, ");
            //}
            //Console.Write("]");
            #endregion

            #region Q14
            /*14- Write a program in C# Sharp to count the frequency of each element of an array.*/
            //**************************************************************************************************

            //Console.WriteLine("Enter Array Number Separated With Spaces:");
            //string[] arr = Console.ReadLine().Split();

            //Dictionary<int, int> freq = new Dictionary<int, int>();
            //foreach (var item in arr)
            //{
            //    int num = int.Parse(item);
            //    freq[num] = freq.ContainsKey(num) ? ++freq[num] : 1;
            //}
            //foreach (var item in freq)
            //{
            //    Console.WriteLine($"{item.Key} Repeated {item.Value} Times");
            //}
            #endregion

            #region Q15
            /*15- Write a program in C# Sharp to find maximum and minimum element in an array*/
            //******************************************************************************************

            //Console.WriteLine("Enter Array Number Separated With Spaces:");
            //string[] arr = Console.ReadLine().Split();

            //int max = arr.Max(x => int.Parse(x));
            //int min = arr.Min(x => int.Parse(x));

            //Console.WriteLine($"Max= {max} ||| Min= {min}");
            #endregion

            #region Q16
            /*16- Write a program in C# Sharp to find the second largest element in an array.*/
            //*******************************************************************************************

            //Console.WriteLine("Enter Array Number Separated With Spaces:");
            //string[] input = Console.ReadLine().Split();

            //int max = input.Max(x => int.Parse(x));
            //int sMax = int.MinValue;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (int.Parse(input[i]) > sMax && int.Parse(input[i]) < max)
            //        sMax = int.Parse(input[i]);
            //}

            //Console.WriteLine(sMax);
            #endregion

            #region Q17
            /*write a program find the longest distance between Two equal cells. In this example.
             The distance is measured by the number Of cells- for example, the distance between the first and the
             fourth cell is 2 (cell 2 and cell 3).*/
            //*********************************************************************************

            //Console.WriteLine("Enter Array Number Separated With Space:");
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //int longestDist = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1;
            //            longestDist = distance > longestDist ? distance : longestDist;
            //        }
            //    }
            //}

            //Console.WriteLine($"Longest Distance= {longestDist}");
            #endregion

            #region Q18
            /*18- Given a list of space separated words, reverse the order of the words.
                    Input: this is a test		Output: test a is this
                    Input: all your base		Output: base your all
                    Input: Word			Output: Word
                    Note : 
                    Check the Split Function (Member in String Class) Output will be a Single Console.WriteLine Statement
            */
            //***************************************************************************************************

            //Console.WriteLine("Enter A String To reverse:");
            //string[] words = Console.ReadLine().Split();
            //string reversed = "";
            //foreach (var word in words)
            //{
            //    reversed = word + " " + reversed;
            //}
            //Console.WriteLine(reversed);
            #endregion

            #region Q19
            /*19- Write a program to create two multidimensional arrays of same size. Accept value from user 
             and store them in first array. Now copy all the elements of first array on second array 
             and print second array.*/
            //******************************************************************************************

            //Console.WriteLine("Enter Dimensions of the arrays (n m)");
            //int[] dim = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //int rows = dim[0];
            //int cols = dim[1];
            //int[,] array1 = new int[rows, cols];
            //int[,] array2 = new int[rows, cols];
            //for (int i = 0; i < rows; i++)
            //{
            //    Console.WriteLine($"Enter Values for row({i})");
            //    int[] row = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //    for (int j = 0; j < cols; j++)
            //    {
            //        array1[i, j] = row[j];
            //    }
            //}

            //Array.Copy(array1, array2, rows * cols);

            //Console.WriteLine("Array 2:");
            //for (int i = 0; i < rows * cols; i++)
            //{
            //    int row = i / cols;
            //    int col = i % cols;

            //    Console.Write($"{array2[row, col]}  ");
            //    if (col == cols - 1)
            //        Console.WriteLine();
            //}
            #endregion

            #region Q20
            /*20- Write a Program to Print One Dimensional Array in Reverse Order*/
            //**************************************************************************************

            //Console.WriteLine("Enter Array Values:");
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //for (int i = arr.Length - 1; i >= 0; i--)
            //    Console.Write($"{arr[i]} ");
            #endregion
        }
    }
}
