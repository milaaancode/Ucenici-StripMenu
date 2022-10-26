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
    public partial class Form1 : Form
    {
        Queue<Ucenik> queue = new Queue<Ucenik>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 forma = new Form3(queue);
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 forma = new Form2(queue);
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (queue.Count>0)
            {
                queue.Dequeue();
            }
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }
    }
}
