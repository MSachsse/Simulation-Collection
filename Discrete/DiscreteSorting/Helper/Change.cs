using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteSorting.Helper
{
    public class Change
    {
        private string _command;
        private Pointer[] _pointers;
        private float _value;
        private bool _isInstant;


        public Change(string command, Pointer[] pointers, bool isInstant)
        {
            _command = command;
            _pointers = pointers;
            _isInstant = isInstant;
        }

        public Change(string command, Pointer[] pointers, float value, bool isInstant)
        {
            _command = command;
            _pointers = pointers;
            _value = value;
            _isInstant = isInstant;
        }

        public string Command { get { return _command; } }

        public Pointer[] Pointers { get { return _pointers; } }

        public float Value { get { return _value; } }

        public bool IsInstant { get { return _isInstant; } }
    }
}
