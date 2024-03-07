using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace GenerateSequence
{
    internal static class Generator
    {
        public static void GetUnorderedSequence(Sequence sequence, int minValue=0, int maxValue=100) 
        {
            Random rnd = new Random();
            for (int i = 0; i < sequence.len; i++)
            {
                sequence.data[i] = rnd.Next(minValue, maxValue);
            }
        }

        public static void GetOrderedSequence(Sequence sequence, int minValue = 0, int maxValue = 100, Direction direction = Direction.increasing )
        {
            switch(direction)
            {
                case Direction.increasing:
                {
                    for (int i = 0; i < sequence.len; i++)
                    {
                        sequence.data[i] = i;
                    }
                    break;
                }
                case Direction.decreasing:
                {
                    for (int i = sequence.len; i > 0; i--)
                    {
                        sequence.data[sequence.len - i] = i;
                    }
                    break;
                }
            } 
        }

        public static void GetPartiallyOrderedSequence(Sequence sequence, int partLen = 1, int minValue = 0, int maxValue = 100, Direction direction = Direction.increasing)
        {
            switch(direction)
            {
                case Direction.increasing:
                {
                    for (int partNumber = 0; partNumber < sequence.len / partLen; partNumber++)
                    {
                        for (int i = 0; i < partLen; i++)
                        {
                            sequence.data[partNumber * partLen + i] = i;
                        }
                    }
                    break;
                }
                case Direction.decreasing:
                {
                    for (int partNumber = 0; partNumber < sequence.len / partLen; partNumber++)
                    {
                        for (int i = partLen; i > 0; i--)
                        {
                            sequence.data[partNumber * partLen - i] = i;
                        }
                    }
                    break;
                }
            }
        }
    }
}
