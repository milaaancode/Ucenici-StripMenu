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
    public partial class Form3 : Form
    {

        Queue<Ucenik> queue;
        public Form3(Queue<Ucenik> q)
        {
            InitializeComponent();
            queue = q;
            var a = q.ToArray();
            listBox1.Items.Clear();
            foreach (var item in a)
            {
                listBox1.Items.Add("Ime i prezime: " + item.Ime + " " + item.Prezime + " Broj Telefona: " + item.BrojTelefona);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = queue.ToArray();
            listBox1.Items.Clear();
            string b = textBox1.Text;
            foreach (var item in a)
            {
                if (item.Prezime.Contains(b) || item.BrojTelefona.Contains(b))
                    listBox1.Items.Add("Ime i prezime: " + item.Ime + " " + item.Prezime + " Broj Telefona: " + item.BrojTelefona);
            }
        }
    }
}
