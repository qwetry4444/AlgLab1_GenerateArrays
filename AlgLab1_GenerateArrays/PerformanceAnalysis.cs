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
                Sequence arr = new Sequence(size, 0);

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                switch(sequenceType)
                {
                    case SequenceType.Ordered:
                        Generator.GetOrderedSequence(arr, direction: direction);
                        break;

                    case SequenceType.PartOrdered:
                        Generator.GetPartiallyOrderedSequence(arr, partLen: 3, direction: direction);
                        break;

                    case SequenceType.UnOrdered:
                        Generator.GetUnorderedSequence(arr);
                        break;
                }
                stopwatch.Stop();
                Console.WriteLine($"Sequence size: {size}, Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
            }
            Console.WriteLine();
        }
    }
}
