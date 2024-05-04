using System;
using System.Drawing;
using System.Windows.Forms;

namespace Xrigonometry.Views
{
    partial class Square : Form
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

        // Square properties
        private TextBox nameTextBox;
        private Label nameLabel;
        private TextBox sideTextBox;
        private Label sideLabel;
        private Button generateObjectButton;
        private GroupBox generateObjectGroupBox;
        private GroupBox groupBox1;
        private Label areaLabel;
        private Label label4;
        private Label perimeterLabel;
        private Label label6;
        private Label objectNameLabel;
        private Label label1;

        private void InitializeComponent()
        {
            generateObjectGroupBox = new GroupBox();
            generateObjectButton = new Button();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            sideTextBox = new TextBox();
            sideLabel = new Label();
            groupBox1 = new GroupBox();
            areaLabel = new Label();
            label4 = new Label();
            perimeterLabel = new Label();
            label6 = new Label();
            objectNameLabel = new Label();
            label1 = new Label();
            generateObjectGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // generateObjectGroupBox
            // 
            generateObjectGroupBox.Controls.Add(generateObjectButton);
            generateObjectGroupBox.Controls.Add(nameTextBox);
            generateObjectGroupBox.Controls.Add(nameLabel);
            generateObjectGroupBox.Controls.Add(sideTextBox);
            generateObjectGroupBox.Controls.Add(sideLabel);
            generateObjectGroupBox.Location = new Point(12, 12);
            generateObjectGroupBox.Name = "generateObjectGroupBox";
            generateObjectGroupBox.Size = new Size(186, 196);
            generateObjectGroupBox.TabIndex = 9;
            generateObjectGroupBox.TabStop = false;
            generateObjectGroupBox.Text = "Generate Object";
            // 
            // generateObjectButton
            // 
            generateObjectButton.Location = new Point(34, 146);
            generateObjectButton.Name = "generateObjectButton";
            generateObjectButton.Size = new Size(112, 35);
            generateObjectButton.TabIndex = 13;
            generateObjectButton.Text = "Generate Object";
            generateObjectButton.UseVisualStyleBackColor = true;
            generateObjectButton.Click += generateObjectButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(15, 46);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(153, 23);
            nameTextBox.TabIndex = 12;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(15, 22);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Name";
            // 
            // sideTextBox
            // 
            sideTextBox.Location = new Point(15, 103);
            sideTextBox.Name = "sideTextBox";
            sideTextBox.Size = new Size(153, 23);
            sideTextBox.TabIndex = 10;
            // 
            // sideLabel
            // 
            sideLabel.AutoSize = true;
            sideLabel.Location = new Point(15, 79);
            sideLabel.Name = "sideLabel";
            sideLabel.Size = new Size(29, 15);
            sideLabel.TabIndex = 9;
            sideLabel.Text = "Side";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(areaLabel);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(perimeterLabel);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(objectNameLabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(213, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 196);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Object Details";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            areaLabel.Location = new Point(16, 152);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new Size(226, 25);
            areaLabel.TabIndex = 19;
            areaLabel.Text = "OBJECT NOT AVAILABLE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 131);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 20;
            label4.Text = "Area";
            // 
            // perimeterLabel
            // 
            perimeterLabel.AutoSize = true;
            perimeterLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            perimeterLabel.Location = new Point(16, 96);
            perimeterLabel.Name = "perimeterLabel";
            perimeterLabel.Size = new Size(226, 25);
            perimeterLabel.TabIndex = 17;
            perimeterLabel.Text = "OBJECT NOT AVAILABLE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 75);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 18;
            label6.Text = "Perimeter";
            // 
            // objectNameLabel
            // 
            objectNameLabel.AutoSize = true;
            objectNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            objectNameLabel.Location = new Point(16, 41);
            objectNameLabel.Name = "objectNameLabel";
            objectNameLabel.Size = new Size(226, 25);
            objectNameLabel.TabIndex = 14;
            objectNameLabel.Text = "OBJECT NOT AVAILABLE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 20);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // Square
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 224);
            Controls.Add(groupBox1);
            Controls.Add(generateObjectGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Square";
            Text = "Square";
            generateObjectGroupBox.ResumeLayout(false);
            generateObjectGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }
    }
}