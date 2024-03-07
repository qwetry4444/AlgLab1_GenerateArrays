using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenerateSequence
{
    public class Sequence
    {
        public int len;
        public int[] data;
        public SequenceType seqType;

        public Sequence()
        {
            GetLenSeq();
            data = new int[len];
            GetSeqType();

            switch (seqType)
            {
                case SequenceType.UnOrdered:
                    Generator.GetUnorderedSequence(this);
                    break;
                case SequenceType.Ordered:
                    Generator.GetOrderedSequence(this);
                    break;
                case SequenceType.Sawtooth:
                    Generator.GetSawtoothSequence(this);
                    break;
                case SequenceType.Sinusoidal:
                    Generator.GetSinusoidalSequence(this);
                    break;
                case SequenceType.Step:
                    Generator.GetStepSequence(this);
                    break;
                case SequenceType.Quasi:
                    Generator.GetQuasiSequence(this);
                    break;
            }
        }

        public Sequence(int len, SequenceType seqType)
        {
            this.len = len;
            data = new int[len];
            this.seqType = seqType;
            //switch (seqType)
            //{
            //    case SequenceType.UnOrdered:
            //        Generator.GetUnorderedSequence(this);
            //        break;
            //    case SequenceType.Ordered:
            //        Generator.GetOrderedSequence(this);
            //        break;
            //    case SequenceType.Sawtooth:
            //        Generator.GetSawtoothSequence(this);
            //        break;
            //    case SequenceType.Sinusoidal:
            //        Generator.GetSinusoidalSequence(this);
            //        break;
            //    case SequenceType.Step:
            //        Generator.GetStepSequence(this);
            //        break;
            //    case SequenceType.Quasi:
            //        Generator.GetQuasiSequence(this);
            //        break;
            //}
        }

        public void GetLenSeq()
        {
            Console.Write("Введите длину последовательности: ");
            len = Convert.ToInt32(Console.ReadLine());
        }

        public void GetSeqType()
        {
            Console.WriteLine("Выберите тип последовательности:\n 1 - Упорядоченная\n 2 - Случайная\n 3 - Пилообразная\n 4 - Синусоидальная\n 5 - Ступенчатая\n 6 - Квази-упорядоченная");
            Console.Write("Тип: ");
            seqType = (SequenceType)(Convert.ToInt32(Console.ReadLine()) - 1);
        }

        public void Print()
        {
            Console.WriteLine("Sequence: ");
            Console.Write("[");
            Console.Write(String.Join(", ", data));
            Console.WriteLine("]");
        }
    }
}
