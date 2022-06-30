using DiscreteSorting.Helper;

namespace DiscreteSorting.Sorter
{
    internal class Mergesort : BaseSorter
    {
        private Pointer pLeft;
        private Pointer pRight;
        private Pointer pUpdater;
        private float[] tempArr;

        public Mergesort(Simulation sim, float[] arr) : base(sim, arr)
        {
            pLeft = new Pointer(0, Color.Red, 1);
            pRight = new Pointer(0, Color.Red, 1);
            pUpdater = new Pointer(0, Color.Blue, 1);

            pointers.Add(pLeft);
            pointers.Add(pRight);
            pointers.Add(pUpdater);
        }

        public override void Sort()
        {
            Split(0, arr.Length - 1);
        }

        private void Split(int start, int end)
        {
            if (start < end && !IsSorted(start, end))
            {
                int mid = (start + end) / 2;
                Split(start, mid);
                Split(mid + 1, end);
                Merge(start, mid, end);
            }
        }

        private void Merge(int left, int mid, int right)
        {
            tempArr = new float[right - left + 1];
            MovePointer(pLeft, left);
            MovePointer(pRight, mid + 1);
            for (int i = 0; i < tempArr.Length; i++)
            {
                if (pLeft.Index > mid)
                {
                    tempArr[i] = arr[pRight.Index];
                    IncrementPointer(pRight);
                }
                else if (pRight.Index > right)
                {
                    tempArr[i] = arr[pLeft.Index];
                    IncrementPointer(pLeft);
                }
                else if (arr[pLeft.Index] < arr[pRight.Index])
                {
                    tempArr[i] = arr[pLeft.Index];
                    IncrementPointer(pLeft);
                }
                else
                {
                    tempArr[i] = arr[pRight.Index];
                    IncrementPointer(pRight);
                }
            }

            for (int i = 0; i < tempArr.Length; i++)
            {
                ChangePointerValue(pUpdater, left + i, tempArr[i]);
            }
        }
    }
}
