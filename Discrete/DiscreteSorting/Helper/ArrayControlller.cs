using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DiscreteSorting.Helper
{
    internal static class ArrayController
    {
        public static int numUnique = 6;

        public static string[] Arrangement = 
        {
            "Random",
            "Reversed",
            "Almost sorted",
            "A few unique",
            "Sorted"
        };

        public static void ScaleArray(float[] arr, float minValue, float maxValue)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * maxValue + (1 - arr[i]) * minValue;
            }
        }

        public static void ShuffleArray(float[] arr)
        {
            Random random = new();
            int j;
            for (int i = 0; i < arr.Length; i++)
            {
                j = random.Next(i, arr.Length);
                SwapEntries(arr, i, j);
            }
        }

        public static void SwapEntries(float[] arr, int i, int j)
        {
            if (i != j)
            {
                arr[i] += arr[j];
                arr[j] = arr[i] - arr[j];
                arr[i] -= arr[j];
            }
        }

        public static void SwapEntriesTemp(float[] arr, int i, int j)
        {
            if (i != j)
            {
                float temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
        }

        public static float[] CopyArray(float[] original)
        {
            float[] copy = new float[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                copy[i] = original[i];
            }
            return copy;
        }

        public static float[] GetArray(string arrangement, int length, float minValue, float maxValue)
        {
            float[] arr;

            if (arrangement == Arrangement[0])
            {
                arr = GetArray_Random(length);
            }
            else if (arrangement == Arrangement[1])
            {
                arr = GetArray_Reversed(length);
            }
            else if (arrangement == Arrangement[2])
            {
                arr = GetArray_AlmostSorted(length);
            }
            else if (arrangement == Arrangement[3])
            {
                arr = GetArray_FewUnique(length, numUnique);
            }
            else if (arrangement == Arrangement[4])
            {
                arr = GetArray_Sorted(length);
            }
            else
            {
                arr = new float[1];
                MessageBox.Show("here");
            }

            ScaleArray(arr, minValue, maxValue);

            return arr;
        }





        private static float[] GetArray_Random(int length)
        {
            float[] arr = GetArray_Sorted(length);
            ShuffleArray(arr);
            return arr;
        }

        private static float[] GetArray_Sorted(int length)
        {
            float[] arr = new float[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (float)i / (arr.Length - 1);
            }
            return arr;
        }

        private static float[] GetArray_Reversed(int length)
        {
            float[] arr = new float[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (float)(arr.Length - 1 - i) / (arr.Length - 1);
            }
            return arr;
        }

        private static float[] GetArray_FewUnique(int length, int n)
        {
            float[] arr = new float[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (float)(i % n) / (n - 1);
            }
            ShuffleArray(arr);
            return arr;
        }

        private static float[] GetArray_AlmostSorted(int length)
        {
            float[] arr = GetArray_Sorted(length);

            Random r = new Random();
            int i = r.Next(0, arr.Length);
            int j = r.Next(0, arr.Length);
            while (i == j)
            {
                i = r.Next(0, arr.Length);
                j = r.Next(0, arr.Length);
            }

            SwapEntries(arr, i, j);

            return arr;
        }


    }
}
