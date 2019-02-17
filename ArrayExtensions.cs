using System;

namespace PadawansTask11
{
    public static class ArrayExtensions
    {
        public static int? FindIndex(double[] array, double accuracy)
        {
            int index = 0;
            double sumLeft = array[0], sumRight = array[array.Length - 1];
            for (int i = 0, y = array.Length - 1; i < y;)
            {

                if (sumLeft <= sumRight)
                {
                    sumLeft += array[i + 1];
                    i++;
                    index = i;
                }
                else if (sumLeft >= sumRight)
                {
                    sumRight += array[y - 1];
                    y--;
                    index = i;
                }
            }
            if (Math.Abs(sumLeft - sumRight) > accuracy)
                return null;
            else
                return index;
        }
    }
}
