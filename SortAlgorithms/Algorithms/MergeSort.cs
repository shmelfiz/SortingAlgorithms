using SortAlgorithms.Algorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortAlgorithms.Algorithms
{
    public class MergeSort : IMergeSort
    {
        private int[] _unsortedArray;
        public MergeSort(int[] unsortedArray)
        {
            _unsortedArray = unsortedArray;
        }

        public int[] SortIntArray()
        {
            if(_unsortedArray == null || _unsortedArray.Length == 0)
            {
                return new List<int>().ToArray();
            }

            var middlePos = GetMiddlePositionForArray(_unsortedArray);
            var leftPart = GetCutPartOfArray(_unsortedArray, middlePos, true);
            var rightPart = GetCutPartOfArray(_unsortedArray, middlePos, false);

            var sortedLeftPart = SortUnsortedCutPart(leftPart, 0);
            var sortedRightPart = SortUnsortedCutPart(rightPart, 0);

            var result = MergeSortedRanges(sortedLeftPart, sortedRightPart , null, 0, 0);

            return result;
        }

        private int[] MergeSortedRanges(int[] leftRange, int[] rightRange , List<int> summedRange, int largestStartPos, int smalestStartPos)
        {
            summedRange = summedRange == null ? 
                new List<int>() : summedRange;
            var largestRange = leftRange.Length > rightRange.Length ?
                leftRange : rightRange;
            var smalestRange = leftRange.Length > rightRange.Length ?
                rightRange : leftRange;

            if(smalestRange.Length + largestRange.Length - summedRange.Count == 0)
            {
                return summedRange.ToArray();
            }

            for(var i = largestStartPos; i < largestRange.Length; i++)
            {
                for(var k = smalestStartPos; k < smalestRange.Length; k++)
                {
                    if(k > smalestRange.Length - 1)
                    {
                        break;
                    }

                    if(largestRange[i] > smalestRange[k])
                    {
                        summedRange.Add(smalestRange[k]);

                        return MergeSortedRanges(leftRange, rightRange, summedRange, i, k + 1);
                    }

                    if(largestRange[i] < smalestRange[k])
                    {
                        summedRange.Add(largestRange[i]);

                        return MergeSortedRanges(leftRange, rightRange, summedRange, i + 1, k); ;
                    }
                }

                if (i >= smalestRange.Length - 1)
                {
                    summedRange.Add(largestRange[i]);
                    continue;
                }
            }

            return summedRange.ToArray();
        }

        private int[] SortUnsortedCutPart(int[] unsortedArray, int startPos)
        {
            if(unsortedArray.Length - startPos == 1 || unsortedArray.Length - startPos == 0)
            {
                for(int i = 0; i < unsortedArray.Length; i++)
                {
                    if(i + 1 < unsortedArray.Length - 1 && unsortedArray[i] > unsortedArray[i + 2])
                    {
                        var temp = unsortedArray[i];
                        unsortedArray[i] = unsortedArray[i + 2];
                        unsortedArray[i + 2] = temp;
                        continue;
                    }

                    if(i < unsortedArray.Length - 1 && unsortedArray[i] > unsortedArray[i + 1])
                    {
                        var temp = unsortedArray[i];
                        unsortedArray[i] = unsortedArray[i + 1];
                        unsortedArray[i + 1] = temp;
                    }
                }

                var sortedArray = unsortedArray;

                return sortedArray;
            }

            for (var i = startPos; i < unsortedArray.Length; i++)
            {
                if (i + 1 < unsortedArray.Length - 1 && unsortedArray[i] > unsortedArray[i + 2])
                {
                    var temp = unsortedArray[i];
                    unsortedArray[i] = unsortedArray[i + 2];
                    unsortedArray[i + 2] = temp;
                    continue;
                }

                if (i < unsortedArray.Length - 1 && unsortedArray[i] > unsortedArray[i + 1])
                {
                    var temp = unsortedArray[i];
                    unsortedArray[i] = unsortedArray[i + 1];
                    unsortedArray[i + 1] = temp;
                    startPos = i + 2;
                    break;
                }
                startPos = i + 2;
                break;
            }

            return SortUnsortedCutPart(unsortedArray, startPos);
        }

        private int[] GetCutPartOfArray(int[] unsortedArray, int middlePoint, bool isItLeftPart)
        {
            var startPos = isItLeftPart ? 0 : unsortedArray.Length - 1 - middlePoint;
            var endPos = isItLeftPart ? middlePoint : unsortedArray.Length;
            var cutPart = new List<int>();

            for(int i = startPos; i < endPos; i++)
            {
                cutPart.Add(unsortedArray[i]);
            }

            return cutPart.ToArray();
        }

        private int GetMiddlePositionForArray(int[] unsortedArray)
        {
            var middlePos = Math.Abs(unsortedArray.Length / 2);

            return middlePos;
        }
    }
}
