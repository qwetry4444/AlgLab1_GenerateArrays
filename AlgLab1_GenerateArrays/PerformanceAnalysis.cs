using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        Generator.GetOrderedSequence(seq, direction: direction);
                        break;
                    case SequenceType.UnOrdered:
                        Generator.GetUnorderedSequence(seq);
                        break;

                    case SequenceType.Sawtooth:
                        Generator.GetSawtoothSequence(seq, partLen: 3, direction: direction);
                        break;
                    case SequenceType.Sinusoidal:
                        Generator.GetSinusoidalSequence(seq, partLen: 3);
                        break;
                    case SequenceType.Step:
                        Generator.GetStepSequence(seq, partLen: 3, direction: direction);
                        break;
                    case SequenceType.Quasi:
                        Generator.GetQuasiSequence(seq, direction: direction);
                        break;
                }
                stopwatch.Stop();
                Console.WriteLine($"Sequence size: {size}, Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
            }
            Console.WriteLine();
        }
    }
}
