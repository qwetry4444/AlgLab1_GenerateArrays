using System;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Drawing;

namespace GenerateSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] sizes = { (int)10e5, (int)15e5, (int)20e5, (int)25e5, (int)30e5, (int)35e5, (int)40e5, (int)45e5, (int)50e5 };
            //int[] sizes = { 500 };




            //ЛБ3
            //Console.WriteLine("Последовательный поиск: ");
            //Console.WriteLine("Успешный поиск:");
            //PerformanceAnalysis.GetCountComparisonsSearchMany<int>(sizes, SearchType.LinerSearch, true);
            //Console.WriteLine("Неуспешный поиск:");
            //PerformanceAnalysis.GetCountComparisonsSearchMany<int>(sizes, SearchType.LinerSearch, false);

            //Console.WriteLine("\n\nБинарный поиск: ");
            //Console.WriteLine("Успешный поиск:");
            //PerformanceAnalysis.GetCountComparisonsSearchMany<int>(sizes, SearchType.BinarySearch, true);
            //Console.WriteLine("Неуспешный поиск:");
            //PerformanceAnalysis.GetCountComparisonsSearchMany<int>(sizes, SearchType.BinarySearch, false);


            //Console.WriteLine("\n\nОдноуровневый поиск прыжками: ");
            //Console.WriteLine("Успешный поиск:");
            //PerformanceAnalysis.GetCountComparisonsSearchMany<int>(sizes, SearchType.JumpSearch, true);
            //Console.WriteLine("Неуспешный поиск:");
            //PerformanceAnalysis.GetCountComparisonsSearchMany<int>(sizes, SearchType.JumpSearch, false);

            //Console.WriteLine("\n\nДвухуровневый поиск прыжками: ");
            //Console.WriteLine("Успешный поиск:");
            //PerformanceAnalysis.GetCountComparisonsSearchMany<int>(sizes, SearchType.JumpSearchTwoLevel, true);
            //Console.WriteLine("Неуспешный поиск:");
            //PerformanceAnalysis.GetCountComparisonsSearchMany<int>(sizes, SearchType.JumpSearchTwoLevel, false);

            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[0], sizes[0] / 2);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[0], sizes[0] / 3);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[0], sizes[0] / 4);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[0], sizes[0] / 5);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[0], (int)Math.Sqrt(sizes[0]));
            Console.WriteLine("\n");
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[1], sizes[1] / 2);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[1], sizes[1] / 3);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[1], sizes[1] / 4);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[1], sizes[1] / 5);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[1], (int)Math.Sqrt(sizes[1]));
            Console.WriteLine("\n");

            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[2], sizes[2] / 2);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[2], sizes[2] / 3);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[2], sizes[2] / 4);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[2], sizes[2] / 5);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[2], (int)Math.Sqrt(sizes[2]));
            Console.WriteLine("\n");

            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[3], sizes[3] / 2);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[3], sizes[3] / 3);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[3], sizes[3] / 4);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[3], sizes[3] / 5);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[3], (int)Math.Sqrt(sizes[3]));
            Console.WriteLine("\n");

            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[4], sizes[4] / 2);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[4], sizes[4] / 3);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[4], sizes[4] / 4);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[4], sizes[4] / 5);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[4], (int)Math.Sqrt(sizes[4]));
            Console.WriteLine("\n");

            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[5], sizes[5] / 2);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[5], sizes[5] / 3);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[5], sizes[5] / 4);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[5], sizes[5] / 5);
            PerformanceAnalysis.GetCountComparisonsSearchByJump(sizes[5], (int)Math.Sqrt(sizes[5]));

            //ЛБ2
            //Console.WriteLine("Sort Insertion:");
            //Console.WriteLine("Sort Unordered sequence:");
            //PerformanceAnalysis.GetSortTimes(sizes, SequenceType.UnOrdered, SortType.Insertion);
            //PerformanceAnalysis.GetCountComparisonsSortMany<int>(sizes, SequenceType.UnOrdered, SortType.Insertion);

            //Console.WriteLine("Sort Ordered sequence:");
            //PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Ordered, SortType.Insertion, direction: Direction.decreasing);
            //PerformanceAnalysis.GetCountComparisonsSortMany<int>(sizes, SequenceType.Ordered, SortType.Insertion, direction: Direction.decreasing);

            //Console.WriteLine("Sort Ordered decreasing sequence:");
            //PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Ordered, SortType.Insertion, direction: Direction.increasing);
            //PerformanceAnalysis.GetCountComparisonsSortMany<int>(sizes, SequenceType.Ordered, SortType.Insertion, direction: Direction.increasing);

            //Console.WriteLine("Sort Step sequence:");
            //PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Step, SortType.Insertion);
            //PerformanceAnalysis.GetCountComparisonsSortMany<int>(sizes, SequenceType.Step, SortType.Insertion);



            //ЛБ1
            //Console.WriteLine("Generate Unordered sequence:");
            //PerformanceAnalysis.GetGenerateTimes(sizes, SequenceType.UnOrdered);

            //Console.WriteLine("Generate Ordered sequence:");
            //PerformanceAnalysis.GetGenerateTimes(sizes, SequenceType.Ordered);

            //Console.WriteLine("Generate Sawtooth sequence:");
            //PerformanceAnalysis.GetGenerateTimes(sizes, SequenceType.Sawtooth);

            //Console.WriteLine("Generate Sinusoidal sequence:");
            //PerformanceAnalysis.GetGenerateTimes(sizes, SequenceType.Sinusoidal);

            //Console.WriteLine("Generate Step sequence:");
            //PerformanceAnalysis.GetGenerateTimes(sizes, SequenceType.Step);

            //Console.WriteLine("Generate Quasi sequence:");
            //PerformanceAnalysis.GetGenerateTimes(sizes, SequenceType.Quasi);
        }
    }
}
