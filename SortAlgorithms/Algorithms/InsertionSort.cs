using SortAlgorithms.Algorithms.Interfaces;
using System.Collections.Generic;

namespace SortAlgorithms.Algorithms
{
    public class InsertionSort : IInsertionSort
    {
        private int[] _unsortedArray;
        public InsertionSort(int[] unsortedArray)
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
                for (var k = 0; k < _unsortedArray.Length; k++)
                {
                    if (i + k < _unsortedArray.Length && _unsortedArray[i] > _unsortedArray[i + k])
                    {
                        var temp = _unsortedArray[i + k];
                        _unsortedArray[i + k] = _unsortedArray[i];
                        _unsortedArray[i] = temp;
                    }
                }
            }
            var sortedArray = _unsortedArray;

            return sortedArray;
        }
    }
}
