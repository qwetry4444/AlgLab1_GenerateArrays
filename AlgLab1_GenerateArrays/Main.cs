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
            int[] sizes = { (int)5e5, (int)10e5, (int)15e5, (int)20e5, (int)25e5, (int)30e5, (int)35e5, (int)40e5, (int)45e5, (int)50e5 };


            Sequence arr = new Sequence(100, SequenceType.Step);

            //Generator.GetSinusoidalSequence(arr, partLen:20);
            //arr.Print();
            Console.WriteLine("Generate Unordered sequence:");
            PerformanceAnalysis.GetGenerateTimes(sizes, SequenceType.UnOrdered);

            Console.WriteLine("Generate Ordered sequence:");
            PerformanceAnalysis.GetGenerateTimes(sizes, SequenceType.Ordered);



            Console.WriteLine("Generate Sawtooth sequence:");
            PerformanceAnalysis.GetGenerateTimes(sizes, SequenceType.Sawtooth);

            Console.WriteLine("Generate Sinusoidal sequence:");
            PerformanceAnalysis.GetGenerateTimes(sizes, SequenceType.Sinusoidal);

            Console.WriteLine("Generate Step sequence:");
            PerformanceAnalysis.GetGenerateTimes(sizes, SequenceType.Step);

            Console.WriteLine("Generate Quasi sequence:");
            PerformanceAnalysis.GetGenerateTimes(sizes, SequenceType.Quasi);
        }
    }
}
