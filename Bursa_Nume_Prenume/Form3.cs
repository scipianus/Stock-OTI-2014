using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bursa_Nume_Prenume
{
    public partial class Form3 : Form
    {
        private Form1 formfather;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 form1)
        {
            InitializeComponent();
            formfather = form1;
            formfather.grafic = true;
            foreach (DataPoint p in formfather.chart1.Series[0].Points)
                grafic.Series[0].Points.Add(p);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            formfather.grafic = false;
        }

    }
}
