namespace Bursa_Nume_Prenume
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dBBursaDataSet = new Bursa_Nume_Prenume.DBBursaDataSet();
            this.dBBursaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBursaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBursaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grafic
            // 
            chartArea1.AxisX.Title = "Timp";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "Valoare";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.grafic.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.grafic.Legends.Add(legend1);
            this.grafic.Location = new System.Drawing.Point(12, 12);
            this.grafic.Name = "grafic";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafic.Series.Add(series1);
            this.grafic.Size = new System.Drawing.Size(892, 330);
            this.grafic.TabIndex = 0;
            this.grafic.Text = "chart1";
            // 
            // dBBursaDataSet
            // 
            this.dBBursaDataSet.DataSetName = "DBBursaDataSet";
            this.dBBursaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBBursaDataSetBindingSource
            // 
            this.dBBursaDataSetBindingSource.DataSource = this.dBBursaDataSet;
            this.dBBursaDataSetBindingSource.Position = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(916, 354);
            this.Controls.Add(this.grafic);
            this.Name = "Form3";
            this.Text = "Grafic profit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBursaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBursaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dBBursaDataSetBindingSource;
        private DBBursaDataSet dBBursaDataSet;
        public System.Windows.Forms.DataVisualization.Charting.Chart grafic;


    }
}