using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace YYuAssignment1
{
    public partial class QPuzzle_Play : Form
    {
        int rows;
        int columns;
        int[,] markLoad;
        Cells[,] cells;

        Cells myC; //for the MyPictureBoxNew_Click function

        int moves = 0; //record the number that moving buttons are clicked
        int scores = 0; //get 100 when a bird is removed
        int birdsNumber = 0; //determine if the game is over

        int row; //row & col to mark the location of specific picturebox
        int col;
    
        public QPuzzle_Play()
        {
            InitializeComponent();
        }

        /*Start: Load the maze from txt file*/
        /// <summary>
        /// 1. read text file by a List; 2. convert List to 2-D int array and 2-D picturebox array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogPlay.ShowDialog();
            string fileName = openFileDialogPlay.FileName;

            //using a list to read the file data
            List<string> lines = new List<string>();
            try
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string markString = sr.ReadLine();

                        if (markString != "")
                        {
                            lines.Add(markString);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in file loading.");
            }

            //convert List<string> lines to int[,] markLoad
            rows = lines.Count;
            columns = lines[0].Length;

            markLoad = new int[rows, columns];
            cells = new Cells[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    markLoad[i, j] = Convert.ToInt16(lines[i].Substring(j, 1));

                    //calculate total number of birds
                    if(markLoad[i, j] > 5 && markLoad[i, j] < 10)
                    {
                        birdsNumber++;
                    }

                    cells[i, j] = new Cells(i, j); //cells must be instantialize before RefreshCellArray()
                }
            }

            //Load Cells[,] cells, and generate the maze
            RefreshCellArray();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    cells[i, j].Click += MyPictureBoxNew_Click;
                    panelPlay.Controls.Add(cells[i, j]);
                }
            }

            //re-set moves and scores for next game
            moves = 0;
            scores = 0;
            textBoxMoves.Text = "";
            textBoxScores.Text = "";
        }
        /*End: Load the maze from txt file*/

        /// <summary>
        /// call this function when: 1. load the map; 2. every time click a moving button
        /// </summary>
        private void RefreshCellArray()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (markLoad[i, j] == 0)
                    {
                        cells[i, j].PType = PictureType.None;
                        cells[i, j].Image = null;
                    }
                    if (markLoad[i, j] == 1)
                    {
                        cells[i, j].PType = PictureType.Wall;
                        cells[i, j].Image = YYuAssignment1.Properties.Resources.wall;
                    }
                    if (markLoad[i, j] == 2)
                    {
                        cells[i, j].PType = PictureType.Reddoor;
                        cells[i, j].Image = YYuAssignment1.Properties.Resources.reddoor;
                        cells[i, j].Tag = "Red"; //Tags are used to check a bird enters a same color door
                    }
                    if (markLoad[i, j] == 3)
                    {
                        cells[i, j].PType = PictureType.Greendoor;
                        cells[i, j].Image = YYuAssignment1.Properties.Resources.greendoor;
                        cells[i, j].Tag = "Green";
                    }
                    if (markLoad[i, j] == 4)
                    {
                        cells[i, j].PType = PictureType.Bluedoor;
                        cells[i, j].Image = YYuAssignment1.Properties.Resources.bluedoor;
                        cells[i, j].Tag = "Blue";
                    }
                    if (markLoad[i, j] == 5)
                    {
                        cells[i, j].PType = PictureType.Yellowdoor;
                        cells[i, j].Image = YYuAssignment1.Properties.Resources.yellowdoor;
                        cells[i, j].Tag = "Yellow";
                    }
                    if (markLoad[i, j] == 6)
                    {
                        cells[i, j].PType = PictureType.Redbird;
                        cells[i, j].Image = YYuAssignment1.Properties.Resources.redbird;
                        cells[i, j].Tag = "Red";
                    }
                    if (markLoad[i, j] == 7)
                    {
                        cells[i, j].PType = PictureType.Greenbird;
                        cells[i, j].Image = YYuAssignment1.Properties.Resources.greenbird;
                        cells[i, j].Tag = "Green";
                    }
                    if (markLoad[i, j] == 8)
                    {
                        cells[i, j].PType = PictureType.Bluebird;
                        cells[i, j].Image = YYuAssignment1.Properties.Resources.bluebird;
                        cells[i, j].Tag = "Blue";
                    }
                    if (markLoad[i, j] == 9)
                    {
                        cells[i, j].PType = PictureType.Yellowbird;
                        cells[i, j].Image = YYuAssignment1.Properties.Resources.yellowbird;
                        cells[i, j].Tag = "Yellow";
                    }
                }
            }
        }

        /// <summary>
        /// click to choose a picturebox to being moved
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPictureBoxNew_Click(object sender, EventArgs e)
        {
            myC = sender as Cells;

            //change border style back to origin
            foreach(PictureBox p in cells)
            {
                p.BorderStyle = BorderStyle.FixedSingle;
            }

            row = myC.X; //row & col to locate the clicking picturebox
            col = myC.Y;

            //ensure only birds can be clicked
            if(cells[row, col].PType == PictureType.Redbird ||
               cells[row, col].PType == PictureType.Greenbird ||
               cells[row, col].PType == PictureType.Bluebird ||
               cells[row, col].PType == PictureType.Yellowbird)
            {
                myC.BringToFront();
                myC.BorderStyle = BorderStyle.Fixed3D;

                buttonUp.Enabled = true;
                buttonDown.Enabled = true;
                buttonLeft.Enabled = true;
                buttonRight.Enabled = true;
            }
            else
            {
                MessageBox.Show("Only birds can be moved");
                buttonUp.Enabled = false;
                buttonDown.Enabled = false;
                buttonLeft.Enabled = false;
                buttonRight.Enabled = false;
            }
        }

        /*Start: moving picturebox to 4 directions*/
        /// <summary>
        /// a general method for recording moving steps and scores
        /// </summary>
        private void GeneralRecording()
        {
            //record the number of movements
            moves = moves + 1;
            textBoxMoves.Text = moves.ToString();
            //all bird cells disappear, game completed
            if (birdsNumber == 0)
            {
                panelPlay.Controls.Clear();
                MessageBox.Show("Congratulations! Mission completed!");
            }
        }

        /// <summary>
        /// move picturebox to left side (exchange the position of adjacent pictureboxes)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            int c = col;
            int temp;

            //re-build the int[,] markLoad, then re-load the pictures (the same below other 3 moving buttons)
            while (cells[row, c - 1].Image == null)
            {
                temp = markLoad[row, c];
                markLoad[row, c] = markLoad[row, c - 1];
                markLoad[row, c - 1] = temp;

                RefreshCellArray();

                c--;
            }
            //remove picture when door and bird match (the same below other 3 moving buttons)
            if (cells[row, c - 1].Tag == cells[row, c].Tag)
            {
                cells[row, c].Image = null;
                markLoad[row, c] = 0;

                scores = scores + 100;
                textBoxScores.Text = scores.ToString();

                birdsNumber--;
            }
            col = c; //make it happem that continue move one picturebox

            GeneralRecording();
        }

        /// <summary>
        /// move picturebox to right side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRight_Click(object sender, EventArgs e)
        {
            int c = col;
            int temp;
            while (cells[row, c + 1].Image == null)
            {
                temp = markLoad[row, c]; 
                markLoad[row, c] = markLoad[row, c + 1]; 
                markLoad[row, c + 1] = temp;

                RefreshCellArray();

                c++;
            }
            if (cells[row, c + 1].Tag == cells[row, c].Tag)
            {
                cells[row, c].Image = null;
                markLoad[row, c] = 0;

                scores = scores + 100;
                textBoxScores.Text = scores.ToString();

                birdsNumber--;
            }
            col = c;

            GeneralRecording();
        }

        /// <summary>
        /// move picturebox to up side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUp_Click(object sender, EventArgs e)
        {
            int r = row;
            int temp;
            while (cells[r - 1, col].Image == null)
            {
                temp = markLoad[r, col];
                markLoad[r, col] = markLoad[r - 1, col];
                markLoad[r - 1, col] = temp;

                RefreshCellArray();

                r--;
            }
            if (cells[r - 1, col].Tag == cells[r, col].Tag)
            {
                cells[r, col].Image = null;
                markLoad[r, col] = 0;

                scores = scores + 100;
                textBoxScores.Text = scores.ToString();

                birdsNumber--;
            }
            row = r;

            GeneralRecording();
        }

        /// <summary>
        /// move picturebox to down side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDown_Click(object sender, EventArgs e)
        {
            int r = row;
            int temp;
            while (cells[r + 1, col].Image == null)
            {
                temp = markLoad[r, col];
                markLoad[r, col] = markLoad[r + 1, col];
                markLoad[r + 1, col] = temp;

                RefreshCellArray();

                r++;
            }
            if (cells[r + 1, col].Tag == cells[r, col].Tag)
            {
                cells[r, col].Image = null;
                markLoad[r, col] = 0;

                scores = scores + 100;
                textBoxScores.Text = scores.ToString();

                birdsNumber--;
            }
            row = r;

            GeneralRecording();
        }

        /// <summary>
        /// close the game interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
