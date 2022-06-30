namespace DiscreteSorting
{
    partial class Simulation
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_sim = new System.Windows.Forms.Panel();
            this.cb_sorter = new System.Windows.Forms.ComboBox();
            this.bgw_asyncSim = new System.ComponentModel.BackgroundWorker();
            this.panel_sim.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_sim
            // 
            this.panel_sim.BackColor = System.Drawing.Color.Black;
            this.panel_sim.Controls.Add(this.cb_sorter);
            this.panel_sim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_sim.Location = new System.Drawing.Point(0, 0);
            this.panel_sim.Name = "panel_sim";
            this.panel_sim.Size = new System.Drawing.Size(1116, 582);
            this.panel_sim.TabIndex = 0;
            // 
            // cb_sorter
            // 
            this.cb_sorter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sorter.FormattingEnabled = true;
            this.cb_sorter.Location = new System.Drawing.Point(3, 3);
            this.cb_sorter.Name = "cb_sorter";
            this.cb_sorter.Size = new System.Drawing.Size(283, 28);
            this.cb_sorter.TabIndex = 0;
            // 
            // bgw_asyncSim
            // 
            this.bgw_asyncSim.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_asyncSim_DoWork);
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_sim);
            this.Name = "Simulation";
            this.Size = new System.Drawing.Size(1116, 582);
            this.panel_sim.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_sim;
        private ComboBox cb_sorter;
        private System.ComponentModel.BackgroundWorker bgw_asyncSim;
    }
}
