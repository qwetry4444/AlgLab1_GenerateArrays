using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GenerateSequence.PerformanceAnalysis;

namespace GenerateSequence
{
    public static class Search
    {
        public static int LinerSearch<T>(Sequence<T> seq, T target, CountingComparer<T> comparer) where T : struct, IComparable<T>
        {
            for (int i = 0; i < seq.len; i++)
            {
                if (comparer.Compare(seq.data[i], target) == 0)
                    return i;
            }
            return -1; 
        }

        public static int JumpSearch<T>(Sequence<T> seq, T target, int jumpSize, CountingComparer<T> comparer) where T : struct, IComparable<T>
        {
            int n = seq.len;
            int step = jumpSize;
            int prev = 0;

            while (comparer.Compare(seq.data[Math.Min(step, n) - 1], target) < 0)
            {
                prev = step;
                step += jumpSize;
                if (prev >= n)
                    return -1;
            }


            while (comparer.Compare(seq.data[prev], target) < 0)
            {
                prev++;
                if (prev == Math.Min(step, n))
                    return -1; 
            }


            if (comparer.Compare(seq.data[prev], target) == 0)
                return prev;

            return -1;
        }


        public static int JumpSearchTwoLevel<T>(Sequence<T> seq, T target, int jumpSize, CountingComparer<T> comparer) where T : struct, IComparable<T>
        {
            int n = seq.len;
            int step = jumpSize;
            int prev = 0;

            while (comparer.Compare(seq.data[Math.Min(step, n) - 1], target) < 0)
            {
                prev = step;
                step += jumpSize;
                if (prev >= n)
                    return -1;
            }
            
            jumpSize = (int)Math.Sqrt(jumpSize);

            while (comparer.Compare(seq.data[Math.Max(step, 1) - 1], target) >= 0)
            {
                prev = step;
                step -= jumpSize;
                if (prev < 0)
                    return -1;
            }

            while (comparer.Compare(seq.data[prev], target) < 0)
            {
                prev--;
                if (prev == Math.Max(step, 0))
                    return -1;
            }

            if (comparer.Compare(seq.data[prev], target) == 0)
                return prev;

            return -1;
        }

        public static int BinarySearch<T>(Sequence<T> seq, T target, CountingComparer<T> comparer) where T : struct, IComparable<T>
        {
            int left = 0;
            int right = seq.len - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (comparer.Compare(seq.data[mid], target) == 0)
                    return mid; 

                if (comparer.Compare(seq.data[mid], target) < 0)
                    left = mid + 1; 
                else
                    right = mid - 1;
            }

            return -1;
        }
    }
}
