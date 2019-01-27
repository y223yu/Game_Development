namespace YYuAssignment1
{
    partial class Maze_Designer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maze_Designer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelRows = new System.Windows.Forms.Label();
            this.textBoxRows = new System.Windows.Forms.TextBox();
            this.textBoxColumns = new System.Windows.Forms.TextBox();
            this.labelColumns = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelToolBox = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonYellobird = new System.Windows.Forms.Button();
            this.buttonBluebird = new System.Windows.Forms.Button();
            this.buttonGreenBird = new System.Windows.Forms.Button();
            this.buttonRedBird = new System.Windows.Forms.Button();
            this.buttonYellowdoor = new System.Windows.Forms.Button();
            this.buttonBluedoor = new System.Windows.Forms.Button();
            this.buttonGreendoor = new System.Windows.Forms.Button();
            this.buttonReddoor = new System.Windows.Forms.Button();
            this.buttonWall = new System.Windows.Forms.Button();
            this.buttonNull = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1416, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRows.Location = new System.Drawing.Point(207, 56);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(66, 25);
            this.labelRows.TabIndex = 1;
            this.labelRows.Text = "Rows:";
            this.labelRows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRows
            // 
            this.textBoxRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRows.Location = new System.Drawing.Point(279, 53);
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.Size = new System.Drawing.Size(100, 30);
            this.textBoxRows.TabIndex = 2;
            this.textBoxRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxColumns
            // 
            this.textBoxColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColumns.Location = new System.Drawing.Point(487, 53);
            this.textBoxColumns.Name = "textBoxColumns";
            this.textBoxColumns.Size = new System.Drawing.Size(100, 30);
            this.textBoxColumns.TabIndex = 4;
            this.textBoxColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumns.Location = new System.Drawing.Point(385, 56);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(96, 25);
            this.labelColumns.TabIndex = 3;
            this.labelColumns.Text = "Columns:";
            this.labelColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(609, 49);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(150, 38);
            this.buttonGenerate.TabIndex = 5;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.Location = new System.Drawing.Point(202, 94);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1202, 800);
            this.panelGrid.TabIndex = 6;
            this.panelGrid.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "frame.jpg");
            this.imageList1.Images.SetKeyName(1, "wall.jpg");
            this.imageList1.Images.SetKeyName(2, "reddoor.jpg");
            this.imageList1.Images.SetKeyName(3, "greendoor.jpg");
            this.imageList1.Images.SetKeyName(4, "bluedoor.jpg");
            this.imageList1.Images.SetKeyName(5, "yellowdoor.jpg");
            this.imageList1.Images.SetKeyName(6, "redbird.jpg");
            this.imageList1.Images.SetKeyName(7, "greenbird.jpg");
            this.imageList1.Images.SetKeyName(8, "bluebird.jpg");
            this.imageList1.Images.SetKeyName(9, "yellowbird.jpg");
            // 
            // labelToolBox
            // 
            this.labelToolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToolBox.Location = new System.Drawing.Point(6, 0);
            this.labelToolBox.Name = "labelToolBox";
            this.labelToolBox.Size = new System.Drawing.Size(149, 31);
            this.labelToolBox.TabIndex = 7;
            this.labelToolBox.Text = "Tool Box";
            this.labelToolBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.buttonYellobird);
            this.groupBox1.Controls.Add(this.buttonBluebird);
            this.groupBox1.Controls.Add(this.buttonGreenBird);
            this.groupBox1.Controls.Add(this.buttonRedBird);
            this.groupBox1.Controls.Add(this.buttonYellowdoor);
            this.groupBox1.Controls.Add(this.buttonBluedoor);
            this.groupBox1.Controls.Add(this.buttonGreendoor);
            this.groupBox1.Controls.Add(this.buttonReddoor);
            this.groupBox1.Controls.Add(this.buttonWall);
            this.groupBox1.Controls.Add(this.buttonNull);
            this.groupBox1.Controls.Add(this.labelToolBox);
            this.groupBox1.Location = new System.Drawing.Point(21, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 849);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // buttonYellobird
            // 
            this.buttonYellobird.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYellobird.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonYellobird.ImageIndex = 9;
            this.buttonYellobird.ImageList = this.imageList1;
            this.buttonYellobird.Location = new System.Drawing.Point(6, 763);
            this.buttonYellobird.Name = "buttonYellobird";
            this.buttonYellobird.Size = new System.Drawing.Size(157, 75);
            this.buttonYellobird.TabIndex = 17;
            this.buttonYellobird.Text = "Yellow\r\nBird";
            this.buttonYellobird.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonYellobird.UseVisualStyleBackColor = true;
            this.buttonYellobird.Click += new System.EventHandler(this.buttonYellobird_Click);
            // 
            // buttonBluebird
            // 
            this.buttonBluebird.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBluebird.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBluebird.ImageIndex = 8;
            this.buttonBluebird.ImageList = this.imageList1;
            this.buttonBluebird.Location = new System.Drawing.Point(6, 682);
            this.buttonBluebird.Name = "buttonBluebird";
            this.buttonBluebird.Size = new System.Drawing.Size(157, 75);
            this.buttonBluebird.TabIndex = 16;
            this.buttonBluebird.Text = "Blue\r\nBird";
            this.buttonBluebird.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBluebird.UseVisualStyleBackColor = true;
            this.buttonBluebird.Click += new System.EventHandler(this.buttonBluebird_Click);
            // 
            // buttonGreenBird
            // 
            this.buttonGreenBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGreenBird.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGreenBird.ImageIndex = 7;
            this.buttonGreenBird.ImageList = this.imageList1;
            this.buttonGreenBird.Location = new System.Drawing.Point(6, 601);
            this.buttonGreenBird.Name = "buttonGreenBird";
            this.buttonGreenBird.Size = new System.Drawing.Size(157, 75);
            this.buttonGreenBird.TabIndex = 15;
            this.buttonGreenBird.Text = "Green\r\nBird";
            this.buttonGreenBird.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGreenBird.UseVisualStyleBackColor = true;
            this.buttonGreenBird.Click += new System.EventHandler(this.buttonGreenBird_Click);
            // 
            // buttonRedBird
            // 
            this.buttonRedBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedBird.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRedBird.ImageIndex = 6;
            this.buttonRedBird.ImageList = this.imageList1;
            this.buttonRedBird.Location = new System.Drawing.Point(6, 520);
            this.buttonRedBird.Name = "buttonRedBird";
            this.buttonRedBird.Size = new System.Drawing.Size(157, 75);
            this.buttonRedBird.TabIndex = 14;
            this.buttonRedBird.Text = "Red\r\nBird";
            this.buttonRedBird.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRedBird.UseVisualStyleBackColor = true;
            this.buttonRedBird.Click += new System.EventHandler(this.buttonRedBird_Click);
            // 
            // buttonYellowdoor
            // 
            this.buttonYellowdoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYellowdoor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonYellowdoor.ImageIndex = 5;
            this.buttonYellowdoor.ImageList = this.imageList1;
            this.buttonYellowdoor.Location = new System.Drawing.Point(6, 439);
            this.buttonYellowdoor.Name = "buttonYellowdoor";
            this.buttonYellowdoor.Size = new System.Drawing.Size(157, 75);
            this.buttonYellowdoor.TabIndex = 13;
            this.buttonYellowdoor.Text = "Yellow\r\nDoor";
            this.buttonYellowdoor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonYellowdoor.UseVisualStyleBackColor = true;
            this.buttonYellowdoor.Click += new System.EventHandler(this.buttonYellowdoor_Click);
            // 
            // buttonBluedoor
            // 
            this.buttonBluedoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBluedoor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBluedoor.ImageIndex = 4;
            this.buttonBluedoor.ImageList = this.imageList1;
            this.buttonBluedoor.Location = new System.Drawing.Point(6, 358);
            this.buttonBluedoor.Name = "buttonBluedoor";
            this.buttonBluedoor.Size = new System.Drawing.Size(157, 75);
            this.buttonBluedoor.TabIndex = 12;
            this.buttonBluedoor.Text = "Blue\r\nDoor";
            this.buttonBluedoor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBluedoor.UseVisualStyleBackColor = true;
            this.buttonBluedoor.Click += new System.EventHandler(this.buttonBluedoor_Click);
            // 
            // buttonGreendoor
            // 
            this.buttonGreendoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGreendoor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGreendoor.ImageIndex = 3;
            this.buttonGreendoor.ImageList = this.imageList1;
            this.buttonGreendoor.Location = new System.Drawing.Point(6, 277);
            this.buttonGreendoor.Name = "buttonGreendoor";
            this.buttonGreendoor.Size = new System.Drawing.Size(157, 75);
            this.buttonGreendoor.TabIndex = 11;
            this.buttonGreendoor.Text = "Green\r\nDoor";
            this.buttonGreendoor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGreendoor.UseVisualStyleBackColor = true;
            this.buttonGreendoor.Click += new System.EventHandler(this.buttonGreendoor_Click);
            // 
            // buttonReddoor
            // 
            this.buttonReddoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReddoor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReddoor.ImageIndex = 2;
            this.buttonReddoor.ImageList = this.imageList1;
            this.buttonReddoor.Location = new System.Drawing.Point(6, 196);
            this.buttonReddoor.Name = "buttonReddoor";
            this.buttonReddoor.Size = new System.Drawing.Size(157, 75);
            this.buttonReddoor.TabIndex = 10;
            this.buttonReddoor.Text = "Red\r\nDoor";
            this.buttonReddoor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReddoor.UseVisualStyleBackColor = true;
            this.buttonReddoor.Click += new System.EventHandler(this.buttonReddoor_Click);
            // 
            // buttonWall
            // 
            this.buttonWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWall.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonWall.ImageIndex = 1;
            this.buttonWall.ImageList = this.imageList1;
            this.buttonWall.Location = new System.Drawing.Point(6, 115);
            this.buttonWall.Name = "buttonWall";
            this.buttonWall.Size = new System.Drawing.Size(157, 75);
            this.buttonWall.TabIndex = 9;
            this.buttonWall.Text = "Wall";
            this.buttonWall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWall.UseVisualStyleBackColor = true;
            this.buttonWall.Click += new System.EventHandler(this.buttonWall_Click);
            // 
            // buttonNull
            // 
            this.buttonNull.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNull.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNull.ImageIndex = 0;
            this.buttonNull.ImageList = this.imageList1;
            this.buttonNull.Location = new System.Drawing.Point(6, 34);
            this.buttonNull.Name = "buttonNull";
            this.buttonNull.Size = new System.Drawing.Size(157, 75);
            this.buttonNull.TabIndex = 8;
            this.buttonNull.Text = "None";
            this.buttonNull.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNull.UseVisualStyleBackColor = true;
            this.buttonNull.Click += new System.EventHandler(this.buttonNull_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "qPuzzle";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Maze_Designer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 914);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxColumns);
            this.Controls.Add(this.labelColumns);
            this.Controls.Add(this.textBoxRows);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Maze_Designer";
            this.Text = "Maze_Designer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.TextBox textBoxRows;
        private System.Windows.Forms.TextBox textBoxColumns;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelToolBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRedBird;
        private System.Windows.Forms.Button buttonYellowdoor;
        private System.Windows.Forms.Button buttonBluedoor;
        private System.Windows.Forms.Button buttonGreendoor;
        private System.Windows.Forms.Button buttonReddoor;
        private System.Windows.Forms.Button buttonWall;
        private System.Windows.Forms.Button buttonNull;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Button buttonYellobird;
        private System.Windows.Forms.Button buttonBluebird;
        private System.Windows.Forms.Button buttonGreenBird;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}