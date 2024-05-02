using System;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {20,1,3,10,6,9,4,30,27,29};
            int temp = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j=i+1;j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp=arr[i];
                        arr[i]=arr[j];
                        arr[j]=temp;
                    }
                }
            }
           foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
