
using DiscreteSorting.Helper;

namespace DiscreteSorting.Sorter
{
    public abstract class BaseSorter
    {
        protected float[] arr;
        protected Simulation sim;
        protected List<Pointer> pointers;
        protected List<Pointer> collidingPointers;
        protected Pointer[] commandPointers;

        public BaseSorter(Simulation sim, float[] arr)
        {
            this.arr = ArrayController.CopyArray(arr);
            this.sim = sim;
            pointers = new List<Pointer>();
            collidingPointers = new List<Pointer>();
            commandPointers = Array.Empty<Pointer>();
        }

        public abstract void Sort();

        protected bool IsSorted(int minIndex, int maxIndex)
        {
            for (int i = minIndex; i < maxIndex; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        private Pointer GetHighestPriorityPointerCopy(int index)
        {
            collidingPointers.Clear();
            foreach (Pointer p in pointers)
            {
                if (index == p.Index)
                {
                    collidingPointers.Add(p);
                }
            }

            if(collidingPointers.Count > 0)
            {
                Pointer prioPointer = collidingPointers[0];
                for (int i = 1; i < collidingPointers.Count; i++)
                {
                    if (collidingPointers[i].Priority > prioPointer.Priority)
                    {
                        prioPointer = collidingPointers[i];
                    }
                }
                return prioPointer.Copy();
            }
            else
            {
                return new Pointer(index, Color.White, 0);
            }
        }


        protected void SwapPointerValues(Pointer pA, Pointer pB)
        {
            // Do the swap
            ArrayController.SwapEntriesTemp(arr, pA.Index, pB.Index);
            // Get hightst prio pointer at each index
            commandPointers = new Pointer[] { GetHighestPriorityPointerCopy(pA.Index), GetHighestPriorityPointerCopy(pB.Index) };
            // Add Change to queue
            sim.AddChange(new Change("swap", commandPointers, Simulation.SwapInstant));
        }

        protected void MovePointer(Pointer p, int newIndex)
        {
            // Move the p
            p.Index = newIndex;
            // Get hightst prio pointer for new and old index
            commandPointers = new Pointer[] { GetHighestPriorityPointerCopy(p.Index), GetHighestPriorityPointerCopy(p.OldIndex) };
            // Add Change to queue
            sim.AddChange(new Change("move", commandPointers, Simulation.MoveInstant));
        }

        protected void IncrementPointer(Pointer p)
        {
            MovePointer(p, p.Index + 1);
        }

        protected void DecrementPointer(Pointer p)
        {
            MovePointer(p, p.Index - 1);
        }

        protected void ChangePointerValue(Pointer p, int newIndex, float value)
        {
            MovePointer(p, newIndex);
            // Do the value change
            arr[p.Index] = value;
            // Get hightst prio pointer at each index
            commandPointers = new Pointer[] { GetHighestPriorityPointerCopy(p.Index) };
            // Add Change to queue
            sim.AddChange(new Change("change", commandPointers, value, Simulation.SwapInstant));
        }

        protected void HidePointer(Pointer p)
        {
            p.Color = Color.White;
            commandPointers = new Pointer[] { p };
            sim.AddChange(new Change("Hide", commandPointers, true));
        }

        public void HideAllPointers()
        {
            foreach (Pointer p in pointers)
            {
                p.Color = Color.White;
            }
            sim.AddChange(new Change("Hide", pointers.ToArray(), true));
        }
    }
}
