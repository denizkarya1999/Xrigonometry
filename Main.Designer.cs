namespace Xrigonometry
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            sphereButton = new Button();
            triangleButton = new Button();
            squareButton = new Button();
            Rectanglebutton = new Button();
            polygonButton = new Button();
            pentagonButton = new Button();
            hexagonButton = new Button();
            circleButton = new Button();
            shapesGroupBox = new GroupBox();
            groupBox1 = new GroupBox();
            rightTriangleButton = new Button();
            indicator = new Label();
            toolStrip1 = new ToolStrip();
            aboutButton = new ToolStripLabel();
            shapesGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // sphereButton
            // 
            sphereButton.Location = new Point(22, 29);
            sphereButton.Name = "sphereButton";
            sphereButton.Size = new Size(75, 23);
            sphereButton.TabIndex = 0;
            sphereButton.Text = "Sphere";
            sphereButton.UseVisualStyleBackColor = true;
            sphereButton.Click += sphereButton_Click;
            // 
            // triangleButton
            // 
            triangleButton.Location = new Point(22, 58);
            triangleButton.Name = "triangleButton";
            triangleButton.Size = new Size(75, 23);
            triangleButton.TabIndex = 1;
            triangleButton.Text = "Triangle";
            triangleButton.UseVisualStyleBackColor = true;
            triangleButton.Click += triangleButton_Click;
            // 
            // squareButton
            // 
            squareButton.Location = new Point(22, 87);
            squareButton.Name = "squareButton";
            squareButton.Size = new Size(75, 23);
            squareButton.TabIndex = 2;
            squareButton.Text = "Square";
            squareButton.UseVisualStyleBackColor = true;
            squareButton.Click += squareButton_Click;
            // 
            // Rectanglebutton
            // 
            Rectanglebutton.Location = new Point(22, 116);
            Rectanglebutton.Name = "Rectanglebutton";
            Rectanglebutton.Size = new Size(75, 23);
            Rectanglebutton.TabIndex = 3;
            Rectanglebutton.Text = "Rectangle";
            Rectanglebutton.UseVisualStyleBackColor = true;
            Rectanglebutton.Click += Rectanglebutton_Click;
            // 
            // polygonButton
            // 
            polygonButton.Location = new Point(22, 145);
            polygonButton.Name = "polygonButton";
            polygonButton.Size = new Size(75, 23);
            polygonButton.TabIndex = 4;
            polygonButton.Text = "Polygon";
            polygonButton.UseVisualStyleBackColor = true;
            polygonButton.Click += polygonButton_Click;
            // 
            // pentagonButton
            // 
            pentagonButton.Location = new Point(22, 174);
            pentagonButton.Name = "pentagonButton";
            pentagonButton.Size = new Size(75, 23);
            pentagonButton.TabIndex = 5;
            pentagonButton.Text = "Pentagon";
            pentagonButton.UseVisualStyleBackColor = true;
            pentagonButton.Click += pentagonButton_Click;
            // 
            // hexagonButton
            // 
            hexagonButton.Location = new Point(22, 203);
            hexagonButton.Name = "hexagonButton";
            hexagonButton.Size = new Size(75, 23);
            hexagonButton.TabIndex = 6;
            hexagonButton.Text = "Hexagon";
            hexagonButton.UseVisualStyleBackColor = true;
            hexagonButton.Click += hexagonButton_Click;
            // 
            // circleButton
            // 
            circleButton.Location = new Point(22, 232);
            circleButton.Name = "circleButton";
            circleButton.Size = new Size(75, 23);
            circleButton.TabIndex = 7;
            circleButton.Text = "Circle";
            circleButton.UseVisualStyleBackColor = true;
            circleButton.Click += circleButton_Click;
            // 
            // shapesGroupBox
            // 
            shapesGroupBox.Controls.Add(squareButton);
            shapesGroupBox.Controls.Add(circleButton);
            shapesGroupBox.Controls.Add(sphereButton);
            shapesGroupBox.Controls.Add(hexagonButton);
            shapesGroupBox.Controls.Add(triangleButton);
            shapesGroupBox.Controls.Add(pentagonButton);
            shapesGroupBox.Controls.Add(Rectanglebutton);
            shapesGroupBox.Controls.Add(polygonButton);
            shapesGroupBox.Location = new Point(12, 33);
            shapesGroupBox.Name = "shapesGroupBox";
            shapesGroupBox.Size = new Size(118, 277);
            shapesGroupBox.TabIndex = 8;
            shapesGroupBox.TabStop = false;
            shapesGroupBox.Text = "Shapes";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rightTriangleButton);
            groupBox1.Location = new Point(12, 322);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(118, 94);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Specific Shapes ";
            // 
            // rightTriangleButton
            // 
            rightTriangleButton.Location = new Point(22, 29);
            rightTriangleButton.Name = "rightTriangleButton";
            rightTriangleButton.Size = new Size(75, 48);
            rightTriangleButton.TabIndex = 0;
            rightTriangleButton.Text = "Right Triangle";
            rightTriangleButton.UseVisualStyleBackColor = true;
            rightTriangleButton.Click += rightTriangleButton_Click;
            // 
            // indicator
            // 
            indicator.AutoSize = true;
            indicator.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            indicator.Location = new Point(151, 189);
            indicator.Name = "indicator";
            indicator.Size = new Size(335, 25);
            indicator.TabIndex = 10;
            indicator.Text = "Press any item to measure their shape.";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { aboutButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(505, 25);
            toolStrip1.TabIndex = 11;
            toolStrip1.Text = "toolStrip1";
            // 
            // aboutButton
            // 
            aboutButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            aboutButton.Image = (Image)resources.GetObject("aboutButton.Image");
            aboutButton.ImageTransparentColor = Color.Magenta;
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(40, 22);
            aboutButton.Text = "About";
            aboutButton.Click += aboutButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 430);
            Controls.Add(toolStrip1);
            Controls.Add(indicator);
            Controls.Add(groupBox1);
            Controls.Add(shapesGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            Text = "Xrigonometry";
            shapesGroupBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sphereButton;
        private Button triangleButton;
        private Button squareButton;
        private Button Rectanglebutton;
        private Button polygonButton;
        private Button pentagonButton;
        private Button hexagonButton;
        private Button circleButton;
        private GroupBox shapesGroupBox;
        private GroupBox groupBox1;
        private Button rightTriangleButton;
        private Label indicator;
        private ToolStrip toolStrip1;
        private ToolStripLabel aboutButton;
    }
}