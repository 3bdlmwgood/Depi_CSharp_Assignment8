using System.Collections;

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

        static void ReverseArrayList(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;
            
            while (left < right)
            {
                object temp = list[left];

                list[left] = list[right];
                list[right] = temp;
                
                left++;
                right--;
            }
        }

        static void GetEvenNumbers(List<int> numbers, out List<int> evenNumbers)
        {
            evenNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
        }

        static void Main(string[] args)
        {
            #region Bubble Sort

            Console.WriteLine("Bubble Sort:");

            int[] numbers = { 4, 10, 8, 7, 3, 9, 2, 6, 1, 5 };

            BubbleSort(numbers);

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n---------------------------------------");

            #endregion

            #region Generic Range<T>

            Console.WriteLine("Generic Range<T>:");

            Range<int> range = new Range<int>(0, 10);

            Console.WriteLine(range.IsInRange(7));
            Console.WriteLine(range.IsInRange(15));

            Console.WriteLine(range.Length());

            Console.WriteLine("---------------------------------------");

            #endregion

            #region Reverse Array List 

            Console.WriteLine("Reverse Array List:");

            ArrayList list = new ArrayList();

            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            ReverseArrayList(list);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n---------------------------------------\n");

            #endregion

            #region Even Numbers From List

            Console.WriteLine("Even Numbers From List:");

            List<int> integers = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

           
            GetEvenNumbers(integers, out List<int> evenNumbers);

            foreach (int even in evenNumbers)
            {
                Console.Write(even + " ");
            }
            
            Console.WriteLine("\n---------------------------------------");

            #endregion

            #region Fixed Size List

            Console.WriteLine("Fixed Size List:");

            FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(5);
            fixedSizeList.Add(1);
            fixedSizeList.Add(2);
            fixedSizeList.Add(3);
            fixedSizeList.Add(4);
            fixedSizeList.Add(5);

            //fixedSizeList.Add(6);   This will throw an exception because the list is full.

            Console.WriteLine(fixedSizeList.Get(0));
            Console.WriteLine(fixedSizeList.Get(1));
            Console.WriteLine(fixedSizeList.Get(2));
            Console.WriteLine(fixedSizeList.Get(3));
            Console.WriteLine(fixedSizeList.Get(4));

            Console.WriteLine("---------------------------------------");

            #endregion
        }
    }
}
