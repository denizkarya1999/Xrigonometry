using System;
using System.Drawing;
using System.Windows.Forms;

namespace Xrigonometry.Views
{
    partial class Triangle : Form
    {
        private System.ComponentModel.IContainer components = null;

        // Triangle properties
        private TextBox nameTextBox;
        private Label nameLabel;
        private TextBox sideATextBox;
        private Label sideALabel;
        private TextBox sideBTextBox;
        private Label sideBLabel;
        private TextBox sideCTextBox;
        private Label sideCLabel;
        private TextBox heightTextBox;
        private Label heightLabel;
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
            sideATextBox = new TextBox();
            sideALabel = new Label();
            sideBTextBox = new TextBox();
            sideBLabel = new Label();
            sideCTextBox = new TextBox();
            sideCLabel = new Label();
            heightTextBox = new TextBox();
            heightLabel = new Label();
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
            generateObjectGroupBox.Controls.Add(sideATextBox);
            generateObjectGroupBox.Controls.Add(sideALabel);
            generateObjectGroupBox.Controls.Add(sideBTextBox);
            generateObjectGroupBox.Controls.Add(sideBLabel);
            generateObjectGroupBox.Controls.Add(sideCTextBox);
            generateObjectGroupBox.Controls.Add(sideCLabel);
            generateObjectGroupBox.Controls.Add(heightTextBox);
            generateObjectGroupBox.Controls.Add(heightLabel);
            generateObjectGroupBox.Location = new Point(12, 12);
            generateObjectGroupBox.Name = "generateObjectGroupBox";
            generateObjectGroupBox.Size = new Size(186, 332);
            generateObjectGroupBox.TabIndex = 10;
            generateObjectGroupBox.TabStop = false;
            generateObjectGroupBox.Text = "Generate Object";
            // 
            // generateObjectButton
            // 
            generateObjectButton.Location = new Point(34, 284);
            generateObjectButton.Name = "generateObjectButton";
            generateObjectButton.Size = new Size(112, 35);
            generateObjectButton.TabIndex = 13;
            generateObjectButton.Text = "Generate Object";
            generateObjectButton.UseVisualStyleBackColor = true;
            generateObjectButton.Click += generateObjectButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(15, 42);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(153, 23);
            nameTextBox.TabIndex = 12;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(15, 18);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Name";
            // 
            // sideATextBox
            // 
            sideATextBox.Location = new Point(15, 96);
            sideATextBox.Name = "sideATextBox";
            sideATextBox.Size = new Size(153, 23);
            sideATextBox.TabIndex = 10;
            // 
            // sideALabel
            // 
            sideALabel.AutoSize = true;
            sideALabel.Location = new Point(15, 72);
            sideALabel.Name = "sideALabel";
            sideALabel.Size = new Size(40, 15);
            sideALabel.TabIndex = 9;
            sideALabel.Text = "Side A";
            // 
            // sideBTextBox
            // 
            sideBTextBox.Location = new Point(15, 151);
            sideBTextBox.Name = "sideBTextBox";
            sideBTextBox.Size = new Size(153, 23);
            sideBTextBox.TabIndex = 8;
            // 
            // sideBLabel
            // 
            sideBLabel.AutoSize = true;
            sideBLabel.Location = new Point(15, 127);
            sideBLabel.Name = "sideBLabel";
            sideBLabel.Size = new Size(39, 15);
            sideBLabel.TabIndex = 7;
            sideBLabel.Text = "Side B";
            // 
            // sideCTextBox
            // 
            sideCTextBox.Location = new Point(15, 202);
            sideCTextBox.Name = "sideCTextBox";
            sideCTextBox.Size = new Size(153, 23);
            sideCTextBox.TabIndex = 6;
            // 
            // sideCLabel
            // 
            sideCLabel.AutoSize = true;
            sideCLabel.Location = new Point(15, 178);
            sideCLabel.Name = "sideCLabel";
            sideCLabel.Size = new Size(40, 15);
            sideCLabel.TabIndex = 5;
            sideCLabel.Text = "Side C";
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(15, 254);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(153, 23);
            heightTextBox.TabIndex = 4;
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(15, 230);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(43, 15);
            heightLabel.TabIndex = 3;
            heightLabel.Text = "Height";
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
            groupBox1.Size = new Size(305, 332);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Object Details";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            areaLabel.Location = new Point(41, 227);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new Size(226, 25);
            areaLabel.TabIndex = 21;
            areaLabel.Text = "OBJECT NOT AVAILABLE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 206);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 22;
            label4.Text = "Area";
            // 
            // perimeterLabel
            // 
            perimeterLabel.AutoSize = true;
            perimeterLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            perimeterLabel.Location = new Point(41, 167);
            perimeterLabel.Name = "perimeterLabel";
            perimeterLabel.Size = new Size(226, 25);
            perimeterLabel.TabIndex = 19;
            perimeterLabel.Text = "OBJECT NOT AVAILABLE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 146);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 20;
            label6.Text = "Perimeter";
            // 
            // objectNameLabel
            // 
            objectNameLabel.AutoSize = true;
            objectNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            objectNameLabel.Location = new Point(41, 103);
            objectNameLabel.Name = "objectNameLabel";
            objectNameLabel.Size = new Size(226, 25);
            objectNameLabel.TabIndex = 14;
            objectNameLabel.Text = "OBJECT NOT AVAILABLE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 82);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // Triangle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 373);
            Controls.Add(groupBox1);
            Controls.Add(generateObjectGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Triangle";
            ShowIcon = false;
            Text = "Triangle";
            generateObjectGroupBox.ResumeLayout(false);
            generateObjectGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private void generateObjectButton_Click(object sender, EventArgs e)
        {
            // Implement generation logic here
            try
            {
                // Get the values entered by the user
                string triangleName = nameTextBox.Text;
                double sideA = Convert.ToDouble(sideATextBox.Text);
                double sideB = Convert.ToDouble(sideBTextBox.Text);
                double sideC = Convert.ToDouble(sideCTextBox.Text);
                double height = Convert.ToDouble(heightTextBox.Text);

                // Create a new Triangle object with the provided values
                objects.Triangle triangle = new objects.Triangle(triangleName, "Triangle", sideA, sideB, sideC, height);

                // Update the object details labels with the newly created Triangle object's information
                objectNameLabel.Text = triangle.getName();
                perimeterLabel.Text = triangle.Perimeter().ToString();
                areaLabel.Text = triangle.Area().ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for side lengths and height.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}