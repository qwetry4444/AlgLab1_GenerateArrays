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
            int[] sizes = { (int)5e3, (int)10e3, (int)15e3, (int)20e3, (int)25e3, (int)30e3, (int)35e3, (int)40e3, (int)45e3, (int)50e3 };

            Console.WriteLine("Sort Unordered sequence:");
            PerformanceAnalysis.GetSortTimes(sizes, SequenceType.UnOrdered, SortType.Insertion);

            Console.WriteLine("Sort Ordered sequence:");
            PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Ordered, SortType., direction:Direction.decreasing);

            Console.WriteLine("Sort Ordered decreasing sequence:");
            PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Ordered, SortType.Insertion);

            Console.WriteLine("Sort Step sequence:");
            PerformanceAnalysis.GetSortTimes(sizes, SequenceType.Step, SortType.Insertion);


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
