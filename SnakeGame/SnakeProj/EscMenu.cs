using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnakeProj
{
    public partial class EscMenu : Form
    {
        public EscMenu()
        {
            InitializeComponent();
        }

        private void EscMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 a = new Form2();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 a = new Form2();
            a.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.ShowDialog();
            this.Close();
        }
    }
}
