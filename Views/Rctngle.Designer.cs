using System.Windows.Forms;

namespace Xrigonometry.Views
{
    partial class Rctngle : Form
    {
        private GroupBox generateObjectGroupBox;
        private Button generateObjectButton;
        private TextBox nametextBox;
        private Label nameLabel;
        private TextBox lengthTextBox;
        private Label lengthLabel;
        private TextBox widthTextBox;
        private Label widthLabel;
        private GroupBox groupBox1;
        private Label perimeterIndicator;
        private Label label4;
        private Label areaIndicatorlabel;
        private Label label6;
        private Label lengthIndicatorLabel;
        private Label length;
        private Label widthIndicator;
        private Label label3;
        private Label objectNamelabel;
        private Label label1;

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
            diagonaltextBox = new TextBox();
            label2 = new Label();
            generateObjectButton = new Button();
            nametextBox = new TextBox();
            nameLabel = new Label();
            lengthTextBox = new TextBox();
            lengthLabel = new Label();
            widthTextBox = new TextBox();
            widthLabel = new Label();
            groupBox1 = new GroupBox();
            perimeterIndicator = new Label();
            label4 = new Label();
            areaIndicatorlabel = new Label();
            label6 = new Label();
            lengthIndicatorLabel = new Label();
            length = new Label();
            widthIndicator = new Label();
            label3 = new Label();
            objectNamelabel = new Label();
            label1 = new Label();
            diagonallabel = new Label();
            label7 = new Label();
            generateObjectGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // generateObjectGroupBox
            // 
            generateObjectGroupBox.Controls.Add(diagonaltextBox);
            generateObjectGroupBox.Controls.Add(label2);
            generateObjectGroupBox.Controls.Add(generateObjectButton);
            generateObjectGroupBox.Controls.Add(nametextBox);
            generateObjectGroupBox.Controls.Add(nameLabel);
            generateObjectGroupBox.Controls.Add(lengthTextBox);
            generateObjectGroupBox.Controls.Add(lengthLabel);
            generateObjectGroupBox.Controls.Add(widthTextBox);
            generateObjectGroupBox.Controls.Add(widthLabel);
            generateObjectGroupBox.Location = new Point(12, 12);
            generateObjectGroupBox.Name = "generateObjectGroupBox";
            generateObjectGroupBox.Size = new Size(186, 374);
            generateObjectGroupBox.TabIndex = 7;
            generateObjectGroupBox.TabStop = false;
            generateObjectGroupBox.Text = "Generate Object";
            // 
            // diagonaltextBox
            // 
            diagonaltextBox.Location = new Point(15, 263);
            diagonaltextBox.Name = "diagonaltextBox";
            diagonaltextBox.Size = new Size(153, 23);
            diagonaltextBox.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 236);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 14;
            label2.Text = "Diagonal";
            // 
            // generateObjectButton
            // 
            generateObjectButton.Location = new Point(33, 310);
            generateObjectButton.Name = "generateObjectButton";
            generateObjectButton.Size = new Size(112, 35);
            generateObjectButton.TabIndex = 13;
            generateObjectButton.Text = "Generate Object";
            generateObjectButton.UseVisualStyleBackColor = true;
            generateObjectButton.Click += generateObjectButton_Click;
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(15, 67);
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
            // lengthTextBox
            // 
            lengthTextBox.Location = new Point(15, 130);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new Size(153, 23);
            lengthTextBox.TabIndex = 10;
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Location = new Point(15, 105);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new Size(44, 15);
            lengthLabel.TabIndex = 9;
            lengthLabel.Text = "Length";
            // 
            // widthTextBox
            // 
            widthTextBox.Location = new Point(15, 197);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(153, 23);
            widthTextBox.TabIndex = 8;
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(15, 171);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(39, 15);
            widthLabel.TabIndex = 7;
            widthLabel.Text = "Width";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(diagonallabel);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(perimeterIndicator);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(areaIndicatorlabel);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lengthIndicatorLabel);
            groupBox1.Controls.Add(length);
            groupBox1.Controls.Add(widthIndicator);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(objectNamelabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(213, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 374);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Object Details";
            // 
            // perimeterIndicator
            // 
            perimeterIndicator.AutoSize = true;
            perimeterIndicator.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            perimeterIndicator.Location = new Point(16, 329);
            perimeterIndicator.Name = "perimeterIndicator";
            perimeterIndicator.Size = new Size(226, 25);
            perimeterIndicator.TabIndex = 21;
            perimeterIndicator.Text = "OBJECT NOT AVAILABLE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 308);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 22;
            label4.Text = "Perimeter";
            // 
            // areaIndicatorlabel
            // 
            areaIndicatorlabel.AutoSize = true;
            areaIndicatorlabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            areaIndicatorlabel.Location = new Point(16, 271);
            areaIndicatorlabel.Name = "areaIndicatorlabel";
            areaIndicatorlabel.Size = new Size(226, 25);
            areaIndicatorlabel.TabIndex = 19;
            areaIndicatorlabel.Text = "OBJECT NOT AVAILABLE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 250);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 20;
            label6.Text = "Area";
            // 
            // lengthIndicatorLabel
            // 
            lengthIndicatorLabel.AutoSize = true;
            lengthIndicatorLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lengthIndicatorLabel.Location = new Point(16, 215);
            lengthIndicatorLabel.Name = "lengthIndicatorLabel";
            lengthIndicatorLabel.Size = new Size(226, 25);
            lengthIndicatorLabel.TabIndex = 17;
            lengthIndicatorLabel.Text = "OBJECT NOT AVAILABLE";
            // 
            // length
            // 
            length.AutoSize = true;
            length.Location = new Point(16, 194);
            length.Name = "length";
            length.Size = new Size(44, 15);
            length.TabIndex = 18;
            length.Text = "Length";
            // 
            // widthIndicator
            // 
            widthIndicator.AutoSize = true;
            widthIndicator.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            widthIndicator.Location = new Point(16, 157);
            widthIndicator.Name = "widthIndicator";
            widthIndicator.Size = new Size(226, 25);
            widthIndicator.TabIndex = 15;
            widthIndicator.Text = "OBJECT NOT AVAILABLE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 136);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 16;
            label3.Text = "Width";
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
            // diagonallabel
            // 
            diagonallabel.AutoSize = true;
            diagonallabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            diagonallabel.Location = new Point(16, 102);
            diagonallabel.Name = "diagonallabel";
            diagonallabel.Size = new Size(226, 25);
            diagonallabel.TabIndex = 23;
            diagonallabel.Text = "OBJECT NOT AVAILABLE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 81);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 24;
            label7.Text = "Diagonal";
            // 
            // Rctngle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 400);
            Controls.Add(groupBox1);
            Controls.Add(generateObjectGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Rctngle";
            ShowIcon = false;
            Text = "Rectangle";
            generateObjectGroupBox.ResumeLayout(false);
            generateObjectGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox diagonaltextBox;
        private Label label2;
        private Label diagonallabel;
        private Label label7;
    }
}