using DiscreteSorting.Helper;

namespace DiscreteSorting.Sorter
{
    internal class Quicksort : BaseSorter
    {
        private Pointer pLeft;
        private Pointer pRight;
        private Pointer pPivot;
        private int divider;

        public Quicksort(Simulation sim, float[] arr) : base(sim, arr)
        {
            pLeft = new Pointer(0, Color.Red, 1);
            pRight = new Pointer(arr.Length - 1, Color.Red, 1);
            pPivot = new Pointer(arr.Length - 1, Color.Green, 2);

            pointers.Add(pLeft);
            pointers.Add(pRight);
            pointers.Add(pPivot);
        }

        public override void Sort()
        {
            Split(0, arr.Length - 1);
        }

        private void Split(int start, int end)
        {
            if (start < end && !IsSorted(start, end))
            {
                divider = Merge(start, end);
                Split(start, divider - 1);
                Split(divider + 1, end);
            }
        }

        private int Merge(int start, int end)
        {
            MovePointer(pLeft, start);
            MovePointer(pRight, end);
            MovePointer(pPivot, end);

            while (pLeft.Index < pRight.Index)
            {
                while (arr[pLeft.Index] <= arr[pPivot.Index] && pLeft.Index < pRight.Index)
                {
                    IncrementPointer(pLeft);
                }
                while (arr[pPivot.Index] <= arr[pRight.Index] && pLeft.Index < pRight.Index)
                {
                    DecrementPointer(pRight);
                }
                if (pLeft.Index < pRight.Index)
                {
                    SwapPointerValues(pLeft, pRight);
                }
            }

            SwapPointerValues(pRight, pPivot);
            return pRight.Index;
        }
    }
}
