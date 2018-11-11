using SortAlgorithms.Enums;
using System;

namespace SortAlgorithms
{
    public static class ConsoleHelper
    {
        public static void ShowAlgorithmResult(int[] sortedArrayToShow, AlgorithmType algorithmType)
        {
            if (sortedArrayToShow == null || sortedArrayToShow.Length == 0)
            {
                Console.WriteLine("Error while showing sorted array!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine(algorithmType.ToString() + ": ");

            foreach (var item in sortedArrayToShow)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
