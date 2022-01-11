using System;

namespace Bubble_Sort
{
    class Program
    {

        static void Main(string[] args)
        {
            // declare array to sorted
            int[] unsorted = new int[] { 12, 56, 2, 4, 6, 8, 1, 23, 5, 19, 18, 43, 32, 7, 2 };

            //empty variables for later use
            int temp = 0;
            bool swapped = true;

            //loop while is swapped
            while (swapped == true)
            {
                swapped = false;

                // loop through all elements of array
                for (int i = 0; i < unsorted.Length - 1; i++)
                {
                    // if in wrong order
                    if (unsorted[i] > unsorted[i + 1])
                    {
                        // swap values
                        temp = unsorted[i];
                        unsorted[i] = unsorted[i + 1];
                        unsorted[i + 1] = temp;
                        swapped = true;
                    }
                }
            }

            Console.WriteLine(String.Join(", ", unsorted));


        }
    }
}
