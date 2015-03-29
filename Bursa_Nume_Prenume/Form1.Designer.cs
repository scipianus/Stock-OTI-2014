namespace Bursa_Nume_Prenume
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDeschidere = new System.Windows.Forms.Button();
            this.buttonInchidere = new System.Windows.Forms.Button();
            this.numericUpDownRefresh = new System.Windows.Forms.NumericUpDown();
            this.labelRefresh = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utilizatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actiunileMeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficProfitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefresh)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeschidere
            // 
            this.buttonDeschidere.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeschidere.Location = new System.Drawing.Point(36, 72);
            this.buttonDeschidere.Name = "buttonDeschidere";
            this.buttonDeschidere.Size = new System.Drawing.Size(107, 47);
            this.buttonDeschidere.TabIndex = 0;
            this.buttonDeschidere.Text = "Deschide bursa";
            this.buttonDeschidere.UseVisualStyleBackColor = true;
            this.buttonDeschidere.Click += new System.EventHandler(this.buttonDeschidere_Click);
            // 
            // buttonInchidere
            // 
            this.buttonInchidere.Enabled = false;
            this.buttonInchidere.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInchidere.Location = new System.Drawing.Point(188, 72);
            this.buttonInchidere.Name = "buttonInchidere";
            this.buttonInchidere.Size = new System.Drawing.Size(107, 47);
            this.buttonInchidere.TabIndex = 1;
            this.buttonInchidere.Text = "Inchide bursa";
            this.buttonInchidere.UseVisualStyleBackColor = true;
            this.buttonInchidere.Click += new System.EventHandler(this.buttonInchidere_Click);
            // 
            // numericUpDownRefresh
            // 
            this.numericUpDownRefresh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRefresh.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownRefresh.Location = new System.Drawing.Point(214, 152);
            this.numericUpDownRefresh.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRefresh.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownRefresh.Name = "numericUpDownRefresh";
            this.numericUpDownRefresh.ReadOnly = true;
            this.numericUpDownRefresh.Size = new System.Drawing.Size(81, 21);
            this.numericUpDownRefresh.TabIndex = 2;
            this.numericUpDownRefresh.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownRefresh.ValueChanged += new System.EventHandler(this.numericUpDownRefresh_ValueChanged);
            // 
            // labelRefresh
            // 
            this.labelRefresh.AutoSize = true;
            this.labelRefresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRefresh.Location = new System.Drawing.Point(32, 152);
            this.labelRefresh.Name = "labelRefresh";
            this.labelRefresh.Size = new System.Drawing.Size(164, 19);
            this.labelRefresh.TabIndex = 3;
            this.labelRefresh.Text = "Rata reimprospatare";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilizatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(336, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utilizatorToolStripMenuItem
            // 
            this.utilizatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actiunileMeleToolStripMenuItem,
            this.graficProfitToolStripMenuItem});
            this.utilizatorToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.utilizatorToolStripMenuItem.Name = "utilizatorToolStripMenuItem";
            this.utilizatorToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.utilizatorToolStripMenuItem.Text = "Utilizator";
            // 
            // actiunileMeleToolStripMenuItem
            // 
            this.actiunileMeleToolStripMenuItem.Name = "actiunileMeleToolStripMenuItem";
            this.actiunileMeleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.actiunileMeleToolStripMenuItem.Text = "Actiunile mele";
            this.actiunileMeleToolStripMenuItem.Click += new System.EventHandler(this.actiunileMeleToolStripMenuItem_Click);
            // 
            // graficProfitToolStripMenuItem
            // 
            this.graficProfitToolStripMenuItem.Name = "graficProfitToolStripMenuItem";
            this.graficProfitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.graficProfitToolStripMenuItem.Text = "Grafic profit";
            this.graficProfitToolStripMenuItem.Click += new System.EventHandler(this.graficProfitToolStripMenuItem_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 178);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(38, 37);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(336, 227);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelRefresh);
            this.Controls.Add(this.numericUpDownRefresh);
            this.Controls.Add(this.buttonInchidere);
            this.Controls.Add(this.buttonDeschidere);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bursa";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefresh)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeschidere;
        private System.Windows.Forms.Button buttonInchidere;
        private System.Windows.Forms.NumericUpDown numericUpDownRefresh;
        private System.Windows.Forms.Label labelRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem utilizatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actiunileMeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficProfitToolStripMenuItem;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

