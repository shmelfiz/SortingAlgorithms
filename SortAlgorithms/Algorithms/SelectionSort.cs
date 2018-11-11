using SortAlgorithms.Algorithms.Interfaces;
using System.Collections.Generic;

namespace SortAlgorithms.Algorithms
{
    public class SelectionSort : ISelectionSort
    {
        private int[] _unsortedArray;
        public SelectionSort(int[] unsortedArray)
        {
            _unsortedArray = unsortedArray;
        }

        public int[] SortIntArray()
        {
            if (_unsortedArray == null || _unsortedArray.Length == 0)
            {
                return new List<int>().ToArray();
            }

            for (var i = 0; i < _unsortedArray.Length; i++)
            {
                for (var k = i; k < _unsortedArray.Length; k++)
                {
                    if (k < _unsortedArray.Length - 1 && _unsortedArray[i] > _unsortedArray[k])
                    {
                        var temp = _unsortedArray[i];
                        _unsortedArray[i] = _unsortedArray[k];
                        _unsortedArray[k] = temp;
                    }
                }
            }
            var sortedArray = _unsortedArray;

            return sortedArray;
        }
    }
}
