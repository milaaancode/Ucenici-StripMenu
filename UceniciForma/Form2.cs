using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UceniciForma
{
    public partial class Form2 : Form
    {
        Queue<Ucenik> que = new Queue<Ucenik>();
        public Form2(Queue<Ucenik> q)
        {
            InitializeComponent();
            que = q;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (que.Count == 3)
            {
                err.Text = "Maksimalan  broj ucenika (3) je dostignut.";
                err.ForeColor = Color.Red;
                err.Visible = true;
                return;
            }

            que.Enqueue(new Ucenik(textBox1.Text, textBox2.Text, textBox3.Text));

            err.Text = "Ucenik je dodat u red.";
            err.ForeColor = Color.Green;
            err.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
