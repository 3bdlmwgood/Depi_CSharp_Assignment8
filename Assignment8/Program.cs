namespace Assignment8
{
    internal class Program
    {
        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            #region Bubble Sort

            int[] numbers = { 4, 10, 8, 7, 3, 9, 2, 6, 1, 5 };

            BubbleSort(numbers);

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            #endregion

            #region Generic Range<T>

            Range<int> range = new Range<int>(0, 10);

            Console.WriteLine(range.IsInRange(7));
            Console.WriteLine(range.IsInRange(15));

            Console.WriteLine(range.Length());

            #endregion
        }
    }
}
