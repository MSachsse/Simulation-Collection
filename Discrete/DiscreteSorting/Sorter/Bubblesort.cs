
using DiscreteSorting.Helper;

namespace DiscreteSorting.Sorter
{
    public class Bubblesort : BaseSorter
    {
        private Pointer p;

        public Bubblesort(Simulation sim, float[] arr) : base(sim, arr)
        {
            p = new Pointer(0, Color.Red, 1);
            pointers.Add(p);
        }

        public override void Sort()
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (IsSorted(0, i))
                {
                    break;
                }

                MovePointer(p, 0);
                while (p.Index < i)
                {
                    if (arr[p.Index] > arr[p.Index + 1])
                    {
                        SwapPointerValues(p, new Pointer(p.Index + 1, p.Color, p.Priority));
                    }
                    IncrementPointer(p);
                }
            }
        }

    }
}
