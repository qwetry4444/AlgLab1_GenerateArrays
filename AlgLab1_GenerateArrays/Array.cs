using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLab1
{
    internal class Array
    {
        private int len;
        private int[] arr;
        ArrType arrType;

        Array()
        {
            GetLenArr(len);
            arr = new int[len];
            GetArrType(arrType);
        }

        ~Array()
        {
            
        }

        public enum ArrType
        {
            UnSorted = 0,
            Sorted = 1,
            PartSorted = 2
        }
        public void GetLenArr(int len)
        {
            Console.Write("Введите длину массива: ");
            len = Convert.ToInt32(Console.ReadLine());
        }

        public void GetArrType(ArrType type)
        {
            Console.Write("Выберите тип последовательности:\n 1 - Упорядоченная\n 2 - Частично упорядоченная\n 3 - Случайная");
            type = (ArrType)Convert.ToInt32(Console.ReadLine());
        }
    }
}
