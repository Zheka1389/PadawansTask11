using System;

namespace PadawansTask11
{
    public static class ArrayExtensions
    {
        public static int? FindIndex(double[] array, double accuracy)
        {
            if (accuracy <= 0 || accuracy >= 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (array == null)
            {
                throw new ArgumentNullException();
            }
            if (array.Length == 0)
            {
                throw new ArgumentException();
            }
            else if (array.Length <= 2)
            {
                return null;
            }
            int? index = 0;
            double sumLeft = array[0], sumRight = array[array.Length - 1];
            if (array.Length == 3)
            {
                if (Math.Abs(sumLeft - sumRight) >= accuracy)
                    return null;
                else
                    return 1;
            }
            for (int i = 1; i < array.Length - 1; i++)
            {
                sumLeft = 0;
                sumRight = 0;
                for (int y = 0; y < array.Length; y++)
                {
                    if (y < i)
                    {
                        sumLeft += array[y];
                    }
                    else if (y > i)
                    {
                        sumRight += array[y];
                    }
                }
                if (Math.Abs(sumLeft - sumRight) <= accuracy)
                    index = i;
            }

            if (index == 0)
                return null;
            else
                return index;
        }
    }
}
