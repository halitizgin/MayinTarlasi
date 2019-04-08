using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayınTarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Mayın Tarlası v1.00\nhttp://www.kodevreni.com\nKodlama: Ready", "Hakkında", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                System.Diagnostics.Process.Start("http://www.kodevreni.com");
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ArrayList mayinlar = new ArrayList();
        int gPuan = 0;

        private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinlar.Clear();
            tableLayoutPanel1.Controls.Clear();
            int oTarla = 81;
            int oMayin = 15;
            tableLayoutPanel1.ColumnCount = 9;
            int sayi = 0;
            Random rast = new Random();
            for (int i = 0; i < oMayin; i++)
            {
            uret:
                sayi = rast.Next(0, oTarla);
                if (mayinlar.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    mayinlar.Add(sayi);
                }
            }

            for (int i = 0; i < oTarla; i++)
            {
                Button button = new Button();
                button.Click += button_Click;
                if (mayinlar.Contains(i))
                {
                    button.Tag = -1;
                }
                else
                {
                    button.Tag = rast.Next(1, 20);
                }
                button.Size = new Size(50, 50);
                tableLayoutPanel1.Controls.Add(button);
            }
            label2.Text = "Mayın: " + oMayin.ToString();
            label3.Text = "Boyut: " + tableLayoutPanel1.ColumnCount + " x " + tableLayoutPanel1.ColumnCount;
            this.Size = new Size(tableLayoutPanel1.ColumnCount * 50 + 25, tableLayoutPanel1.ColumnCount * 50 + 110);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            if (int.Parse(tiklanan.Tag.ToString()) == -1)
            {
                tiklanan.BackgroundImage = Image.FromFile("mayin.jpg");
                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                {
                    if (int.Parse(tableLayoutPanel1.Controls[i].Tag.ToString()) == -1)
                    {
                        tableLayoutPanel1.Controls[i].Enabled = false;
                        tableLayoutPanel1.Controls[i].BackgroundImage = Image.FromFile("mayin.jpg");
                    }
                    else
                    {
                        tableLayoutPanel1.Controls[i].Enabled = false;
                        tableLayoutPanel1.Controls[i].Text = tableLayoutPanel1.Controls[i].Tag.ToString();
                    }
                }
            }
            else
            {
                tiklanan.Text = tiklanan.Tag.ToString();
                gPuan += int.Parse(tiklanan.Tag.ToString());
                label1.Text = "Puan: " + gPuan;
            }
        }

        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinlar.Clear();
            tableLayoutPanel1.Controls.Clear();
            int oTarla = 144;
            int oMayin = 70;
            int sayi = 0;
            tableLayoutPanel1.ColumnCount = 12;
            Random rast = new Random();
            for (int i = 0; i < oMayin; i++)
            {
            uret:
                sayi = rast.Next(0, oTarla);
                if (mayinlar.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    mayinlar.Add(sayi);
                }
                mayinlar.Add(sayi);
            }

            for (int i = 0; i < oTarla; i++)
            {
                Button button = new Button();
                button.Click += button_Click;
                if (mayinlar.Contains(i))
                {
                    button.Tag = -1;
                }
                else
                {
                    button.Tag = rast.Next(1, 20);
                }
                button.Size = new Size(50, 50);
                tableLayoutPanel1.Controls.Add(button);
            }
            label2.Text = "Mayın: " + oMayin.ToString();
            label3.Text = "Boyut: " + tableLayoutPanel1.ColumnCount + " x " + tableLayoutPanel1.ColumnCount;
            this.Size = new Size(tableLayoutPanel1.ColumnCount * 50 + 25, tableLayoutPanel1.ColumnCount * 50 + 110);
        }

        private void zorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinlar.Clear();
            tableLayoutPanel1.Controls.Clear();
            int oTarla = 225;
            int oMayin = 170;
            int sayi = 0;
            tableLayoutPanel1.ColumnCount = 15;
            Random rast = new Random();
            for (int i = 0; i < oMayin; i++)
            {
            uret:
                sayi = rast.Next(0, oTarla);
                if (mayinlar.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    mayinlar.Add(sayi);
                }
                mayinlar.Add(sayi);
            }

            for (int i = 0; i < oTarla; i++)
            {
                Button button = new Button();
                button.Click += button_Click;
                if (mayinlar.Contains(i))
                {
                    button.Tag = -1;
                }
                else
                {
                    button.Tag = rast.Next(1, 20);
                }
                button.Size = new Size(50, 50);
                tableLayoutPanel1.Controls.Add(button);
            }
            label2.Text = "Mayın: " + oMayin.ToString();
            label3.Text = "Boyut: " + tableLayoutPanel1.ColumnCount + " x " + tableLayoutPanel1.ColumnCount;
            this.Size = new Size(tableLayoutPanel1.ColumnCount * 50 + 25, tableLayoutPanel1.ColumnCount * 50 + 110);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
