namespace Bursa_Nume_Prenume
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Denumire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumarActiuni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValoareInitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValoareMomentan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValoareModif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalInitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMomentan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitMomentan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBBursaDataSet = new Bursa_Nume_Prenume.DBBursaDataSet();
            this.dBBursaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelProfitTotal = new System.Windows.Forms.Label();
            this.textBoxProfitTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBursaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBursaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Denumire,
            this.NumarActiuni,
            this.ValoareInitial,
            this.ValoareMomentan,
            this.ValoareModif,
            this.TotalInitial,
            this.TotalMomentan,
            this.ProfitMomentan,
            this.ProfitTotal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(721, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // Denumire
            // 
            this.Denumire.HeaderText = "Denumire";
            this.Denumire.Name = "Denumire";
            this.Denumire.ReadOnly = true;
            this.Denumire.Width = 75;
            // 
            // NumarActiuni
            // 
            this.NumarActiuni.HeaderText = "Numar actiuni";
            this.NumarActiuni.Name = "NumarActiuni";
            this.NumarActiuni.ReadOnly = true;
            this.NumarActiuni.Width = 75;
            // 
            // ValoareInitial
            // 
            this.ValoareInitial.HeaderText = "Valoare actiune INITIAL";
            this.ValoareInitial.Name = "ValoareInitial";
            this.ValoareInitial.ReadOnly = true;
            this.ValoareInitial.Width = 75;
            // 
            // ValoareMomentan
            // 
            this.ValoareMomentan.HeaderText = "Valoare actiune momentana";
            this.ValoareMomentan.Name = "ValoareMomentan";
            this.ValoareMomentan.ReadOnly = true;
            this.ValoareMomentan.Width = 75;
            // 
            // ValoareModif
            // 
            this.ValoareModif.HeaderText = "Valoarea cu care a crescut sau a scazut actiunea momentan";
            this.ValoareModif.Name = "ValoareModif";
            this.ValoareModif.ReadOnly = true;
            this.ValoareModif.Width = 75;
            // 
            // TotalInitial
            // 
            this.TotalInitial.HeaderText = "Total valoare initial";
            this.TotalInitial.Name = "TotalInitial";
            this.TotalInitial.ReadOnly = true;
            this.TotalInitial.Width = 75;
            // 
            // TotalMomentan
            // 
            this.TotalMomentan.HeaderText = "Total valoare momentana";
            this.TotalMomentan.Name = "TotalMomentan";
            this.TotalMomentan.ReadOnly = true;
            this.TotalMomentan.Width = 75;
            // 
            // ProfitMomentan
            // 
            this.ProfitMomentan.HeaderText = "Profit / Pierdere momentana";
            this.ProfitMomentan.Name = "ProfitMomentan";
            this.ProfitMomentan.ReadOnly = true;
            this.ProfitMomentan.Width = 75;
            // 
            // ProfitTotal
            // 
            this.ProfitTotal.HeaderText = "Profit / Pierdere total";
            this.ProfitTotal.Name = "ProfitTotal";
            this.ProfitTotal.ReadOnly = true;
            this.ProfitTotal.Width = 75;
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
            // labelProfitTotal
            // 
            this.labelProfitTotal.AutoSize = true;
            this.labelProfitTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfitTotal.Location = new System.Drawing.Point(242, 249);
            this.labelProfitTotal.Name = "labelProfitTotal";
            this.labelProfitTotal.Size = new System.Drawing.Size(126, 15);
            this.labelProfitTotal.TabIndex = 1;
            this.labelProfitTotal.Text = "Profit / Pierdere Total";
            // 
            // textBoxProfitTotal
            // 
            this.textBoxProfitTotal.Location = new System.Drawing.Point(374, 247);
            this.textBoxProfitTotal.Name = "textBoxProfitTotal";
            this.textBoxProfitTotal.ReadOnly = true;
            this.textBoxProfitTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxProfitTotal.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(745, 282);
            this.Controls.Add(this.textBoxProfitTotal);
            this.Controls.Add(this.labelProfitTotal);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Actiunile mele";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBursaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBursaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dBBursaDataSetBindingSource;
        private DBBursaDataSet dBBursaDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denumire;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumarActiuni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValoareInitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValoareMomentan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValoareModif;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalInitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMomentan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitMomentan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitTotal;
        private System.Windows.Forms.Label labelProfitTotal;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textBoxProfitTotal;
    }
}