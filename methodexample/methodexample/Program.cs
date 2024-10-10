using System.Globalization;

namespace methodexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };

            CustomResize(ref nums,34,28,56);


            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        public static void CustomResize( ref int[] arr,params int[] numbers)
        {
            int[] newArray = new int[arr.Length + numbers.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
           for(int i=0;i<numbers.Length;i++)
            {
                newArray[arr.Length + i] = numbers[i];
            }

            arr = newArray;
              
        }
    }
}