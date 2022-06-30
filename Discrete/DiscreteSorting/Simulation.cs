using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DiscreteSorting.Sorter;
using DiscreteSorting.Helper;

namespace DiscreteSorting
{
    public partial class Simulation : UserControl
    {
        // Key attribute for identification and positioning
        public int Id;
        // Copy of the array used in the MainForm class
        private float[] Arr = Array.Empty<float>();
        // Simulation related values
        private Graphics Graphics;
        private static int _barWidth = 1;
        // Used Sorter
        public BaseSorter Sorter;
        // Queue of Changes filled by the Sorter
        private Queue<Change> Changes;
        // Backgroundworker for parallel simulation

        // Cost enablement
        private static bool _showMove = true;
        private static bool _moveInstant = false;
        private static bool _swapInstant = false;

        public Simulation(int Id, float[] Arr)
        {
            InitializeComponent();
            // Initialize attributes
            this.Id = Id;
            UpdateArray(Arr);
            Graphics = panel_sim.CreateGraphics();
            Sorter = new Bubblesort(this, Arr);
            Changes = new Queue<Change>();
            // Initialize controls
            List<string> SorterClasses = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(x => typeof(BaseSorter).IsAssignableFrom(x) && !x.IsAbstract && !x.IsInterface)
                .Select(x => x.Name).ToList();
            SorterClasses.Sort();
            foreach (string SorterClass in SorterClasses)
            {
                cb_sorter.Items.Add(SorterClass);
            }
            cb_sorter.SelectedIndex = 0;
        }

        // Getter and Setter

        public static bool ShowMove
        {
            get { return _showMove; }
            set { _showMove = value; }
        }

        public static bool MoveInstant
        {
            get { return _moveInstant; }
            set { _moveInstant = value; }
        }

        public static bool SwapInstant
        {
            get { return _swapInstant; }
            set { _swapInstant = value; }
        }

        public static int BarWidth
        {
            get { return _barWidth; }
            set { _barWidth = value; }
        }


        // Spacing methods

        public void SetLocation(int X, int Y)
        {
            this.Location = new Point(X, Y);
        }

        public void SetSize(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        // Change-queue methods

        public void ClearChanges()
        {
            Changes.Clear();
        }

        public void AddChange(Change change)
        {
            Changes.Enqueue(change);
        }

        public int HandleChangeQueue()
        {
            if(Changes.Count <= 0)
            {
                return 0;
            }

            Change change;

            do
            {
                change = Changes.Dequeue();
                HandleChange(change);
            } while (Changes.Count > 0 && change.IsInstant);

            return Changes.Count;
        }

        private void HandleChange(Change change)
        {
            switch (change.Command)
            {
                case "swap":
                    ArrayController.SwapEntriesTemp(Arr, change.Pointers[0].Index, change.Pointers[1].Index);
                    break;
                case "move":
                    break;
                case "change":
                    Arr[change.Pointers[0].Index] = change.Value;
                    break;
                case "hide":
                    break;
                default:
                    break;
            }

            if (ShowMove)
            {
                foreach (Pointer pointer in change.Pointers)
                {
                    DrawEntry(pointer.Index, pointer.Color);
                }
            }
            else
            {
                foreach (Pointer pointer in change.Pointers)
                {
                    DrawEntry(pointer.Index, Color.White);
                }
            }
        }

        // Simulation methods

        public void StartSimulation()
        {
            Type type = Type.GetType("DiscreteSorting.Sorter." + cb_sorter.SelectedItem);
            var ctors = type.GetConstructors();
            Sorter = (BaseSorter)ctors[0].Invoke(new object[] { this, Arr });
            Sorter.Sort();
            Sorter.HideAllPointers();
        }

        public void SimulateStep()
        {
            if (!bgw_asyncSim.IsBusy)
            {
                bgw_asyncSim.RunWorkerAsync();
            }
        }

        public void UpdateArray(float[] Arr)
        {
            this.Arr = ArrayController.CopyArray(Arr);

            Graphics = panel_sim.CreateGraphics();
            for (int i = 0; i < Arr.Length; i++)
            {
                DrawEntry(i, Color.White);
            }
        }

        private void DrawEntry(int index, Color color)
        {
            if (index >= 0 && index < Arr.Length)
            {
                Graphics.FillRectangle(new SolidBrush(Color.Black), index * BarWidth, 0, BarWidth, Height);
                Graphics.FillRectangle(new SolidBrush(color), index * BarWidth, Height - Arr[index], BarWidth, Arr[index]);
            }
        }

        private void bgw_asyncSim_DoWork(object sender, DoWorkEventArgs e)
        {
            HandleChangeQueue();
        }
    }
}
