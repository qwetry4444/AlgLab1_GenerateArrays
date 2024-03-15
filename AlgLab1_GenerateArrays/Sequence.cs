using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenerateSequence
{
    public class Sequence<T> where T : struct
    {
        public int len;
        public T[] data;
        public SequenceType seqType;

        public Sequence()
        {
            GetLenSeq();
            data = new T[len];
            GetSeqType();
        }

        public Sequence(int len, SequenceType seqType)
        {
            this.len = len;
            data = new T[len];
            this.seqType = seqType;
        }

  
        public void GetLenSeq()
        {
            Console.Write("Enter the length of the sequence: ");
            len = Convert.ToInt32(Console.ReadLine());
        }


        public void GetSeqType()
        {
            Console.WriteLine("Choose the sequence type:\n 1 - Ordered\n 2 - Unordered\n 3 - Sawtooth\n 4 - Sinusoidal\n 5 - Step\n 6 - Quasi");
            Console.Write("Type: ");
            seqType = (SequenceType)(Convert.ToInt32(Console.ReadLine()) - 1);
        }

        public void Print()
        {
            Console.WriteLine("Sequence: ");
            Console.Write("[");
            Console.Write(string.Join(", ", data));
            Console.WriteLine("]");
        }
    }
}
