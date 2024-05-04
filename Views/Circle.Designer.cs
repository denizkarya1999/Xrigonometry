using System;
using System.Drawing;
using System.Windows.Forms;

namespace Xrigonometry.Views
{
    partial class Circle : Form
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox nameTextBox;
        private Label nameLabel;
        private TextBox radiusTextBox;
        private Label radiusLabel;
        private Button generateObjectButton;
        private GroupBox generateObjectGroupBox;
        private GroupBox groupBox1;
        private Label areaLabel;
        private Label label4;
        private Label circumferenceLabel;
        private Label label6;
        private Label objectNameLabel;
        private Label label1;

        private void InitializeComponent()
        {
            generateObjectGroupBox = new GroupBox();
            generateObjectButton = new Button();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            radiusTextBox = new TextBox();
            radiusLabel = new Label();
            groupBox1 = new GroupBox();
            areaLabel = new Label();
            label4 = new Label();
            circumferenceLabel = new Label();
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
            generateObjectGroupBox.Controls.Add(radiusTextBox);
            generateObjectGroupBox.Controls.Add(radiusLabel);
            generateObjectGroupBox.Location = new Point(12, 12);
            generateObjectGroupBox.Name = "generateObjectGroupBox";
            generateObjectGroupBox.Size = new Size(186, 203);
            generateObjectGroupBox.TabIndex = 10;
            generateObjectGroupBox.TabStop = false;
            generateObjectGroupBox.Text = "Generate Object";
            // 
            // generateObjectButton
            // 
            generateObjectButton.Location = new Point(34, 148);
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
            // radiusTextBox
            // 
            radiusTextBox.Location = new Point(15, 106);
            radiusTextBox.Name = "radiusTextBox";
            radiusTextBox.Size = new Size(153, 23);
            radiusTextBox.TabIndex = 10;
            // 
            // radiusLabel
            // 
            radiusLabel.AutoSize = true;
            radiusLabel.Location = new Point(15, 82);
            radiusLabel.Name = "radiusLabel";
            radiusLabel.Size = new Size(42, 15);
            radiusLabel.TabIndex = 9;
            radiusLabel.Text = "Radius";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(areaLabel);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(circumferenceLabel);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(objectNameLabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(213, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 203);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Object Details";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            areaLabel.Location = new Point(40, 154);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new Size(226, 25);
            areaLabel.TabIndex = 21;
            areaLabel.Text = "OBJECT NOT AVAILABLE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 133);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 22;
            label4.Text = "Area";
            // 
            // circumferenceLabel
            // 
            circumferenceLabel.AutoSize = true;
            circumferenceLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            circumferenceLabel.Location = new Point(40, 101);
            circumferenceLabel.Name = "circumferenceLabel";
            circumferenceLabel.Size = new Size(226, 25);
            circumferenceLabel.TabIndex = 19;
            circumferenceLabel.Text = "OBJECT NOT AVAILABLE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 80);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 20;
            label6.Text = "Circumference";
            // 
            // objectNameLabel
            // 
            objectNameLabel.AutoSize = true;
            objectNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            objectNameLabel.Location = new Point(40, 50);
            objectNameLabel.Name = "objectNameLabel";
            objectNameLabel.Size = new Size(226, 25);
            objectNameLabel.TabIndex = 14;
            objectNameLabel.Text = "OBJECT NOT AVAILABLE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 29);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // Circle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 232);
            Controls.Add(groupBox1);
            Controls.Add(generateObjectGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Circle";
            ShowIcon = false;
            Text = "Circle";
            generateObjectGroupBox.ResumeLayout(false);
            generateObjectGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private void generateObjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                string circleName = nameTextBox.Text;
                double radius = Convert.ToDouble(radiusTextBox.Text);

                objects.Circle circle = new objects.Circle(circleName, "Circle", radius);

                objectNameLabel.Text = circle.getName();
                circumferenceLabel.Text = circle.Circumference().ToString();
                areaLabel.Text = circle.Area().ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value for the radius.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}