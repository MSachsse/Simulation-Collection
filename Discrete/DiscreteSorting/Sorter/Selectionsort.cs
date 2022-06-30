using DiscreteSorting.Helper;

namespace DiscreteSorting.Sorter
{
    public class Selectionsort : BaseSorter
    {
        private Pointer pI;
        private Pointer pJ;
        private Pointer pMin;

        public Selectionsort(Simulation sim, float[] arr) : base(sim, arr)
        {
            pI = new Pointer(0, Color.Blue, 2);
            pMin = new Pointer(0, Color.Green, 3);
            pJ = new Pointer(1, Color.Red, 1);

            pointers.Add(pI);
            pointers.Add(pMin);
            pointers.Add(pJ);
        }

        public override void Sort()
        {
            MovePointer(pI, 0);
            MovePointer(pMin, 0);

            while (!IsSorted(pI.Index, arr.Length-1))
            {
                MovePointer(pJ, pI.Index + 1);

                while(pJ.Index < arr.Length)
                {
                    if (arr[pJ.Index] < arr[pMin.Index])
                    {
                        MovePointer(pMin, pJ.Index);
                    }
                    IncrementPointer(pJ);
                }
                SwapPointerValues(pI, pMin);

                IncrementPointer(pI);
                MovePointer(pMin, pI.Index);
            }
        }
    }
}
