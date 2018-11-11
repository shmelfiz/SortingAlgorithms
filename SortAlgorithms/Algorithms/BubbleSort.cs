using SortAlgorithms.Algorithms.Interfaces;
using System.Collections.Generic;

namespace SortAlgorithms.Algorithms
{
    public class BubbleSort : IBubbleSort
    {
        private int[] _unsortedArray;
        public BubbleSort(int[] unsortedArray)
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
                    if (k < _unsortedArray.Length - 1 && _unsortedArray[k] > _unsortedArray[k + 1])
                    {
                        var temp = _unsortedArray[k];
                        _unsortedArray[k] = _unsortedArray[k + 1];
                        _unsortedArray[k + 1] = temp;
                    }
                }
            }
            var sortedArray = _unsortedArray;

            return sortedArray;
        }
    }
}
