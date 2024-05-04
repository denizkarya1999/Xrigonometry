using System;
using System.Drawing;
using System.Windows.Forms;

namespace Xrigonometry.Views
{
    partial class Polygon : Form
    {
        private System.ComponentModel.IContainer components = null;

        // Polygon properties
        private TextBox nameTextBox;
        private Label nameLabel;
        private TextBox nTextBox;
        private Label nLabel;
        private Button calculateButton;
        private GroupBox detailsGroupBox;
        private Label sumOfAllAnglesLabel;
        private Label label4;
        private Label eachAngleOfPolygonLabel;
        private Label label6;
        private Label polygonDiagonalsLabel;
        private Label label8;
        private Label sumOfExteriorPolygonsLabel;
        private Label label10;

        private void InitializeComponent()
        {
            nameTextBox = new TextBox();
            nameLabel = new Label();
            nTextBox = new TextBox();
            nLabel = new Label();
            calculateButton = new Button();
            detailsGroupBox = new GroupBox();
            sumOfAllAnglesLabel = new Label();
            label4 = new Label();
            eachAngleOfPolygonLabel = new Label();
            label6 = new Label();
            polygonDiagonalsLabel = new Label();
            label8 = new Label();
            sumOfExteriorPolygonsLabel = new Label();
            label10 = new Label();
            detailsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 35);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(153, 23);
            nameTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 17);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name";
            // 
            // nTextBox
            // 
            nTextBox.Location = new Point(12, 91);
            nTextBox.Name = "nTextBox";
            nTextBox.Size = new Size(153, 23);
            nTextBox.TabIndex = 2;
            // 
            // nLabel
            // 
            nLabel.AutoSize = true;
            nLabel.Location = new Point(12, 73);
            nLabel.Name = "nLabel";
            nLabel.Size = new Size(66, 15);
            nLabel.TabIndex = 3;
            nLabel.Text = "No of sides";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(12, 138);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(153, 27);
            calculateButton.TabIndex = 4;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // detailsGroupBox
            // 
            detailsGroupBox.Controls.Add(sumOfAllAnglesLabel);
            detailsGroupBox.Controls.Add(label4);
            detailsGroupBox.Controls.Add(eachAngleOfPolygonLabel);
            detailsGroupBox.Controls.Add(label6);
            detailsGroupBox.Controls.Add(polygonDiagonalsLabel);
            detailsGroupBox.Controls.Add(label8);
            detailsGroupBox.Controls.Add(sumOfExteriorPolygonsLabel);
            detailsGroupBox.Controls.Add(label10);
            detailsGroupBox.Location = new Point(171, 17);
            detailsGroupBox.Name = "detailsGroupBox";
            detailsGroupBox.Size = new Size(306, 180);
            detailsGroupBox.TabIndex = 5;
            detailsGroupBox.TabStop = false;
            detailsGroupBox.Text = "Details";
            // 
            // sumOfAllAnglesLabel
            // 
            sumOfAllAnglesLabel.AutoSize = true;
            sumOfAllAnglesLabel.Location = new Point(179, 139);
            sumOfAllAnglesLabel.Name = "sumOfAllAnglesLabel";
            sumOfAllAnglesLabel.Size = new Size(0, 15);
            sumOfAllAnglesLabel.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 139);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 6;
            label4.Text = "Sum of all Angles";
            // 
            // eachAngleOfPolygonLabel
            // 
            eachAngleOfPolygonLabel.AutoSize = true;
            eachAngleOfPolygonLabel.Location = new Point(179, 102);
            eachAngleOfPolygonLabel.Name = "eachAngleOfPolygonLabel";
            eachAngleOfPolygonLabel.Size = new Size(0, 15);
            eachAngleOfPolygonLabel.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 102);
            label6.Name = "label6";
            label6.Size = new Size(125, 15);
            label6.TabIndex = 4;
            label6.Text = "Each angle of polygon";
            // 
            // polygonDiagonalsLabel
            // 
            polygonDiagonalsLabel.AutoSize = true;
            polygonDiagonalsLabel.Location = new Point(179, 65);
            polygonDiagonalsLabel.Name = "polygonDiagonalsLabel";
            polygonDiagonalsLabel.Size = new Size(0, 15);
            polygonDiagonalsLabel.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 65);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 2;
            label8.Text = "Polygon diagonals";
            // 
            // sumOfExteriorPolygonsLabel
            // 
            sumOfExteriorPolygonsLabel.AutoSize = true;
            sumOfExteriorPolygonsLabel.Location = new Point(179, 30);
            sumOfExteriorPolygonsLabel.Name = "sumOfExteriorPolygonsLabel";
            sumOfExteriorPolygonsLabel.Size = new Size(0, 15);
            sumOfExteriorPolygonsLabel.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 30);
            label10.Name = "label10";
            label10.Size = new Size(140, 15);
            label10.TabIndex = 0;
            label10.Text = "Sum of exterior polygons";
            // 
            // Polygon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 210);
            Controls.Add(detailsGroupBox);
            Controls.Add(calculateButton);
            Controls.Add(nLabel);
            Controls.Add(nTextBox);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Polygon";
            Text = "Polygon";
            detailsGroupBox.ResumeLayout(false);
            detailsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values entered by the user
                string polygonName = nameTextBox.Text;
                double sides = Convert.ToDouble(nTextBox.Text);

                // Create a new Polygon object with the provided values
                objects.Polygon polygon = new objects.Polygon(polygonName, "Polygon", sides);

                // Update the labels with the newly calculated values
                sumOfAllAnglesLabel.Text = polygon.sumOfAllAngles().ToString();
                eachAngleOfPolygonLabel.Text = polygon.eachAngleOfPolygon().ToString();
                polygonDiagonalsLabel.Text = polygon.polygonDiagonals().ToString();
                sumOfExteriorPolygonsLabel.Text = polygon.SumOfExteriorPolygons().ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value for the number of sides.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}