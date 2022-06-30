using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteSorting.Helper
{
    public class Pointer
    {
        private int _index, _oldIndex, _priority;
        private Color _color;

        public Pointer(int index, Color color, int priority)
        {
            Color = color;
            Priority = priority;
            Index = index;
        }

        public int Index
        {
            get { return _index; }
            set
            {
                OldIndex = Index;
                _index = value;
            }
        }

        public int OldIndex
        {
            get { return _oldIndex; }
            private set { _oldIndex = value; }
        }

        public int Priority
        {
            get { return _priority; }
            private set { _priority = value; }
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Pointer Copy()
        {
            return new Pointer(Index, Color, Priority);
        }
    }
}
