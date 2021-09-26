using System;

namespace Function
{
    public enum SortOrder { Ascending, Descending }
    public static class Function
    {
        public static bool IsSorted(int[] array, SortOrder order)
        {
            bool isSorted = false;
            switch (order)
            {
                case SortOrder.Ascending:
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i > 0)
                        {
                            isSorted = array[i] >= array[i - 1];
                            if (!isSorted) return false;
                        }
                    }
                    break;
                case SortOrder.Descending:
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i > 0)
                        {
                            isSorted = array[i] <= array[i - 1];
                            if (!isSorted) return false;
                        }
                    }
                    break;
            }
            return isSorted;
        }

        public static void Transform(int[] array, SortOrder order)
        {
            if (IsSorted(array, order))
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] += i;
                }
        }

        public static double MultArithmeticElements(double a, double t, int n)
        {
            double result = 1;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                    result = a;
                else result *= (a += t);
            }
            return result;
        }

        public static double SumGeometricElements(double a, double t, double alim)
        {
            double result = 0;
            for (double i = a; i > alim; i*= t)
            {
                result += i;
            }
            return result;
        }
    }
}
