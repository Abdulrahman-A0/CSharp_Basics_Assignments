namespace C__04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*1- Create a program that asks the user to input three points (x1, y1), (x2, y2),
              and (x3, y3), and determines whether these points lie on a single straight line.
             */
            //-----------------------------------------------------------------------

            //Console.WriteLine("Enter First Point: (x1,y1):");
            //string[] point1 = Console.ReadLine().Split();
            //Console.WriteLine("Enter Second Point: (x2,y2):");
            //string[] point2 = Console.ReadLine().Split();
            //Console.WriteLine("Enter Third Point: (x3,y3):");
            //string[] point3 = Console.ReadLine().Split();

            //double slope1 =
            //    (double.Parse(point2[1]) - double.Parse(point1[1])) / (double.Parse(point2[0]) - double.Parse(point1[0]));

            //double slope2 =
            //    (double.Parse(point3[1]) - double.Parse(point2[1])) / (double.Parse(point3[0]) - double.Parse(point2[0]));

            //if (slope1 == slope2)
            //    Console.WriteLine("Points lie on a single straight line");
            //else
            //    Console.WriteLine("Points aren't on a single line");
            #endregion

            #region Q2
            /*2- Within a company, the efficiency of workers is evaluated based on the duration required to complete
               a specific task. A worker's efficiency level is determined as follows: 
                    - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
                    - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
                    - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
                    - If the worker takes more than 5 hours, they are required to leave the company. 
                To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

             */
            //----------------------------------------------------------------------------

            //Console.WriteLine("Enter Time taken to complete the task:");
            //double time = double.Parse(Console.ReadLine());
            //string efficiency = time switch
            //{
            //    >= 2 and <= 3 => "highly efficient",
            //    > 3 and <= 4 => "need to be instructed",
            //    > 4 and <= 5 => "You need training to enhance speed",
            //    > 5 => "require to leave the company",
            //    _ => "Invalid hours"
            //};
            //Console.WriteLine(efficiency);
            #endregion

            #region Q3
            /*20- Write a program in C# Sharp to find the sum of all elements of the array.*/
            //-----------------------------------------------------------------------------------------

            //Console.WriteLine("Enter Array Numbers: ");
            //string[] input = Console.ReadLine().Split();

            //int sum = 0;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    sum += int.Parse(input[i]);
            //}
            //Console.WriteLine($"Sum= {sum}");
            #endregion

            #region Q4
            #region Merging and Sorting
            /*21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.*/
            //--------------------------------------------------------------------------

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

            #region Longest Distance
            /*write a program find the longest distance between Two equal cells. In this example. 
             The distance is measured by the number Of cells- for example, the distance between 
             the first and the fourth cell is 2 (cell 2 and cell 3).
             */
            //----------------------------------------------------------------------

            //int longestDist = 0;
            //for (int i = 0; i < array3.Length; i++)
            //{
            //    for (int j = i; j < array3.Length; j++)
            //    {
            //        if (array3[i] == array3[j])
            //        {
            //            int distance = j - i - 1;
            //            longestDist = distance > longestDist ? distance : longestDist;
            //        }
            //    }
            //}

            //Console.WriteLine($"Longest Distance= {longestDist}");
            #endregion


            #endregion
        }
    }
}
