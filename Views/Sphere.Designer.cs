namespace Xrigonometry.Views
{
    partial class Sphere
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
            generateObjectGroupBox = new GroupBox();
            generateObjectButton = new Button();
            nametextBox = new TextBox();
            nameLabel = new Label();
            diameterTextBox = new TextBox();
            diameterLabel = new Label();
            radiustextBox = new TextBox();
            radiusLabel = new Label();
            groupBox1 = new GroupBox();
            surfaceAreaIndicator = new Label();
            label4 = new Label();
            volumeIndicatorlabel = new Label();
            label6 = new Label();
            diameterIndicatorLabel = new Label();
            diameter = new Label();
            radiusIndicator = new Label();
            label3 = new Label();
            objectNamelabel = new Label();
            label1 = new Label();
            generateObjectGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // generateObjectGroupBox
            // 
            generateObjectGroupBox.Controls.Add(generateObjectButton);
            generateObjectGroupBox.Controls.Add(nametextBox);
            generateObjectGroupBox.Controls.Add(nameLabel);
            generateObjectGroupBox.Controls.Add(diameterTextBox);
            generateObjectGroupBox.Controls.Add(diameterLabel);
            generateObjectGroupBox.Controls.Add(radiustextBox);
            generateObjectGroupBox.Controls.Add(radiusLabel);
            generateObjectGroupBox.Location = new Point(12, 12);
            generateObjectGroupBox.Name = "generateObjectGroupBox";
            generateObjectGroupBox.Size = new Size(186, 315);
            generateObjectGroupBox.TabIndex = 7;
            generateObjectGroupBox.TabStop = false;
            generateObjectGroupBox.Text = "Generate Object";
            // 
            // generateObjectButton
            // 
            generateObjectButton.Location = new Point(34, 240);
            generateObjectButton.Name = "generateObjectButton";
            generateObjectButton.Size = new Size(112, 35);
            generateObjectButton.TabIndex = 13;
            generateObjectButton.Text = "Generate Object";
            generateObjectButton.UseVisualStyleBackColor = true;
            generateObjectButton.Click += generateObjectButton_Click;
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(15, 68);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(153, 23);
            nametextBox.TabIndex = 12;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(15, 41);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Name";
            // 
            // diameterTextBox
            // 
            diameterTextBox.Location = new Point(15, 198);
            diameterTextBox.Name = "diameterTextBox";
            diameterTextBox.Size = new Size(153, 23);
            diameterTextBox.TabIndex = 10;
            // 
            // diameterLabel
            // 
            diameterLabel.AutoSize = true;
            diameterLabel.Location = new Point(15, 171);
            diameterLabel.Name = "diameterLabel";
            diameterLabel.Size = new Size(55, 15);
            diameterLabel.TabIndex = 9;
            diameterLabel.Text = "Diameter";
            // 
            // radiustextBox
            // 
            radiustextBox.Location = new Point(15, 133);
            radiustextBox.Name = "radiustextBox";
            radiustextBox.Size = new Size(153, 23);
            radiustextBox.TabIndex = 8;
            // 
            // radiusLabel
            // 
            radiusLabel.AutoSize = true;
            radiusLabel.Location = new Point(15, 106);
            radiusLabel.Name = "radiusLabel";
            radiusLabel.Size = new Size(42, 15);
            radiusLabel.TabIndex = 7;
            radiusLabel.Text = "Radius";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(surfaceAreaIndicator);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(volumeIndicatorlabel);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(diameterIndicatorLabel);
            groupBox1.Controls.Add(diameter);
            groupBox1.Controls.Add(radiusIndicator);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(objectNamelabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(213, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 315);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Object Details";
            // 
            // surfaceAreaIndicator
            // 
            surfaceAreaIndicator.AutoSize = true;
            surfaceAreaIndicator.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            surfaceAreaIndicator.Location = new Point(16, 276);
            surfaceAreaIndicator.Name = "surfaceAreaIndicator";
            surfaceAreaIndicator.Size = new Size(226, 25);
            surfaceAreaIndicator.TabIndex = 21;
            surfaceAreaIndicator.Text = "OBJECT NOT AVAILABLE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 255);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 22;
            label4.Text = "Surface Area";
            // 
            // volumeIndicatorlabel
            // 
            volumeIndicatorlabel.AutoSize = true;
            volumeIndicatorlabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            volumeIndicatorlabel.Location = new Point(16, 218);
            volumeIndicatorlabel.Name = "volumeIndicatorlabel";
            volumeIndicatorlabel.Size = new Size(226, 25);
            volumeIndicatorlabel.TabIndex = 19;
            volumeIndicatorlabel.Text = "OBJECT NOT AVAILABLE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 197);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 20;
            label6.Text = "Volume";
            // 
            // diameterIndicatorLabel
            // 
            diameterIndicatorLabel.AutoSize = true;
            diameterIndicatorLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            diameterIndicatorLabel.Location = new Point(16, 162);
            diameterIndicatorLabel.Name = "diameterIndicatorLabel";
            diameterIndicatorLabel.Size = new Size(226, 25);
            diameterIndicatorLabel.TabIndex = 17;
            diameterIndicatorLabel.Text = "OBJECT NOT AVAILABLE";
            // 
            // diameter
            // 
            diameter.AutoSize = true;
            diameter.Location = new Point(16, 141);
            diameter.Name = "diameter";
            diameter.Size = new Size(55, 15);
            diameter.TabIndex = 18;
            diameter.Text = "Diameter";
            // 
            // radiusIndicator
            // 
            radiusIndicator.AutoSize = true;
            radiusIndicator.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radiusIndicator.Location = new Point(16, 104);
            radiusIndicator.Name = "radiusIndicator";
            radiusIndicator.Size = new Size(226, 25);
            radiusIndicator.TabIndex = 15;
            radiusIndicator.Text = "OBJECT NOT AVAILABLE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 83);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 16;
            label3.Text = "Radius";
            // 
            // objectNamelabel
            // 
            objectNamelabel.AutoSize = true;
            objectNamelabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            objectNamelabel.Location = new Point(16, 47);
            objectNamelabel.Name = "objectNamelabel";
            objectNamelabel.Size = new Size(226, 25);
            objectNamelabel.TabIndex = 14;
            objectNamelabel.Text = "OBJECT NOT AVAILABLE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // Sphere
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 352);
            Controls.Add(groupBox1);
            Controls.Add(generateObjectGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Sphere";
            ShowIcon = false;
            Text = "Sphere";
            generateObjectGroupBox.ResumeLayout(false);
            generateObjectGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox generateObjectGroupBox;
        private Button generateObjectButton;
        private TextBox nametextBox;
        private Label nameLabel;
        private TextBox diameterTextBox;
        private Label diameterLabel;
        private TextBox radiustextBox;
        private Label radiusLabel;
        private GroupBox groupBox1;
        private Label surfaceAreaIndicator;
        private Label label4;
        private Label volumeIndicatorlabel;
        private Label label6;
        private Label diameterIndicatorLabel;
        private Label diameter;
        private Label radiusIndicator;
        private Label label3;
        private Label objectNamelabel;
        private Label label1;
    }
}