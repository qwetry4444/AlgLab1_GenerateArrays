using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateSequence
{
    public static class Sorter
    {
        // Метод для сортировки вставками
        public static void InsertionSort<T>(Sequence<T> sequence, int minValue = 0, int maxValue = 100) where T : struct, IComparable<T>
        {
            for (int i = 1; i < sequence.len; i++)
            {
                T key = sequence.data[i];
                int j = i - 1;

                while (j >= 0 && sequence.data[j].CompareTo(key) > 0)
                {
                    sequence.data[j + 1] = sequence.data[j];
                    j--;
                }

                sequence.data[j + 1] = key;
            }
        }

        // Метод для сортировки подсчётом
        public static void CountingSort<T>(Sequence<T> sequence, int minValue = 0, int maxValue = 100) where T : struct, IComparable<T>
        {
            int[] counts = new int[maxValue - minValue + 1];

            for (int i = 0; i < sequence.len; i++)
            {
                counts[Convert.ToInt32(sequence.data[i]) - minValue]++;
            }

            int index = 0;
            for (int i = minValue; i <= maxValue; i++)
            {
                for (int j = 0; j < counts[i - minValue]; j++)
                {
                    sequence.data[index++] = (T)(object)i;
                }
            }
        }

        public static void QuickSortWithMedian<T>(Sequence<T> sequence) where T : struct, IComparable<T>
        {
            if (sequence == null || sequence.data == null || sequence.len <= 1)
                return;

            QuickSortWithMedian(sequence.data, 0, sequence.len - 1);
        }

        private static void QuickSortWithMedian<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            if (left < right)
            {
                T pivot = MedianOfThree(array, left, right);
                int partitionIndex = Partition(array, left, right, pivot);
                QuickSortWithMedian(array, left, partitionIndex - 1);
                QuickSortWithMedian(array, partitionIndex + 1, right);
            }
        }

        private static T MedianOfThree<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            int mid = (left + right) / 2;
            if (array[left].CompareTo(array[mid]) > 0)
                Swap(array, left, mid);
            if (array[left].CompareTo(array[right]) > 0)
                Swap(array, left, right);
            if (array[mid].CompareTo(array[right]) > 0)
                Swap(array, mid, right);
            return array[mid];
        }

        private static int Partition<T>(T[] array, int left, int right, T pivot) where T : IComparable<T>
        {
            int i = left - 1;
            int j = right + 1;

            while (true)
            {
                do
                {
                    i++;
                } while (array[i].CompareTo(pivot) < 0);

                do
                {
                    j--;
                } while (array[j].CompareTo(pivot) > 0);

                if (i >= j)
                    return j;

                Swap(array, i, j);
            }
        }

        private static void Swap<T>(T[] array, int i, int j)
        {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }


        public static void ModifiedInsertionSort<T>(Sequence<T> sequence, int minValue = 0, int maxValue = 100) where T : struct, IComparable<T>
        {
            if (sequence.data == null || sequence.len <= 1)
                return;

            // Вставляем сигнальный ключ в начало массива
            T signalKey = sequence.data[0];
            int j = 0;

            // Находим позицию для вставки сигнального ключа
            for (int i = 1; i < sequence.len; i++)
            {
                if (sequence.data[i].CompareTo(signalKey) < 0)
                {
                    signalKey = sequence.data[i];
                    j = i;
                }
            }

            // Вставляем сигнальный ключ
            sequence.data[j] = sequence.data[0];
            sequence.data[0] = signalKey;

            // Производим сортировку вставками, начиная со второго элемента
            for (int i = 2; i < sequence.len; i++)
            {
                T key = sequence.data[i];
                int k = i - 1;

                while (key.CompareTo(sequence.data[k]) < 0)
                {
                    sequence.data[k + 1] = sequence.data[k];
                    k--;
                }

                sequence.data[k + 1] = key;
            }
        }
    }
}
