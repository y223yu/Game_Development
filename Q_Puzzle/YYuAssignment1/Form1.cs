using System;
using System.Windows.Forms;

namespace YYuAssignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDesign_Click(object sender, EventArgs e)
        {
            Maze_Designer frm2 = new Maze_Designer();
            frm2.Show();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            QPuzzle_Play qp = new QPuzzle_Play();
            qp.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
