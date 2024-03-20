using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace GenerateSequence
{
    public static class Generator
    {
        // Методы генерации последовательностей целых чисел
        public static void GetUnorderedSequence(Sequence<int> sequence, int minValue = 0, int maxValue = 100)
        {
            Random rnd = new Random();
            for (int i = 0; i < sequence.len; i++)
            {
                sequence.data[i] = rnd.Next((int)minValue, (int)maxValue);
            }
        }

        public static void GetOrderedSequence(Sequence<int> sequence, int minValue = 0, int maxValue = 100, Direction direction = Direction.increasing)
        {
            switch (direction)
            {
                case Direction.increasing:
                    {
                        for (int i = 0; i < sequence.len; i++)
                        {
                            sequence.data[i] = (maxValue - i < minValue) ? minValue : maxValue - i;
                        }
                        break;
                    }
                case Direction.decreasing:
                    {
                        for (int i = sequence.len - 1; i >= 0; i--)
                        {
                            sequence.data[sequence.len - i - 1] = (maxValue - i < minValue) ? minValue : maxValue - i;
                        }
                        break;
                    }
            }
        }

        public static void GetSawtoothSequence(Sequence<int> sequence, int partLen = 1, int minValue = 0, int maxValue = 100, Direction direction = Direction.increasing)
        {
            switch (direction)
            {
                case Direction.increasing:
                    {
                        for (int partNumber = 0; partNumber < sequence.len / partLen; partNumber++)
                        {
                            for (int i = 0; i < partLen; i++)
                            {
                                sequence.data[partNumber * partLen + i] = minValue + i > maxValue ? maxValue : minValue + i;
                            }
                        }
                        break;
                    }
                case Direction.decreasing:
                    {
                        for (int partNumber = 0; partNumber < sequence.len / partLen; partNumber++)
                        {
                            for (int i = 0; i < partLen; i++)
                            {
                                sequence.data[partNumber * partLen + i] = maxValue - i < minValue ? minValue : maxValue - i;
                            }
                        }
                        break;
                    }
            }
        }

        public static void GetSinusoidalSequence(Sequence<int> sequence, int partLen = 1, int minValue = 0, int maxValue = 100)
        {
            for (int partNumber = 0; partNumber < sequence.len / partLen; partNumber++)
            {
                for (int i = 0; i < partLen; i++)
                {
                    sequence.data[partNumber * partLen + i] = minValue + Convert.ToInt32(Math.Abs(Math.Sin((double)i / partLen * Math.PI - Math.PI / 2)) * (maxValue - minValue));
                }
            }
        }

        public static void GetStepSequence(Sequence<int> sequence, int partLen = 1, int minValue = 0, int maxValue = 100, Direction direction = Direction.increasing)
        {
            int countPart = sequence.len / partLen;
            double step = 1 + (maxValue - minValue) / countPart;
            Random rnd = new Random();

            int tmp;

            switch (direction)
            {
                case Direction.increasing:
                    {
                        for (int partNumber = 0; partNumber < countPart; partNumber++)
                        {
                            for (int i = 0; i < partLen; i++)
                            {
                                tmp = (int)((partNumber + 1) * step + rnd.Next((int)(-1 + -step / 5), (int)(1 + step / 5)));
                                if (tmp > maxValue) tmp = maxValue;
                                sequence.data[partNumber * partLen + i] = tmp;
                            }
                        }

                        break;
                    }

                case Direction.decreasing:
                    {
                        for (int partNumber = countPart; partNumber > 0; partNumber--)
                        {
                            for (int i = 0; i < partLen; i++)
                            {
                                tmp = (int)((partNumber) * step + rnd.Next((int)(-step / 5), (int)(step / 5)));
                                if (tmp < minValue) tmp = minValue;
                                sequence.data[i] = tmp;
                            }
                        }
                        break;
                    }
            }
        }

        public static void GetQuasiSequence(Sequence<int> sequence, int minValue = 0, int maxValue = 100, Direction direction = Direction.increasing)
        {
            GetOrderedSequence(sequence, minValue, maxValue, direction);
            int inversionsCount = sequence.len / 100;
            for (int i = 0; i < inversionsCount; i++)
            {
                (sequence.data[i], sequence.data[sequence.len - i - 1]) = (sequence.data[sequence.len - i - 1], sequence.data[i]);
            }
        }

        // Методы генерации последовательностей чисел с плавающей точкой
        public static void GetUnorderedSequence(Sequence<double> sequence, double minValue = 0, double maxValue = 100)
        {
            Random rnd = new Random();
            for (int i = 0; i < sequence.len; i++)
            {
                sequence.data[i] = minValue + (maxValue - minValue) * rnd.NextDouble();
            }
        }

        public static void GetOrderedSequence(Sequence<double> sequence, double minValue = 0, double maxValue = 100, Direction direction = Direction.increasing)
        {
            switch (direction)
            {
                case Direction.increasing:
                    {
                        for (int i = 0; i < sequence.len; i++)
                        {
                            sequence.data[i] = minValue + ((double)i / (sequence.len - 1)) * (maxValue - minValue);
                        }
                        break;
                    }
                case Direction.decreasing:
                    {
                        for (int i = sequence.len - 1; i >= 0; i--)
                        {
                            sequence.data[i] = minValue + ((double)(sequence.len - 1 - i) / (sequence.len - 1)) * (maxValue - minValue);
                        }
                        break;
                    }
            }
        }

        public static void GetSawtoothSequence(Sequence<double> sequence, int partLen = 1, double minValue = 0, double maxValue = 100, Direction direction = Direction.increasing)
        {
            switch (direction)
            {
                case Direction.increasing:
                    {
                        for (int partNumber = 0; partNumber < sequence.len / partLen; partNumber++)
                        {
                            for (int i = 0; i < partLen; i++)
                            {
                                sequence.data[partNumber * partLen + i] = minValue + i > maxValue ? maxValue : minValue + i;
                            }
                        }
                        break;
                    }
                case Direction.decreasing:
                    {
                        for (int partNumber = 0; partNumber < sequence.len / partLen; partNumber++)
                        {
                            for (int i = 0; i < partLen; i++)
                            {
                                sequence.data[partNumber * partLen + i] = maxValue - i < minValue ? minValue : maxValue - i;
                            }
                        }
                        break;
                    }
            }
        }

        public static void GetSinusoidalSequence(Sequence<double> sequence, int partLen = 1, double minValue = 0, double maxValue = 100)
        {
            for (int partNumber = 0; partNumber < sequence.len / partLen; partNumber++)
            {
                for (int i = 0; i < partLen; i++)
                {
                    sequence.data[partNumber * partLen + i] = minValue + Math.Abs(Math.Sin((double)i / partLen * Math.PI - Math.PI / 2)) * (maxValue - minValue);
                }
            }
        }

        public static void GetStepSequence(Sequence<double> sequence, int partLen = 1, double minValue = 0, double maxValue = 100, Direction direction = Direction.increasing)
        {
            int countPart = sequence.len / partLen;
            double step = (maxValue - minValue) / countPart;
            Random rnd = new Random();

            double tmp;

            switch (direction)
            {
                case Direction.increasing:
                    {
                        for (int partNumber = 0; partNumber < countPart; partNumber++)
                        {
                            for (int i = 0; i < partLen; i++)
                            {
                                tmp = (double)((partNumber + 1) * step + rnd.NextDouble() * step);
                                if (tmp > maxValue) tmp = maxValue;
                                sequence.data[i] = tmp;
                            }
                        }
                        break;
                    }

                case Direction.decreasing:
                    {
                        for (int partNumber = countPart; partNumber > 0; partNumber--)
                        {
                            for (int i = 0; i < partLen; i++)
                            {
                                tmp = (double)((partNumber) * step + rnd.NextDouble() * step);
                                if (tmp < minValue) tmp = minValue;
                                sequence.data[i] = tmp;
                            }
                        }
                        break;
                    }
            }
        }
        
        public static void GetQuasiSequence(Sequence<double> sequence, double minValue = 0, double maxValue = 100, Direction direction = Direction.increasing)
        {
            GetOrderedSequence(sequence, minValue, maxValue, direction);
            int inversionsCount = sequence.len / 100;
            for (int i = 0; i < inversionsCount; i++)
            {
                (sequence.data[i], sequence.data[sequence.len - i - 1]) = (sequence.data[sequence.len - i - 1], sequence.data[i]);
            }
        }
    }
}
