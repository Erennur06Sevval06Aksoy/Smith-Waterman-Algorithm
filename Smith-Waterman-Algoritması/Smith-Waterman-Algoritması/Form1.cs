using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Smith_Waterman_Algoritması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Start();
        }
        string[] data1 = System.IO.File.ReadAllLines("C:\\Users\\aksoy\\OneDrive\\Masaüstü\\Biyoinformatik\\seq1.txt");
        string[] data2 = System.IO.File.ReadAllLines("C:\\Users\\aksoy\\OneDrive\\Masaüstü\\Biyoinformatik\\seq2.txt");

        int value, value_1, value_2, value_3, selected_value;

        //Use timer
        Stopwatch timer = new Stopwatch();
        private void btn_insert_data_Click(object sender, EventArgs e)
        {
            int piece1 = Convert.ToInt32(data1[0]);
            int piece2 = Convert.ToInt32(data2[0]);
            dataGridView1.ColumnCount = piece1 + 1;
            dataGridView1.RowCount = piece2 + 1;

            int matchPenalty = 1;
            int misMatchPenalty = -1;
            int gapPenalty = -2;

            if (txt_match.Text == "")
                matchPenalty = 1;
            else
                matchPenalty = Convert.ToInt32(txt_match.Text);

            if (txt_mismatch.Text == "")
                misMatchPenalty = -1;
            else
                misMatchPenalty = Convert.ToInt32(txt_mismatch.Text);

            if (txt_gap.Text == "")
                gapPenalty = -2;
            else
                gapPenalty = Convert.ToInt32(txt_gap.Text);

            for (int i = 0; i < piece1; i++)
            {
                dataGridView1.Columns[i + 1].Name = (i + 1) + ". Sütun";
            }

            //data1 is separated by spaces and kept in character1 variable
            string[] character1 = data1[1].Split(' ');
            for (int p = 0; p < piece1; p++)
            {
                txt_seq1.Text = txt_seq1.Text + character1[p];
            }

            //data2 is separated by spaces and kept in character2 variable
            string[] character2 = data2[1].Split(' ');
            for (int r = 0; r < piece2; r++)
            {
                txt_seq2.Text = txt_seq2.Text + character2[r];
            }

            //0 start to corner
            dataGridView1.Rows[0].Cells[0].Value = 0;

            //fill the first row and column
            for (int q = 1; q <= piece1; q++)
            {
                value += gapPenalty;
                if (value < 0)
                    value = 0;
                dataGridView1.Rows[0].Cells[q].Value = value;
            }
            value = 0;
            for (int q = 1; q <= piece2; q++)
            {
                value += gapPenalty;
                if (value < 0)
                    value = 0;
                dataGridView1.Rows[q].Cells[0].Value = value;
            }

            //Calculating the maximum penalty
            for (int m = 1; m <= piece1; m++)
            {
                for (int n = 1; n <= piece2; n++)
                {
                    if (character1[m - 1] == character2[n - 1])
                    {
                        value_1 = Convert.ToInt32(dataGridView1.Rows[n - 1].Cells[m - 1].Value) + matchPenalty;
                    }
                    else
                    {
                        value_1 = Convert.ToInt32(dataGridView1.Rows[n - 1].Cells[m - 1].Value) + misMatchPenalty;
                    }

                    //top case
                    value_2 = Convert.ToInt32(dataGridView1.Rows[n - 1].Cells[m].Value) + gapPenalty;
                    //left case
                    value_3 = Convert.ToInt32(dataGridView1.Rows[n].Cells[m - 1].Value) + gapPenalty;

                    //choosing the maximum penalty
                    selected_value = Math.Max(Math.Max(value_1, value_2), value_3);
                    if (selected_value < 0)
                        selected_value = 0;
                    dataGridView1.Rows[n].Cells[m].Value = selected_value;
                }
            }
            //selected_lists.Reverse();

            for (int m = piece1; m >= 1; m--)
            {
                for (int n = piece2; n >= 1; n--)
                {
                    if (character1[m - 1] == character2[n - 1])
                    {
                        value_1 = Convert.ToInt32(dataGridView1.Rows[n - 1].Cells[m - 1].Value);
                    }
                    else
                    {
                        value_1 = Convert.ToInt32(dataGridView1.Rows[n - 1].Cells[m - 1].Value);
                        value_2 = Convert.ToInt32(dataGridView1.Rows[n - 1].Cells[m].Value);
                        value_3 = Convert.ToInt32(dataGridView1.Rows[n].Cells[m - 1].Value);
                    }
                    //choosing the maximum penalty
                    selected_value = Math.Max(Math.Max(value_1, value_2), value_3);
                    txt_alignment.Text = selected_value.ToString();
                }
            }
            //Fint the same value
            List<string> selected_lists = new List<string>();

            int missing_value;
            if (piece1 > piece2)
            {
                for (int i = piece2-1; i >= 0; i--)
                {
                    missing_value = piece1 - piece2;
                    if (character1[i + missing_value] == character2[i])
                        selected_lists.Add(character2[i]);
                    else
                        selected_lists.Add("-");
                }
            }
            if (piece1 < piece2)
            {
                for (int i = piece1-1; i >= 0; i--)
                {
                    missing_value = piece2 - piece1;
                    if (character1[i] == character2[i + missing_value])
                        selected_lists.Add(character1[i]);
                    else
                        selected_lists.Add("-");
                }
            }
            if (piece1 == piece2)
            {
                for (int i = piece1 - 1; i >= 0; i--)
                {
                    if (character1[i] == character2[i])
                        selected_lists.Add(character1[i]);
                    else
                        selected_lists.Add("-");
                }
            }
            selected_lists.Reverse();
            foreach (string item in selected_lists)
            {
                txt_write_list.AppendText(item + Environment.NewLine);
            }

            timer.Stop();
            lbl_timer.Text = timer.Elapsed.Seconds.ToString() + " sn";
        }
    }
}
