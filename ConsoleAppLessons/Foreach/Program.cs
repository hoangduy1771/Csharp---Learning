using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Array
            //int[] Array = { 1, 5, 2, 4, 6, 7 };
            //int Sum = 0;

            //Console.WriteLine(Array);

            //foreach (int item in Array)
            //{
            //    Console.WriteLine(item);
            //    Sum += item;
            //}
            //Console.WriteLine("Sum: " + Sum);
            #endregion

            #region Foreach Jagged Array
            int[][] JaggedArray =
            {
                new int[] { 1, 2, 3 },
                new int[] { 5, 2, 4, 1, 6 },
                new int[] { 7, 3, 4, 2, 1, 5, 9, 8 }
            };

            foreach (int[] Element in JaggedArray)
            {
                foreach (int item in Element)
                {
                    Console.Write(item + "   ");
                }
                Console.WriteLine();
            }
            #endregion


            Console.ReadLine();
        }
    }


}




