using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bursa_Nume_Prenume
{
    public partial class Form1 : Form
    {
        private Timer t;
        private Form2 form2;
        private Form3 form3;
        private Random R;
        public int[] valoarenow, modifnow, valoareinit, nrinit;
        public int nrrows;
        public bool afisat, grafic;
        private double time;
        public string connstring;

        private SqlCeConnection conexiune;
        private SqlCeCommand comanda;
        private SqlCeDataReader reader;
        
        public Form1()
        {
            InitializeComponent();

            DirectoryInfo D = new DirectoryInfo(@"Bursa_Nume_Prenume.exe");
            string cale = D.FullName.ToString();
            int nc = cale.Length;
            int i = nc - 3;
            while (!(cale[i - 1] == '\\' && cale[i] == 'b' && cale[i + 1] == 'i' && cale[i + 2] == 'n'))
                i--;
            connstring = "DataSource=" + cale.Substring(0, i) + "DBBursa.sdf";

            conexiune = new SqlCeConnection(connstring);
            conexiune.Open();
            GetRows();
            conexiune.Close();

            chart1.Series[0].Points.AddXY(0, 0);
            afisat = grafic = false;
            time = 0.0;
            R = new Random();
            t = new Timer();
            t.Interval = (int)numericUpDownRefresh.Value;
            t.Tick += t_Tick;
        }

        void GetRows()
        {
            int i = 0;
            string query = "SELECT * FROM Actiuni";
            comanda = new SqlCeCommand(query, conexiune);
            reader = comanda.ExecuteReader();
            nrrows = 0;
            while (reader.Read())
                nrrows++;
            valoarenow = new int[nrrows];
            modifnow = new int[nrrows];
            valoareinit = new int[nrrows];
            nrinit = new int[nrrows];
            reader.Close();

            reader = comanda.ExecuteReader();
            while (reader.Read())
            {
                nrinit[i] = (int)reader["NrActiuni"];
                valoarenow[i] = valoareinit[i] = (int)reader["Valoare"];
                modifnow[i] = 0;
                i++;
            }
            reader.Close();
        }

        int Number(string s)
        {
            int x = 0, n = s.Length, semn, i = 0;
            if (s[0] == '-')
            {
                semn = -1;
                i++;
            }
            else
                semn = 1;
            while (i < n && '0' <= s[i] && s[i] <= '9')
            {
                x = x * 10 + s[i] - '0';
                i++;
            }
            return (x * semn);
        }

        void t_Tick(object sender, EventArgs e)
        {
            int now, i, total = 0;
            time += (double)numericUpDownRefresh.Value;
            for (i = 0; i < nrrows; ++i)
            {
                now = R.Next(-5, 6);
                modifnow[i] = now;
                valoarenow[i] += now;
                if (afisat)
                {
                    form2.dataGridView1[3, i].Value = valoarenow[i].ToString();
                    form2.dataGridView1[4, i].Value = modifnow[i].ToString();
                    form2.dataGridView1[6, i].Value = (nrinit[i] * valoarenow[i]).ToString();
                    form2.dataGridView1[7, i].Value = (nrinit[i] * modifnow[i]).ToString();
                    form2.dataGridView1[8, i].Value = (nrinit[i] * (valoarenow[i] - valoareinit[i])).ToString();
                }
                total += nrinit[i] * (valoarenow[i] - valoareinit[i]);
            }
            chart1.Series[0].Points.AddXY(time, total);
            if (afisat)
                form2.textBoxProfitTotal.Text = total.ToString();
            if (grafic)
                form3.grafic.Series[0].Points.AddXY(time, total);
        }

        private void numericUpDownRefresh_ValueChanged(object sender, EventArgs e)
        {
            t.Interval = (int)numericUpDownRefresh.Value;
        }

        private void buttonDeschidere_Click(object sender, EventArgs e)
        {
            t.Start();
            buttonInchidere.Enabled = true;
            buttonDeschidere.Enabled = false;
        }

        private void buttonInchidere_Click(object sender, EventArgs e)
        {
            t.Stop();
            buttonDeschidere.Enabled = true;
            buttonInchidere.Enabled = false;
            int total = 0, i;
            for (i = 0; i < nrrows; ++i)
                total += nrinit[i] * (valoarenow[i] - valoareinit[i]);
            StreamWriter fout = new StreamWriter("rezultate.txt");
            fout.WriteLine(total.ToString());
            fout.Close();
        }

        private void actiunileMeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2 = new Form2(this);
            form2.Show();
        }

        private void graficProfitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form3 = new Form3(this);
            form3.Show();
        }
    }
}
