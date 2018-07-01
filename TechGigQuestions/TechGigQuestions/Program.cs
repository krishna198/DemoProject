using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGigQuestions
{
    public class Program
    {        
        static void Main(string[] args)
        {
            var arr = new int[] { 1,1,1,1,1,1,1,1,0};
            BinaryArraySortingWithoutLibraryFunctions(arr);
            //var arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int nodeToDelete = 4;
            CountingOfLeaves countingLeaves = new CountingOfLeaves();
            //int numberOfLevels = countingLeaves.GetTheNodeLevel(10);
            int remainingNodes = countingLeaves.NumberOfLeafNodesAfterDeleting(arr.Length,nodeToDelete);
            Console.WriteLine("The remaining number of nodes are : "+remainingNodes);

        }

        public static void BinaryArraySortingWithoutLibraryFunctions(int[] arr)
        {
            
            Console.WriteLine("Before sorting the array...");
            PrintTheArrayElements(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                { }
                else
                {
                    for (int j = i+1; j < arr.Length; j++)
                    {
                        if (arr[j] == 0)
                        {
                            arr[j] = 1;
                            arr[i] = 0;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("After sorting the array...");
            PrintTheArrayElements(arr);
        }

        public static void PrintTheArrayElements(int [] arr)
        {
            foreach (var t in arr)
                Console.Write(t + " ");
            Console.WriteLine("");
        }

    }
}
