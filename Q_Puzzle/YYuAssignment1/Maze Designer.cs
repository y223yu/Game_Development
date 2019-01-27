using System;
using System.Windows.Forms;

namespace YYuAssignment1
{
    public partial class Maze_Designer : Form
    {
        int rows;
        int columns;
        int[,] mark; //will be stored into .txt file

        PictureType pt;

        public Maze_Designer()
        {
            InitializeComponent();
        }

        /*START: Create the maze*/
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            panelGrid.Controls.Clear();

            //check if user's inputs are integers
            if((!int.TryParse(textBoxRows.Text.Trim(), out rows)) || (!int.TryParse(textBoxColumns.Text.Trim(), out rows)))
            {
                MessageBox.Show("Please only enter integers.");
            }
            //call Cells class
            else
            {
                rows = Convert.ToInt16(textBoxRows.Text);
                columns = Convert.ToInt16(textBoxColumns.Text);

                mark = new int[rows, columns];
                Cells[,] myCells = new Cells[rows, columns];

                panelGrid.Visible = true; 
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        myCells[i, j] = new Cells(i, j);
                        myCells[i, j].Click += MyPictureBox_Click;
                        panelGrid.Controls.Add(myCells[i, j]);
                    }
                }
            }
        }

        private void buttonNull_Click(object sender, EventArgs e)
        {
            pt = PictureType.None;
        }
        private void buttonWall_Click(object sender, EventArgs e)
        {
            pt = PictureType.Wall;
        }
        private void buttonReddoor_Click(object sender, EventArgs e)
        {
            pt = PictureType.Reddoor;
        }
        private void buttonGreendoor_Click(object sender, EventArgs e)
        {
            pt = PictureType.Greendoor;
        }
        private void buttonBluedoor_Click(object sender, EventArgs e)
        {
            pt = PictureType.Bluedoor;
        }
        private void buttonYellowdoor_Click(object sender, EventArgs e)
        {
            pt = PictureType.Yellowdoor;
        }
        private void buttonRedBird_Click(object sender, EventArgs e)
        {
            pt = PictureType.Redbird;
        }
        private void buttonGreenBird_Click(object sender, EventArgs e)
        {
            pt = PictureType.Greenbird;
        }
        private void buttonBluebird_Click(object sender, EventArgs e)
        {
            pt = PictureType.Bluebird;
        }
        private void buttonYellobird_Click(object sender, EventArgs e)
        {
            pt = PictureType.Yellowbird;
        }

        private void MyPictureBox_Click(object sender, EventArgs e)
        {
            //important--do NOT initialize mark again: mark = new int[rows, columns]; 
            Cells myCells = sender as Cells;
            myCells.ReplacePicture(rows, columns, pt, myCells, mark);
        }
        /*END: Create the maze*/

        /*START: save the maze as .txt file*/
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save mySave = new Save(panelGrid, saveFileDialog1, rows, columns, mark);
        }
        /*END: save the maze as .txt file*/

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
