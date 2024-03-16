using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateSequence
{
    public enum Direction
    {
        increasing,
        decreasing,
    }

    public enum SequenceType
    {
        Ordered,
        UnOrdered,
        Sawtooth,
        Sinusoidal,
        Step,
        Quasi,
    }

    public enum SortType
    {
        Insertion,
        Counting,
        QuickWithMedian,
        ModifiedInsertion,
    }
}
