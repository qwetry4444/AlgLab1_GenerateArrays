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
        public SequenceType arrType;

        public Sequence()
        {
            GetLenSeq();
            data = new int[len];
            GetSeqType();

            switch (arrType)
            {
                case SequenceType.UnOrdered:
                    Generator.GetUnorderedSequence(this);
                    break;
                case SequenceType.Ordered:
                    Generator.GetOrderedSequence(this);
                    break;
                case SequenceType.PartOrdered:
                    Generator.GetPartiallyOrderedSequence(this);
                    break;
            }
        }

        public Sequence(int len, SequenceType arrType)
        {
            this.len = len;
            data = new int[len];
            this.arrType = arrType;
            switch (arrType)
            {
                case SequenceType.UnOrdered:
                    Generator.GetUnorderedSequence(this);
                    break;
                case SequenceType.Ordered:
                    Generator.GetOrderedSequence(this);
                    break;
                case SequenceType.PartOrdered:
                    Generator.GetPartiallyOrderedSequence(this);
                    break;
            }
        }

        public void GetLenSeq()
        {
            Console.Write("Введите длину последовательности: ");
            len = Convert.ToInt32(Console.ReadLine());
        }

        public void GetSeqType()
        {
            Console.WriteLine("Выберите тип последовательности:\n 1 - Упорядоченная\n 2 - Частично упорядоченная\n 3 - Случайная");
            Console.Write("Тип: ");
            arrType = (SequenceType)(Convert.ToInt32(Console.ReadLine()) - 1);
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
