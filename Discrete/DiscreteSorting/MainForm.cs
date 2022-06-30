using DiscreteSorting.Helper;

namespace DiscreteSorting
{
    public partial class MainForm : Form
    {
        // Grid of simulations attributs
        private int GridMargin = 10;
        private int GridMaxSims = 16;
        private int GridRows, GridCols;
        // Single simulation attributes
        private int SimHeight, SimWidth;
        // Array used for all simulations before sorting
        private float[] Arr = Array.Empty<float>();
        private int ArrLength;
        private float ArrMin;
        private float ArrMax;


        public MainForm()
        {
            InitializeComponent();

            InitializeFirstSimulation();

            InitializeControls();
        }

        // Initialization methods

        private void InitializeFirstSimulation()
        {
            // Initial grid: 1 X 1
            GridCols = 1;
            GridRows = 1;
            //// Initial simulation size
            UpdateSimulationSizeInGrid();
            //// Initial array with arrangement: "Random"
            UpdateArray(ArrayController.Arrangement[0]);
            // Initial simulation
            panel_simsGrid.Controls.Add(new Simulation(0, Arr));
        }

        private void InitializeControls()
        {
            ToggleGridButtonsVisibility(0);

            foreach(string arrArrangement in ArrayController.Arrangement)
            {
                cb_arrangement.Items.Add("" + arrArrangement);
            }
            cb_arrangement.SelectedIndex = 0;
        }

        // Updating methods

        private void UpdateArray()
        {
            ArrLength = SimWidth / sb_divider.Value + 1;
            ArrMin = SimHeight / (float)ArrLength;
            ArrMax = SimHeight * (1.0f - 1.0f / ArrLength);
            Arr = ArrayController.GetArray(cb_arrangement.Text, ArrLength, ArrMin, ArrMax);
        }

        private void UpdateArray(string arrangement)
        {
            ArrLength = SimWidth / sb_divider.Value + 1;
            ArrMin = SimHeight / (float)ArrLength;
            ArrMax = SimHeight * (1.0f - 1.0f / ArrLength);
            Arr = ArrayController.GetArray(arrangement, ArrLength, ArrMin, ArrMax);
        }

        private void UpdateSimulationArray(Simulation sim)
        {
            sim.UpdateArray(Arr);
        }

        private void UpdateSimulationSpacing(Simulation sim)
        {
            Simulation.BarWidth = sb_divider.Value;

            sim.SetLocation(GridMargin + sim.Id % GridCols * (SimWidth + GridMargin), GridMargin + sim.Id / GridCols * (SimHeight + GridMargin));
            sim.SetSize(SimWidth, SimHeight);

            UpdateSimulationArray(sim);
        }

        private void UpdateSimulationSizeInGrid()
        {
            // Calculate SimHeight and SimWidth by the following equation:
            //      Length    = n * simLength + (n+1) * simMargin
            //  <=> simLength = (Length - (n+1) * simMargin) / n
            SimHeight = (panel_simsGrid.Height - (GridRows + 1) * GridMargin) / GridRows;
            SimWidth = (panel_simsGrid.Width - (GridCols + 1) * GridMargin) / GridCols;
        }

        private void UpdateSimGridArray()
        {
            UpdateSimulationSizeInGrid();
            UpdateArray();
            foreach (Simulation sim in panel_simsGrid.Controls)
            {
                UpdateSimulationArray(sim);
            }
        }

        private void UpdateSimGridSpacing()
        {
            UpdateSimulationSizeInGrid();
            UpdateArray();
            foreach (Simulation sim in panel_simsGrid.Controls)
            {
                UpdateSimulationSpacing(sim);
            }
        }

        // Helper methods

        private void ToggleGridButtonsVisibility(int index)
        {
            btn_add.Visible = index < GridMaxSims;
            btn_remove.Visible = index > 0;
        }

        private void ToggleControlsEnablement(bool enable)
        {
            foreach (Control con in gb_conArray.Controls)
            {
                con.Enabled = enable;
            }

            sb_timer.Enabled = true;
        }

        // Array related events

        private void cb_arrangement_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSimGridArray();
        }

        private void sb_divider_Scroll(object sender, ScrollEventArgs e)
        {
            Simulation.BarWidth = sb_divider.Value;
            UpdateSimGridArray();
        }

        private void btn_rearrange_Click(object sender, EventArgs e)
        {
            UpdateSimGridArray();
        }

        // Grid related events

        private void MainForm_Shown(object sender, EventArgs e)
        {
            UpdateSimGridSpacing();
        }
       
        private void panel_simsGrid_SizeChanged(object sender, EventArgs e)
        {
            UpdateSimGridSpacing();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int currentIndex = panel_simsGrid.Controls.Count;

            Simulation sim = new Simulation(currentIndex, Arr);
            panel_simsGrid.Controls.Add(sim);
            if (GridCols * GridRows > currentIndex)
            {
                UpdateSimulationSpacing(sim); 
            }
            else
            {
                if (GridRows > GridCols)
                {
                    GridCols++;
                }
                else
                {
                    GridRows++;
                }
                UpdateSimGridSpacing();
            }

            ToggleGridButtonsVisibility(currentIndex + 1);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int currentIndex = panel_simsGrid.Controls.Count - 1;

            panel_simsGrid.Controls.RemoveAt(currentIndex);
            if (GridCols * (GridRows - 1) >= currentIndex)
            {
                if (GridRows > GridCols)
                {
                    GridRows--;
                }
                else
                {
                    GridCols--;
                }
                UpdateSimGridSpacing();
            }

            ToggleGridButtonsVisibility(currentIndex - 1);
        }


        // Sorting related events (with timer as background clock for the discrete simulation)

        private void btn_sort_Click(object sender, EventArgs e)
        {
            foreach (Simulation sim in panel_simsGrid.Controls)
            {
                sim.ClearChanges();
                sim.StartSimulation();
            }

            timer.Start();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btn_resume_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void cb_moveInstant_CheckedChanged(object sender, EventArgs e)
        {
            Simulation.MoveInstant = cb_moveInstant.Checked;
        }

        private void cb_showPointer_CheckedChanged(object sender, EventArgs e)
        {
            Simulation.ShowMove = cb_showPointer.Checked;
        }

        private void cb_swapInstant_CheckedChanged(object sender, EventArgs e)
        {
            Simulation.SwapInstant = cb_swapInstant.Checked;
        }

        private void sb_timer_Scroll(object sender, ScrollEventArgs e)
        {
            timer.Interval = sb_timer.Value;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (Simulation sim in panel_simsGrid.Controls)
            {
                sim.SimulateStep();
            }
        }


    }
}