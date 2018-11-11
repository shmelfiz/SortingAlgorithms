using SortAlgorithms.Algorithms;
using SortAlgorithms.Enums;

namespace SortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var unsortedArray = new int[] { 12, 33, 45, 67, 23, 11, 55, 11, 77, 34, 89 };
            
            /*ShowInsertionSortSort(unsortedArray);
            ShowSelectionSort(unsortedArray);
            ShowBubbleSort(unsortedArray);*/
            ShowMergeSort(unsortedArray);
        }

        public static void ShowBubbleSort(int[] unsortedArray)
        {
            var bubbleSort = new BubbleSort(unsortedArray);
            var sorted = bubbleSort.SortIntArray();

            ConsoleHelper.ShowAlgorithmResult(sorted, AlgorithmType.BubbleSort);
        }

        public static void ShowSelectionSort(int[] unsortedArray)
        {
            var selectionSort = new SelectionSort(unsortedArray);
            var sorted = selectionSort.SortIntArray();

            ConsoleHelper.ShowAlgorithmResult(sorted, AlgorithmType.SelectionSort);
        }

        public static void ShowInsertionSortSort(int[] unsortedArray)
        {
            var insertionSort = new InsertionSort(unsortedArray);
            var sorted = insertionSort.SortIntArray();

            ConsoleHelper.ShowAlgorithmResult(sorted, AlgorithmType.InsertionSort);
        }

        public static void ShowMergeSort(int[] unsortedArray)
        {
            var mergeSort = new MergeSort(unsortedArray);
            var sorted = mergeSort.SortIntArray();

            ConsoleHelper.ShowAlgorithmResult(sorted, AlgorithmType.MergeSort);
        }
    }
}
