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

            //Console.WriteLine("Sort Insertion:");
            //Console.WriteLine("Sort Unordered sequence:");
            //PerformanceAnalysis.GetSortTimes(sizes, SequenceType.UnOrdered, SortType.Insertion);
            //PerformanceAnalysis.GetCountsComparisons<int>(sizes, SequenceType.UnOrdered, SortType.Insertion);

            //Console.WriteLine("Sort Ordered sequence:");
            //PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Ordered, SortType.Insertion, direction: Direction.decreasing);
            //PerformanceAnalysis.GetCountsComparisons<int>(sizes, SequenceType.Ordered, SortType.Insertion, direction: Direction.decreasing);

            //Console.WriteLine("Sort Ordered decreasing sequence:");
            //PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Ordered, SortType.Insertion, direction: Direction.increasing);
            //PerformanceAnalysis.GetCountsComparisons<int>(sizes, SequenceType.Ordered, SortType.Insertion, direction: Direction.increasing);

            //Console.WriteLine("Sort Step sequence:");
            //PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Step, SortType.Insertion);
            //PerformanceAnalysis.GetCountsComparisons<int>(sizes, SequenceType.Step, SortType.Insertion);

            //Console.WriteLine("Sort ModifiedInsertion:");
            //Console.WriteLine("Sort Unordered sequence:");
            //PerformanceAnalysis.GetSortTimes(sizes, SequenceType.UnOrdered, SortType.ModifiedInsertion);
            //PerformanceAnalysis.GetCountsComparisons<int>(sizes, SequenceType.UnOrdered, SortType.ModifiedInsertion);

            //Console.WriteLine("Sort Ordered sequence:");
            //PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Ordered, SortType.ModifiedInsertion, direction: Direction.decreasing);
            //PerformanceAnalysis.GetCountsComparisons<int>(sizes, SequenceType.Ordered, SortType.ModifiedInsertion, direction: Direction.decreasing);

            //Console.WriteLine("Sort Ordered decreasing sequence:");
            //PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Ordered, SortType.ModifiedInsertion, direction: Direction.increasing);
            //PerformanceAnalysis.GetCountsComparisons<int>(sizes, SequenceType.Ordered, SortType.ModifiedInsertion, direction: Direction.increasing);

            //Console.WriteLine("Sort Step sequence:");
            //PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Step, SortType.ModifiedInsertion);
            //PerformanceAnalysis.GetCountsComparisons<int>(sizes, SequenceType.Step, SortType.ModifiedInsertion);

            Console.WriteLine("Sort Counting:");
            Console.WriteLine("Sort Unordered sequence:");
            PerformanceAnalysis.GetSortTimes(sizes, SequenceType.UnOrdered, SortType.Counting);
            PerformanceAnalysis.GetCountsComparisons<int>(sizes, SequenceType.UnOrdered, SortType.Counting);

            Console.WriteLine("Sort Ordered sequence:");
            PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Ordered, SortType.Counting, direction: Direction.decreasing);
            PerformanceAnalysis.GetCountsComparisons<int>(sizes, SequenceType.Ordered, SortType.Counting, direction: Direction.decreasing);

            Console.WriteLine("Sort Ordered decreasing sequence:");
            PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Ordered, SortType.Counting, direction: Direction.increasing);
            PerformanceAnalysis.GetCountsComparisons<int>(sizes, SequenceType.Ordered, SortType.Counting, direction: Direction.increasing);

            Console.WriteLine("Sort Step sequence:");
            PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Step, SortType.Counting);
            PerformanceAnalysis.GetCountsComparisons<int>(sizes, SequenceType.Step, SortType.Counting);




            //Console.WriteLine("Sort QuickWithMedian:");
            //Console.WriteLine("Sort Unordered sequence:");
            //PerformanceAnalysis.GetSortTimes(sizes, SequenceType.UnOrdered, SortType.QuickWithMedian);
            //PerformanceAnalysis.GetCountsComparisons<int>(sizes, SequenceType.UnOrdered, SortType.QuickWithMedian);

            //Console.WriteLine("Sort Ordered sequence:");
            //PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Ordered, SortType.QuickWithMedian, direction: Direction.decreasing);
            //PerformanceAnalysis.GetCountsComparisons<int>(sizes, SequenceType.Ordered, SortType.QuickWithMedian, direction: Direction.decreasing);

            //Console.WriteLine("Sort Ordered decreasing sequence:");
            //PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Ordered, SortType.QuickWithMedian, direction: Direction.increasing);
            //PerformanceAnalysis.GetCountsComparisons<int>(sizes, SequenceType.Ordered, SortType.QuickWithMedian, direction: Direction.increasing);

            //Console.WriteLine("Sort Step sequence:");
            //PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Step, SortType.QuickWithMedian);
            //PerformanceAnalysis.GetCountsComparisons<int>(sizes, SequenceType.Step, SortType.QuickWithMedian);







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
