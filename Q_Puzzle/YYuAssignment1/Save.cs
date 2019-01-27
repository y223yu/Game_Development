using System;
using System.Windows.Forms;
using System.IO;

namespace YYuAssignment1
{
    class Save
    {
        public Save() { }

        /*Save the 'int[,] mart' to a .txt file*/
        public Save(Panel p, SaveFileDialog sfd, int r, int c, int[,] _mark)
        {
            if (p.Visible == false) //error when user stores empty maze
            {
                MessageBox.Show("The maze is empty.");
            }
            else
            {
                //error when doors and boxes not match
                if ((r * c) % 2 == 0 && CheckMatching(_mark) % 2 != 0)
                {
                    MessageBox.Show("Error: doors are NOT match boxes.");
                }
                else if ((r * c) % 2 != 0 && CheckMatching(_mark) % 2 != 0)
                {
                    MessageBox.Show("Error: doors are NOT match boxes.");
                }
                //performing saving process after checking errors
                else
                {
                    DialogResult result = sfd.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            string fileName = sfd.FileName + "_" + DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + ".txt";
                            StreamWriter sw = new StreamWriter(fileName);
                            for (int m = 0; m < r; m++)
                            {
                                for (int n = 0; n < c; n++)
                                {
                                    sw.Write(_mark[m, n]);
                                }
                                sw.WriteLine();
                            }
                            sw.Close();
                            MessageBox.Show("Saving completed.");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error in file saving.");
                        }
                    }
                }
            }
        }

        /*roughly check if colored doors match colored boxes*/
        public int CheckMatching(int[,] m)
        {
            //get the length of 2D array without 0 and 1
            int lengthWihoutZeroOne = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i, j] == 0)
                    {
                        continue;
                    }
                    if (m[i, j] == 1)
                    {
                        continue;
                    }
                    lengthWihoutZeroOne++;
                }
            }
            return lengthWihoutZeroOne;
        }
    }
}
