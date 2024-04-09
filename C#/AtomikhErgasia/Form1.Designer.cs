namespace AtomikhErgasia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            ellipse = new ToolStripMenuItem();
            circle = new ToolStripMenuItem();
            rectangle = new ToolStripMenuItem();
            triangle = new ToolStripMenuItem();
            square = new ToolStripMenuItem();
            pentagon = new ToolStripMenuItem();
            hexagon = new ToolStripMenuItem();
            heptagon = new ToolStripMenuItem();
            octagon = new ToolStripMenuItem();
            nonagon = new ToolStripMenuItem();
            color_pick = new Button();
            color_palette = new PictureBox();
            space = new PictureBox();
            eraser = new Button();
            clear = new Button();
            save = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_palette).BeginInit();
            ((System.ComponentModel.ISupportInitialize)space).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ellipse, circle, rectangle, triangle, square, pentagon, hexagon, heptagon, octagon, nonagon });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1904, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ellipse
            // 
            ellipse.Name = "ellipse";
            ellipse.Size = new Size(52, 20);
            ellipse.Text = "Ellipse";
            ellipse.Click += ellipse_Click;
            // 
            // circle
            // 
            circle.Name = "circle";
            circle.Size = new Size(49, 20);
            circle.Text = "Circle";
            circle.Click += circle_Click;
            // 
            // rectangle
            // 
            rectangle.Name = "rectangle";
            rectangle.Size = new Size(71, 20);
            rectangle.Text = "Rectangle";
            rectangle.Click += rectangle_Click;
            // 
            // triangle
            // 
            triangle.Name = "triangle";
            triangle.Size = new Size(60, 20);
            triangle.Text = "Triangle";
            triangle.Click += triangle_Click;
            // 
            // square
            // 
            square.Name = "square";
            square.Size = new Size(55, 20);
            square.Text = "Square";
            square.Click += square_Click;
            // 
            // pentagon
            // 
            pentagon.Name = "pentagon";
            pentagon.Size = new Size(70, 20);
            pentagon.Text = "Pentagon";
            pentagon.Click += pentagon_Click;
            // 
            // hexagon
            // 
            hexagon.Name = "hexagon";
            hexagon.Size = new Size(67, 20);
            hexagon.Text = "Hexagon";
            hexagon.Click += hexagon_Click;
            // 
            // heptagon
            // 
            heptagon.Name = "heptagon";
            heptagon.Size = new Size(72, 20);
            heptagon.Text = "Heptagon";
            heptagon.Click += heptagon_Click;
            // 
            // octagon
            // 
            octagon.Name = "octagon";
            octagon.Size = new Size(65, 20);
            octagon.Text = "Octagon";
            octagon.Click += octagon_Click;
            // 
            // nonagon
            // 
            nonagon.Name = "nonagon";
            nonagon.Size = new Size(69, 20);
            nonagon.Text = "Nonagon";
            nonagon.Click += nonagon_Click;
            // 
            // color_pick
            // 
            color_pick.BackColor = Color.Black;
            color_pick.Location = new Point(258, 42);
            color_pick.Name = "color_pick";
            color_pick.Size = new Size(22, 23);
            color_pick.TabIndex = 1;
            color_pick.UseVisualStyleBackColor = false;
            // 
            // color_palette
            // 
            color_palette.Image = (Image)resources.GetObject("color_palette.Image");
            color_palette.Location = new Point(12, 27);
            color_palette.Name = "color_palette";
            color_palette.Size = new Size(240, 52);
            color_palette.SizeMode = PictureBoxSizeMode.CenterImage;
            color_palette.TabIndex = 2;
            color_palette.TabStop = false;
            color_palette.MouseClick += color_palette_MouseClick;
            // 
            // space
            // 
            space.BackColor = Color.White;
            space.Location = new Point(12, 85);
            space.Name = "space";
            space.Size = new Size(1880, 944);
            space.TabIndex = 3;
            space.TabStop = false;
            space.Paint += space_Paint;
            space.MouseDown += space_MouseDown;
            space.MouseMove += space_MouseMove;
            space.MouseUp += space_MouseUp;
            // 
            // eraser
            // 
            eraser.BackColor = Color.White;
            eraser.ImageAlign = ContentAlignment.MiddleLeft;
            eraser.Location = new Point(286, 27);
            eraser.Name = "eraser";
            eraser.Size = new Size(75, 52);
            eraser.TabIndex = 4;
            eraser.Text = "Eraser";
            eraser.UseVisualStyleBackColor = false;
            eraser.Click += eraser_Click;
            // 
            // clear
            // 
            clear.Location = new Point(368, 27);
            clear.Name = "clear";
            clear.Size = new Size(75, 52);
            clear.TabIndex = 5;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // save
            // 
            save.Location = new Point(449, 27);
            save.Name = "save";
            save.Size = new Size(73, 51);
            save.TabIndex = 6;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(save);
            Controls.Add(clear);
            Controls.Add(eraser);
            Controls.Add(color_palette);
            Controls.Add(color_pick);
            Controls.Add(menuStrip1);
            Controls.Add(space);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)color_palette).EndInit();
            ((System.ComponentModel.ISupportInitialize)space).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem triangle;
        private ToolStripMenuItem square;
        private ToolStripMenuItem rectangle;
        private ToolStripMenuItem pentagon;
        private ToolStripMenuItem heptagon;
        private ToolStripMenuItem circle;
        private ToolStripMenuItem ellipse;
        private ToolStripMenuItem hexagon;
        private ToolStripMenuItem octagon;
        private ToolStripMenuItem nonagon;
        private Button color_pick;
        private PictureBox color_palette;
        private PictureBox space;
        private Button eraser;
        private Button clear;
        private Button save;
    }
}