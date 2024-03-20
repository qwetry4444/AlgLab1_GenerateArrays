using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GenerateSequence.PerformanceAnalysis;

namespace GenerateSequence
{
    public static class PerformanceAnalysis
    {
        public static void GetGenerateTimes(int[] sizes, SequenceType sequenceType, Direction direction = Direction.increasing)
        {
            foreach (int size in sizes)
            {
                Sequence<double> seq = new Sequence<double>(size, sequenceType);

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                switch(sequenceType)
                {
                    case SequenceType.Ordered:
                        Generator.GetOrderedSequence(seq, direction: direction, maxValue: seq.len);
                        break;
                    case SequenceType.UnOrdered:
                        Generator.GetUnorderedSequence(seq, maxValue: seq.len);
                        break;

                    case SequenceType.Sawtooth:
                        Generator.GetSawtoothSequence(seq, partLen: 3, direction: direction, maxValue: seq.len);
                        break;
                    case SequenceType.Sinusoidal:
                        Generator.GetSinusoidalSequence(seq, partLen: 3, maxValue: seq.len);
                        break;
                    case SequenceType.Step:
                        Generator.GetStepSequence(seq, partLen: 3, direction: direction, maxValue: seq.len);
                        break;
                    case SequenceType.Quasi:
                        Generator.GetQuasiSequence(seq, direction: direction, maxValue: seq.len);
                        break;
                }
                stopwatch.Stop();
                Console.WriteLine($"Sequence size: {size}, Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
            }
            Console.WriteLine();
        }

        public static void GetSortTimes(int[] sizes, SequenceType sequenceType, SortType sortType, Direction direction = Direction.increasing)
        {
            foreach (int size in sizes)
            {
                Sequence<int> seq = new Sequence<int>(size, sequenceType);
                
                switch (sequenceType)
                {
                    case SequenceType.Ordered:
                        Generator.GetOrderedSequence(seq, direction:direction, maxValue: seq.len);
                        break;
                    case SequenceType.UnOrdered:
                        Generator.GetUnorderedSequence(seq, maxValue: seq.len);
                        break;
                    case SequenceType.Sawtooth:
                        Generator.GetSawtoothSequence(seq, partLen: seq.len / 20, maxValue: seq.len);
                        break;
                    case SequenceType.Sinusoidal:
                        Generator.GetSinusoidalSequence(seq, partLen: seq.len / 20, maxValue: seq.len);
                        break;
                    case SequenceType.Step:
                        Generator.GetStepSequence(seq, partLen: seq.len / 20, maxValue: seq.len);
                        break;
                    case SequenceType.Quasi:
                        Generator.GetQuasiSequence(seq, maxValue:seq.len);
                        break;
                }
                //seq.Print();
                GetSortTime(seq, sortType, size);
            }
            Console.WriteLine();
        }

        public static void GetSortTime(Sequence<int> sequence, SortType sortType, int size)
        {
            SortingCountingComparer<int> comparer = new SortingCountingComparer<int>();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //sequence.Print();

            switch (sortType)
            {
                case SortType.Counting:
                    Sorter.CountingSort(sequence, comparer, maxValue: sequence.len);
                    break;

                case SortType.Insertion:
                    Sorter.InsertionSort(sequence, comparer);
                    break;

                case SortType.ModifiedInsertion:
                    Sorter.ModifiedInsertionSort(sequence, comparer);
                    break;

                case SortType.QuickWithMedian:
                    Sorter.QuickSortWithMedian(sequence, comparer);
                    break;
            }
            //sequence.Print();

            stopwatch.Stop();
            Console.WriteLine($"Sequence size: {size}, Sort time: {stopwatch.ElapsedMilliseconds} ms");
        }

        public static void GetCountsComparisons<T>(int[] sizes, SequenceType sequenceType, SortType sortType, Direction direction = Direction.increasing)
        {
            foreach (int size in sizes)
            {
                Sequence<int> seq = new Sequence<int>(size, sequenceType);

                switch (sequenceType)
                {
                    case SequenceType.Ordered:
                        Generator.GetOrderedSequence(seq, direction: direction, maxValue: seq.len);
                        break;
                    case SequenceType.UnOrdered:
                        Generator.GetUnorderedSequence(seq, maxValue: seq.len);
                        break;
                    case SequenceType.Sawtooth:
                        Generator.GetSawtoothSequence(seq, partLen: seq.len / 20, maxValue: seq.len);
                        break;
                    case SequenceType.Sinusoidal:
                        Generator.GetSinusoidalSequence(seq, partLen: seq.len / 20, maxValue: seq.len);
                        break;
                    case SequenceType.Step:
                        Generator.GetStepSequence(seq, partLen: seq.len / 20, maxValue: seq.len);
                        break;
                    case SequenceType.Quasi:
                        Generator.GetQuasiSequence(seq, maxValue: seq.len);
                        break;
                }
                //seq.Print();
                GetCountComparisons<int>(seq, sortType, size);
            }
            Console.WriteLine();
        }

        public static long GetCountComparisons<T>(Sequence<int> sequence, SortType sortType, int size) where T : IComparable<T>
        {

            // Запускаем сортировку на тестовом массиве, но перехватываем сравнения
            long comparisons = 0;
            Action<Sequence<int>> countingSortingAlgorithm = (seq) =>
            {
                SortingCountingComparer<int> comparer = new SortingCountingComparer<int>();
                comparer.Comparison += () => comparisons++;
                switch (sortType)
                    {
                        case SortType.Counting:
                            Sorter.CountingSort(seq, comparer, maxValue: seq.len);
                            break;

                        case SortType.Insertion:
                            Sorter.InsertionSort(seq, comparer);
                            break;

                        case SortType.ModifiedInsertion:
                            Sorter.ModifiedInsertionSort(seq, comparer);
                            break;

                        case SortType.QuickWithMedian:
                            Sorter.QuickSortWithMedian(seq, comparer);
                            break;
                    }   
            };

            countingSortingAlgorithm(sequence);
            Console.WriteLine($"Sequence size: {size}, Count Comparisons: {comparisons}");
            return comparisons;
        }

        // Для подсчета операций сравнения в сортировке
        public class SortingCountingComparer<T> : IComparer<T> where T : IComparable<T>
        {
            public event Action Comparison;

            public int Compare(T x, T y)
            {
                Comparison?.Invoke();
                return x.CompareTo(y);
            }
        }
    }
}
