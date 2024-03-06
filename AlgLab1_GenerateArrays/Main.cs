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
            int[] sizes = { 10000000 };

            foreach (int size in sizes)
            {
                Sequence arr = new Sequence(size, 0);

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                Generator.GetRandSequence(arr);
                stopwatch.Stop();

                Console.WriteLine($"Sequence size: {size}, Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
            }
        }
    }
}
