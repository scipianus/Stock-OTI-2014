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

namespace Bursa_Nume_Prenume
{
    public partial class Form2 : Form
    {
        private SqlCeConnection conexiune;
        private SqlCeCommand comanda;
        private SqlCeDataReader reader;
        public int[] valoarenow, modifnow;
        public int nrrows;
        Form1 formfather;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1)
        {
            InitializeComponent();

            formfather = form1;
            string connstring = formfather.connstring;
            conexiune = new SqlCeConnection(connstring);
            conexiune.Open();
            formfather.afisat = true;
            valoarenow = formfather.valoarenow;
            modifnow = formfather.modifnow;
            nrrows = formfather.nrrows;
            Afisare();
            conexiune.Close();
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

        private void Afisare()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            string query = "SELECT * FROM Actiuni";
            comanda = new SqlCeCommand(query, conexiune);
            reader = comanda.ExecuteReader();
            while (reader.Read())
            {
                string[] line = new string[9];
                line[0] = reader["Denumire"].ToString();
                line[1] = reader["NrActiuni"].ToString();
                line[2] = reader["Valoare"].ToString();
                line[3] = valoarenow[i].ToString();
                line[4] = modifnow[i].ToString();
                line[5] = (Number(line[1].ToString()) * Number(line[2].ToString())).ToString();
                line[6] = (Number(line[1].ToString()) * Number(line[3].ToString())).ToString();
                line[7] = (Number(line[1].ToString()) * Number(line[4].ToString())).ToString();
                line[8] = (Number(line[6].ToString()) - Number(line[5].ToString())).ToString();
                dataGridView1.Rows.Add(line);
                i++;
            }
            reader.Close();
            int total = 0;
            for (i = 0; i < nrrows; ++i)
                total += Number(dataGridView1[8, i].Value.ToString());
            textBoxProfitTotal.Text = total.ToString();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            formfather.afisat = false;
        }

    }
}
