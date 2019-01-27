using System.Drawing;
using System.Windows.Forms;

namespace YYuAssignment1
{
    public enum PictureType
    {
        None,
        Wall,
        Reddoor,
        Greendoor,
        Bluedoor,
        Yellowdoor,
        Redbird,
        Greenbird,
        Bluebird,
        Yellowbird
    }

    class Cells : PictureBox
    {
        private PictureType pType;
        private int x;
        private int y;

        public PictureType PType
        {
            set { pType = value; }
            get { return pType; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        /*default constructor*/
        public Cells() { }

        /*constructor to create the grid*/
        public Cells(int r, int c)
        {
            this.Location = new Point(c * 70 + 20, r * 70 + 20);
            this.Width = 70;
            this.Height = 70;

            //important - to recognize postion of each cell in the 2D array:
            this.X = r;
            this.Y = c;

            this.BorderStyle = BorderStyle.FixedSingle;
            this.BringToFront();
            this.SizeMode = PictureBoxSizeMode.Zoom;
        }

        /*method for change picture of a cell in grid*/
        //use X and Y to locate and assgin 0-9 to each cell of int[,] mark
        public void ReplacePicture(int m, int n, PictureType pt, Cells c, int[,] mark)
        {
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (pt == PictureType.None)
                    {
                        c.Image = null;
                        mark[c.X, c.Y] = 0;
                        break;
                    }
                    else if (pt == PictureType.Wall)
                    {
                        c.Image = YYuAssignment1.Properties.Resources.wall;
                        mark[c.X, c.Y] = 1;
                        break;
                    }
                    else if (pt == PictureType.Reddoor)
                    {
                        c.Image = YYuAssignment1.Properties.Resources.reddoor;
                        mark[c.X, c.Y] = 2;
                        break;
                    }
                    else if (pt == PictureType.Greendoor)
                    {
                        c.Image = YYuAssignment1.Properties.Resources.greendoor;
                        mark[c.X, c.Y] = 3;
                        break;
                    }
                    else if (pt == PictureType.Bluedoor)
                    {
                        c.Image = YYuAssignment1.Properties.Resources.bluedoor;
                        mark[c.X, c.Y] = 4;
                        break;
                    }
                    else if (pt == PictureType.Yellowdoor)
                    {
                        c.Image = YYuAssignment1.Properties.Resources.yellowdoor;
                        mark[c.X, c.Y] = 5;
                        break;
                    }
                    else if (pt == PictureType.Redbird)
                    {
                        c.Image = YYuAssignment1.Properties.Resources.redbird;
                        mark[c.X, c.Y] = 6;
                        break;
                    }
                    else if (pt == PictureType.Greenbird)
                    {
                        c.Image = YYuAssignment1.Properties.Resources.greenbird;
                        mark[c.X, c.Y] = 7;
                        break;
                    }
                    else if (pt == PictureType.Bluebird)
                    {
                        c.Image = YYuAssignment1.Properties.Resources.bluebird;
                        mark[c.X, c.Y] = 8;
                        break;
                    }
                    else if (pt == PictureType.Yellowbird)
                    {
                        c.Image = YYuAssignment1.Properties.Resources.yellowbird;
                        mark[c.X, c.Y] = 9;
                        break;
                    }
                }
            }
        }
    }
}
