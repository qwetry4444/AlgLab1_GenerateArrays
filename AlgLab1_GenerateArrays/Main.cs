using System;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace GenerateSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = { (int)5e5, (int)10e5, (int)15e5, (int)20e5, (int)25e5, (int)30e5, (int)35e5, (int)40e5, (int)45e5, (int)50e5 };

            Console.WriteLine("Generate Unordered sequence:");
            PerformanceAnalysis.GetGenerateTimes(sizes, SequenceType.UnOrdered);

            Console.WriteLine("Generate Ordered sequence:");
            PerformanceAnalysis.GetGenerateTimes(sizes, SequenceType.Ordered);

            Console.WriteLine("Generate Reverse Ordered sequence:");
            PerformanceAnalysis.GetGenerateTimes(sizes, SequenceType.Ordered, Direction.decreasing);

            Console.WriteLine("Generate Partordered sequence:");
            PerformanceAnalysis.GetGenerateTimes(sizes, SequenceType.PartOrdered);

            Console.WriteLine("Generate Reverse Partordered sequence:");
            PerformanceAnalysis.GetGenerateTimes(sizes, SequenceType.PartOrdered, Direction.decreasing);
        }
    }
}
