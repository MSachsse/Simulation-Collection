namespace DiscreteSorting
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_simsGrid = new System.Windows.Forms.Panel();
            this.panel_controls = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_moveInstant = new System.Windows.Forms.CheckBox();
            this.cb_showPointer = new System.Windows.Forms.CheckBox();
            this.cb_swapInstant = new System.Windows.Forms.CheckBox();
            this.btn_resume = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.sb_timer = new System.Windows.Forms.HScrollBar();
            this.btn_sort = new System.Windows.Forms.Button();
            this.gb_conGrid = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.gb_conArray = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sb_divider = new System.Windows.Forms.HScrollBar();
            this.cb_arrangement = new System.Windows.Forms.ComboBox();
            this.btn_rearrange = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel_controls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_conGrid.SuspendLayout();
            this.gb_conArray.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_simsGrid
            // 
            this.panel_simsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_simsGrid.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_simsGrid.Location = new System.Drawing.Point(0, 0);
            this.panel_simsGrid.Margin = new System.Windows.Forms.Padding(0);
            this.panel_simsGrid.Name = "panel_simsGrid";
            this.panel_simsGrid.Size = new System.Drawing.Size(986, 751);
            this.panel_simsGrid.TabIndex = 0;
            this.panel_simsGrid.SizeChanged += new System.EventHandler(this.panel_simsGrid_SizeChanged);
            // 
            // panel_controls
            // 
            this.panel_controls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_controls.Controls.Add(this.groupBox1);
            this.panel_controls.Controls.Add(this.gb_conGrid);
            this.panel_controls.Controls.Add(this.gb_conArray);
            this.panel_controls.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_controls.Location = new System.Drawing.Point(986, 0);
            this.panel_controls.Margin = new System.Windows.Forms.Padding(0);
            this.panel_controls.Name = "panel_controls";
            this.panel_controls.Size = new System.Drawing.Size(396, 751);
            this.panel_controls.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cb_moveInstant);
            this.groupBox1.Controls.Add(this.cb_showPointer);
            this.groupBox1.Controls.Add(this.cb_swapInstant);
            this.groupBox1.Controls.Add(this.btn_resume);
            this.groupBox1.Controls.Add(this.btn_pause);
            this.groupBox1.Controls.Add(this.sb_timer);
            this.groupBox1.Controls.Add(this.btn_sort);
            this.groupBox1.Location = new System.Drawing.Point(9, 395);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(374, 251);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorter controls";
            // 
            // cb_moveInstant
            // 
            this.cb_moveInstant.AutoSize = true;
            this.cb_moveInstant.Location = new System.Drawing.Point(181, 190);
            this.cb_moveInstant.Name = "cb_moveInstant";
            this.cb_moveInstant.Size = new System.Drawing.Size(177, 24);
            this.cb_moveInstant.TabIndex = 11;
            this.cb_moveInstant.Text = "Move Pointer Instantly";
            this.cb_moveInstant.UseVisualStyleBackColor = true;
            this.cb_moveInstant.CheckedChanged += new System.EventHandler(this.cb_moveInstant_CheckedChanged);
            // 
            // cb_showPointer
            // 
            this.cb_showPointer.AutoSize = true;
            this.cb_showPointer.Checked = true;
            this.cb_showPointer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_showPointer.Location = new System.Drawing.Point(31, 190);
            this.cb_showPointer.Name = "cb_showPointer";
            this.cb_showPointer.Size = new System.Drawing.Size(117, 24);
            this.cb_showPointer.TabIndex = 10;
            this.cb_showPointer.Text = "Show Pointer";
            this.cb_showPointer.UseVisualStyleBackColor = true;
            this.cb_showPointer.CheckedChanged += new System.EventHandler(this.cb_showPointer_CheckedChanged);
            // 
            // cb_swapInstant
            // 
            this.cb_swapInstant.AutoSize = true;
            this.cb_swapInstant.Location = new System.Drawing.Point(181, 145);
            this.cb_swapInstant.Name = "cb_swapInstant";
            this.cb_swapInstant.Size = new System.Drawing.Size(120, 24);
            this.cb_swapInstant.TabIndex = 9;
            this.cb_swapInstant.Text = "Swap intantly";
            this.cb_swapInstant.UseVisualStyleBackColor = true;
            this.cb_swapInstant.CheckedChanged += new System.EventHandler(this.cb_swapInstant_CheckedChanged);
            // 
            // btn_resume
            // 
            this.btn_resume.Location = new System.Drawing.Point(13, 69);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(94, 29);
            this.btn_resume.TabIndex = 8;
            this.btn_resume.Text = "Resume";
            this.btn_resume.UseVisualStyleBackColor = true;
            this.btn_resume.Click += new System.EventHandler(this.btn_resume_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(13, 33);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(94, 29);
            this.btn_pause.TabIndex = 7;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // sb_timer
            // 
            this.sb_timer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sb_timer.Location = new System.Drawing.Point(128, 30);
            this.sb_timer.Maximum = 1000;
            this.sb_timer.Minimum = 1;
            this.sb_timer.Name = "sb_timer";
            this.sb_timer.Size = new System.Drawing.Size(231, 26);
            this.sb_timer.TabIndex = 6;
            this.sb_timer.Value = 100;
            this.sb_timer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sb_timer_Scroll);
            // 
            // btn_sort
            // 
            this.btn_sort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sort.Location = new System.Drawing.Point(128, 69);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(231, 29);
            this.btn_sort.TabIndex = 0;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // gb_conGrid
            // 
            this.gb_conGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_conGrid.Controls.Add(this.btn_add);
            this.gb_conGrid.Controls.Add(this.btn_remove);
            this.gb_conGrid.Location = new System.Drawing.Point(10, 245);
            this.gb_conGrid.Margin = new System.Windows.Forms.Padding(10);
            this.gb_conGrid.Name = "gb_conGrid";
            this.gb_conGrid.Padding = new System.Windows.Forms.Padding(10);
            this.gb_conGrid.Size = new System.Drawing.Size(374, 130);
            this.gb_conGrid.TabIndex = 8;
            this.gb_conGrid.TabStop = false;
            this.gb_conGrid.Text = "Grid Controls";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Location = new System.Drawing.Point(128, 26);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(231, 29);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remove.Location = new System.Drawing.Point(128, 72);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(231, 29);
            this.btn_remove.TabIndex = 2;
            this.btn_remove.Text = "-";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // gb_conArray
            // 
            this.gb_conArray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_conArray.Controls.Add(this.label3);
            this.gb_conArray.Controls.Add(this.label2);
            this.gb_conArray.Controls.Add(this.label1);
            this.gb_conArray.Controls.Add(this.sb_divider);
            this.gb_conArray.Controls.Add(this.cb_arrangement);
            this.gb_conArray.Controls.Add(this.btn_rearrange);
            this.gb_conArray.Location = new System.Drawing.Point(10, 10);
            this.gb_conArray.Margin = new System.Windows.Forms.Padding(10);
            this.gb_conArray.Name = "gb_conArray";
            this.gb_conArray.Padding = new System.Windows.Forms.Padding(10);
            this.gb_conArray.Size = new System.Drawing.Size(374, 215);
            this.gb_conArray.TabIndex = 7;
            this.gb_conArray.TabStop = false;
            this.gb_conArray.Text = "Array Controls";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "New Array";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Array Length";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arrangement";
            // 
            // sb_divider
            // 
            this.sb_divider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sb_divider.Location = new System.Drawing.Point(128, 73);
            this.sb_divider.Margin = new System.Windows.Forms.Padding(5);
            this.sb_divider.Maximum = 50;
            this.sb_divider.Minimum = 1;
            this.sb_divider.Name = "sb_divider";
            this.sb_divider.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sb_divider.Size = new System.Drawing.Size(231, 26);
            this.sb_divider.TabIndex = 5;
            this.sb_divider.Value = 10;
            this.sb_divider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sb_divider_Scroll);
            // 
            // cb_arrangement
            // 
            this.cb_arrangement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_arrangement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_arrangement.FormattingEnabled = true;
            this.cb_arrangement.Location = new System.Drawing.Point(128, 35);
            this.cb_arrangement.Margin = new System.Windows.Forms.Padding(5);
            this.cb_arrangement.Name = "cb_arrangement";
            this.cb_arrangement.Size = new System.Drawing.Size(231, 28);
            this.cb_arrangement.TabIndex = 4;
            this.cb_arrangement.SelectedIndexChanged += new System.EventHandler(this.cb_arrangement_SelectedIndexChanged);
            // 
            // btn_rearrange
            // 
            this.btn_rearrange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rearrange.Location = new System.Drawing.Point(128, 109);
            this.btn_rearrange.Margin = new System.Windows.Forms.Padding(5);
            this.btn_rearrange.Name = "btn_rearrange";
            this.btn_rearrange.Size = new System.Drawing.Size(231, 29);
            this.btn_rearrange.TabIndex = 1;
            this.btn_rearrange.Text = "Rearrange";
            this.btn_rearrange.UseVisualStyleBackColor = true;
            this.btn_rearrange.Click += new System.EventHandler(this.btn_rearrange_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 751);
            this.Controls.Add(this.panel_controls);
            this.Controls.Add(this.panel_simsGrid);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panel_controls.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_conGrid.ResumeLayout(false);
            this.gb_conArray.ResumeLayout(false);
            this.gb_conArray.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_simsGrid;
        private Panel panel_controls;
        private ComboBox cb_arrangement;
        private Button btn_add;
        private Button btn_remove;
        private Button btn_rearrange;
        private Button btn_sort;
        private System.Windows.Forms.Timer timer;
        private HScrollBar sb_divider;
        private HScrollBar sb_timer;
        private GroupBox gb_conArray;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox gb_conGrid;
        private Label label3;
        private Label label2;
        private Button btn_resume;
        private Button btn_pause;
        private CheckBox cb_moveInstant;
        private CheckBox cb_showPointer;
        private CheckBox cb_swapInstant;
    }
}