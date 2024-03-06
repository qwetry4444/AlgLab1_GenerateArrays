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
                case SequenceType.UnSorted:
                    Generator.GetRandSequence(this);
                    break;
                case SequenceType.Sorted:
                    Generator.GetOrderedSequence(this);
                    break;
                case SequenceType.PartSorted:
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
                case SequenceType.UnSorted:
                    Generator.GetRandSequence(this);
                    break;
                case SequenceType.Sorted:
                    Generator.GetOrderedSequence(this);
                    break;
                case SequenceType.PartSorted:
                    Generator.GetPartiallyOrderedSequence(this);
                    break;
            }
        }

        ~Sequence()
        {
            
        }


        public void GetLenSeq()
        {
            Console.Write("Введите длину массива: ");
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
            Console.WriteLine("Array: ");
            Console.Write("[");
            Console.Write(String.Join(", ", data));
            Console.WriteLine("]");

        }

        //public void QuickSort(int left, int right)
        //{
        //    if (left < right)
        //    {
        //        int pivotIndex = Partiton(left, right);
        //        QuickSort(left, pivotIndex - 1);
        //        QuickSort(pivotIndex + 1, right);
        //    }
        //}

        public void QuickSort(int low, int high)
        {
            // Создаем стек для хранения границ сегментов
            Stack<int> stack = new Stack<int>();
            stack.Push(low);
            stack.Push(high);

            // Итеративная сортировка
            while (stack.Count > 0)
            {
                high = stack.Pop();
                low = stack.Pop();

                int pivotIndex = Partition(this.data, low, high);

                // Если есть элементы слева от опорного элемента, добавляем их в стек
                if (pivotIndex - 1 > low)
                {
                    stack.Push(low);
                    stack.Push(pivotIndex - 1);
                }

                // Если есть элементы справа от опорного элемента, добавляем их в стек
                if (pivotIndex + 1 < high)
                {
                    stack.Push(pivotIndex + 1);
                    stack.Push(high);
                }
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);
            return i + 1;
        }

        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

    }
}
