using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateSequence
{
    public static class Search
    {
        public static int SequentialSearch(T[] array, T target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(target))
                    return i; // Возвращаем индекс найденного элемента
            }
            return -1; // Элемент не найден
        }

        public static int JumpSearch(T[] array, T target, int jumpSize)
        {
            int n = array.Length;
            int step = jumpSize;

            // Найти блок, в котором может находиться целевой элемент
            int prev = 0;
            while (array[Math.Min(step, n) - 1].CompareTo(target) < 0)
            {
                prev = step;
                step += jumpSize;
                if (prev >= n)
                    return -1; // Элемент не найден
            }

            // Выполнить линейный поиск в найденном блоке
            while (array[prev].CompareTo(target) < 0)
            {
                prev++;
                if (prev == Math.Min(step, n))
                    return -1; // Элемент не найден
            }

            // Если целевой элемент найден, вернуть его индекс
            if (array[prev].Equals(target))
                return prev;

            return -1; // Элемент не найден
        }

        public static int BinarySearch(T[] array, T target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (array[mid].Equals(target))
                    return mid; // Возвращаем индекс найденного элемента

                if (array[mid].CompareTo(target) < 0)
                    left = mid + 1; // Перемещаем левую границу вправо
                else
                    right = mid - 1; // Перемещаем правую границу влево
            }

            return -1; // Элемент не найден
        }
    }
}
