using System;
using System.Drawing;
using System.Windows.Forms;
using objects.MathFunctions;

namespace Xrigonometry.Views.TriangleExtended
{
    partial class RightTriangle : Form
    {
        private System.ComponentModel.IContainer components = null;

        // RightTriangle properties
        private TextBox nameTextBox;
        private Label nameLabel;
        private TextBox sideXTextBox;
        private Label sideXLabel;
        private TextBox sideYTextBox;
        private Label sideYLabel;
        private Label hypotenuseLabel;
        private Button generateObjectButton;
        private GroupBox generateObjectGroupBox;
        private GroupBox groupBox1;
        private Label nameLabelIndicator;
        private Label hypotenuseLabelIndicator;
        private Label sideXLabelIndicator;
        private Label sideYLabelIndicator;
        private Label sideZLabelIndicator;

        private void InitializeComponent()
        {
            generateObjectGroupBox = new GroupBox();
            generateObjectButton = new Button();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            sideXTextBox = new TextBox();
            sideXLabel = new Label();
            sideYTextBox = new TextBox();
            sideYLabel = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            cotengantbutton = new Button();
            secantButton = new Button();
            cosecantButton = new Button();
            tangentButton = new Button();
            cosineButton = new Button();
            sineButton = new Button();
            objectSideZ = new Label();
            ObjectSideY = new Label();
            objectSide = new Label();
            objectHypotenuse = new Label();
            objectName = new Label();
            sideZLabelIndicator = new Label();
            sideYLabelIndicator = new Label();
            sideXLabelIndicator = new Label();
            hypotenuseLabelIndicator = new Label();
            nameLabelIndicator = new Label();
            hypotenuseLabel = new Label();
            generateObjectGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // generateObjectGroupBox
            // 
            generateObjectGroupBox.Controls.Add(generateObjectButton);
            generateObjectGroupBox.Controls.Add(nameTextBox);
            generateObjectGroupBox.Controls.Add(nameLabel);
            generateObjectGroupBox.Controls.Add(sideXTextBox);
            generateObjectGroupBox.Controls.Add(sideXLabel);
            generateObjectGroupBox.Controls.Add(sideYTextBox);
            generateObjectGroupBox.Controls.Add(sideYLabel);
            generateObjectGroupBox.Location = new Point(12, 12);
            generateObjectGroupBox.Name = "generateObjectGroupBox";
            generateObjectGroupBox.Size = new Size(186, 348);
            generateObjectGroupBox.TabIndex = 10;
            generateObjectGroupBox.TabStop = false;
            generateObjectGroupBox.Text = "Generate Object";
            // 
            // generateObjectButton
            // 
            generateObjectButton.Location = new Point(34, 253);
            generateObjectButton.Name = "generateObjectButton";
            generateObjectButton.Size = new Size(112, 35);
            generateObjectButton.TabIndex = 13;
            generateObjectButton.Text = "Generate Object";
            generateObjectButton.UseVisualStyleBackColor = true;
            generateObjectButton.Click += generateObjectButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(15, 90);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(153, 23);
            nameTextBox.TabIndex = 12;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(15, 66);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Name";
            // 
            // sideXTextBox
            // 
            sideXTextBox.Location = new Point(15, 150);
            sideXTextBox.Name = "sideXTextBox";
            sideXTextBox.Size = new Size(153, 23);
            sideXTextBox.TabIndex = 10;
            // 
            // sideXLabel
            // 
            sideXLabel.AutoSize = true;
            sideXLabel.Location = new Point(15, 126);
            sideXLabel.Name = "sideXLabel";
            sideXLabel.Size = new Size(39, 15);
            sideXLabel.TabIndex = 9;
            sideXLabel.Text = "Side X";
            // 
            // sideYTextBox
            // 
            sideYTextBox.Location = new Point(15, 207);
            sideYTextBox.Name = "sideYTextBox";
            sideYTextBox.Size = new Size(153, 23);
            sideYTextBox.TabIndex = 8;
            // 
            // sideYLabel
            // 
            sideYLabel.AutoSize = true;
            sideYLabel.Location = new Point(15, 183);
            sideYLabel.Name = "sideYLabel";
            sideYLabel.Size = new Size(39, 15);
            sideYLabel.TabIndex = 7;
            sideYLabel.Text = "Side Y";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(objectSideZ);
            groupBox1.Controls.Add(ObjectSideY);
            groupBox1.Controls.Add(objectSide);
            groupBox1.Controls.Add(objectHypotenuse);
            groupBox1.Controls.Add(objectName);
            groupBox1.Controls.Add(sideZLabelIndicator);
            groupBox1.Controls.Add(sideYLabelIndicator);
            groupBox1.Controls.Add(sideXLabelIndicator);
            groupBox1.Controls.Add(hypotenuseLabelIndicator);
            groupBox1.Controls.Add(nameLabelIndicator);
            groupBox1.Controls.Add(hypotenuseLabel);
            groupBox1.Location = new Point(204, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 348);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Object Details";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cotengantbutton);
            groupBox2.Controls.Add(secantButton);
            groupBox2.Controls.Add(cosecantButton);
            groupBox2.Controls.Add(tangentButton);
            groupBox2.Controls.Add(cosineButton);
            groupBox2.Controls.Add(sineButton);
            groupBox2.Location = new Point(30, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(254, 100);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Trigonometric Functions";
            // 
            // cotengantbutton
            // 
            cotengantbutton.Location = new Point(175, 58);
            cotengantbutton.Name = "cotengantbutton";
            cotengantbutton.Size = new Size(75, 23);
            cotengantbutton.TabIndex = 27;
            cotengantbutton.Text = "Cotengant";
            cotengantbutton.UseVisualStyleBackColor = true;
            cotengantbutton.Click += cotengantbutton_Click;
            // 
            // secantButton
            // 
            secantButton.Location = new Point(13, 58);
            secantButton.Name = "secantButton";
            secantButton.Size = new Size(75, 23);
            secantButton.TabIndex = 26;
            secantButton.Text = "Secant";
            secantButton.UseVisualStyleBackColor = true;
            secantButton.Click += secantButton_Click;
            // 
            // cosecantButton
            // 
            cosecantButton.Location = new Point(94, 58);
            cosecantButton.Name = "cosecantButton";
            cosecantButton.Size = new Size(75, 23);
            cosecantButton.TabIndex = 25;
            cosecantButton.Text = "Cosecant";
            cosecantButton.UseVisualStyleBackColor = true;
            cosecantButton.Click += cosecantButton_Click;
            // 
            // tangentButton
            // 
            tangentButton.Location = new Point(175, 29);
            tangentButton.Name = "tangentButton";
            tangentButton.Size = new Size(75, 23);
            tangentButton.TabIndex = 24;
            tangentButton.Text = "Tangent";
            tangentButton.UseVisualStyleBackColor = true;
            tangentButton.Click += tangentButton_Click;
            // 
            // cosineButton
            // 
            cosineButton.Location = new Point(94, 29);
            cosineButton.Name = "cosineButton";
            cosineButton.Size = new Size(75, 23);
            cosineButton.TabIndex = 23;
            cosineButton.Text = "Cosine";
            cosineButton.UseVisualStyleBackColor = true;
            cosineButton.Click += cosineButton_Click;
            // 
            // sineButton
            // 
            sineButton.Location = new Point(13, 29);
            sineButton.Name = "sineButton";
            sineButton.Size = new Size(75, 23);
            sineButton.TabIndex = 22;
            sineButton.Text = "Sine";
            sineButton.UseVisualStyleBackColor = true;
            sineButton.Click += sineButton_Click;
            // 
            // objectSideZ
            // 
            objectSideZ.AutoSize = true;
            objectSideZ.Location = new Point(54, 204);
            objectSideZ.Name = "objectSideZ";
            objectSideZ.Size = new Size(0, 15);
            objectSideZ.TabIndex = 15;
            // 
            // ObjectSideY
            // 
            ObjectSideY.AutoSize = true;
            ObjectSideY.Location = new Point(49, 162);
            ObjectSideY.Name = "ObjectSideY";
            ObjectSideY.Size = new Size(0, 15);
            ObjectSideY.TabIndex = 14;
            // 
            // objectSide
            // 
            objectSide.AutoSize = true;
            objectSide.Location = new Point(54, 120);
            objectSide.Name = "objectSide";
            objectSide.Size = new Size(0, 15);
            objectSide.TabIndex = 13;
            // 
            // objectHypotenuse
            // 
            objectHypotenuse.AutoSize = true;
            objectHypotenuse.Location = new Point(84, 80);
            objectHypotenuse.Name = "objectHypotenuse";
            objectHypotenuse.Size = new Size(0, 15);
            objectHypotenuse.TabIndex = 12;
            // 
            // objectName
            // 
            objectName.AutoSize = true;
            objectName.Location = new Point(54, 34);
            objectName.Name = "objectName";
            objectName.Size = new Size(0, 15);
            objectName.TabIndex = 11;
            // 
            // sideZLabelIndicator
            // 
            sideZLabelIndicator.AutoSize = true;
            sideZLabelIndicator.Location = new Point(6, 204);
            sideZLabelIndicator.Name = "sideZLabelIndicator";
            sideZLabelIndicator.Size = new Size(42, 15);
            sideZLabelIndicator.TabIndex = 9;
            sideZLabelIndicator.Text = "Side Z:";
            // 
            // sideYLabelIndicator
            // 
            sideYLabelIndicator.AutoSize = true;
            sideYLabelIndicator.Location = new Point(6, 162);
            sideYLabelIndicator.Name = "sideYLabelIndicator";
            sideYLabelIndicator.Size = new Size(42, 15);
            sideYLabelIndicator.TabIndex = 8;
            sideYLabelIndicator.Text = "Side Y:";
            // 
            // sideXLabelIndicator
            // 
            sideXLabelIndicator.AutoSize = true;
            sideXLabelIndicator.Location = new Point(6, 120);
            sideXLabelIndicator.Name = "sideXLabelIndicator";
            sideXLabelIndicator.Size = new Size(42, 15);
            sideXLabelIndicator.TabIndex = 7;
            sideXLabelIndicator.Text = "Side X:";
            // 
            // hypotenuseLabelIndicator
            // 
            hypotenuseLabelIndicator.AutoSize = true;
            hypotenuseLabelIndicator.Location = new Point(6, 79);
            hypotenuseLabelIndicator.Name = "hypotenuseLabelIndicator";
            hypotenuseLabelIndicator.Size = new Size(74, 15);
            hypotenuseLabelIndicator.TabIndex = 6;
            hypotenuseLabelIndicator.Text = "Hypotenuse:";
            // 
            // nameLabelIndicator
            // 
            nameLabelIndicator.AutoSize = true;
            nameLabelIndicator.Location = new Point(6, 34);
            nameLabelIndicator.Name = "nameLabelIndicator";
            nameLabelIndicator.Size = new Size(42, 15);
            nameLabelIndicator.TabIndex = 0;
            nameLabelIndicator.Text = "Name:";
            // 
            // hypotenuseLabel
            // 
            hypotenuseLabel.Location = new Point(0, 0);
            hypotenuseLabel.Name = "hypotenuseLabel";
            hypotenuseLabel.Size = new Size(100, 23);
            hypotenuseLabel.TabIndex = 10;
            hypotenuseLabel.Text = "Object Details";
            // 
            // RightTriangle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 372);
            Controls.Add(groupBox1);
            Controls.Add(generateObjectGroupBox);
            MaximizeBox = false;
            Name = "RightTriangle";
            ShowIcon = false;
            Text = "RightTriangle";
            generateObjectGroupBox.ResumeLayout(false);
            generateObjectGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void generateObjectButton_Click(object sender, EventArgs e)
        {
            // Implement generation logic here
            try
            {
                // Get the values entered by the user
                string triangleName = nameTextBox.Text;
                double sideX = Convert.ToDouble(sideXTextBox.Text);
                double sideY = Convert.ToDouble(sideYTextBox.Text);

                // Create a new RightTriangle object with the provided values
                objects.TriangleExtended.RightTriangle rightTriangle = new objects.TriangleExtended.RightTriangle(triangleName, "RightTriangle", sideX, sideY);

                // Update the label with the newly created RightTriangle object's information
                objectName.Text = rightTriangle.getName();
                objectHypotenuse.Text = rightTriangle.getHypotenuse();
                objectSide.Text = rightTriangle.getX().ToString();
                ObjectSideY.Text = rightTriangle.getY().ToString();
                objectSideZ.Text = rightTriangle.getZ().ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for side lengths.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void sineButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values entered by the user
                string triangleName = nameTextBox.Text;
                double sideX = Convert.ToDouble(sideXTextBox.Text);
                double sideY = Convert.ToDouble(sideYTextBox.Text);

                // Create a new RightTriangle object with the provided values
                objects.TriangleExtended.RightTriangle rightTriangle = new objects.TriangleExtended.RightTriangle(triangleName, "RightTriangle", sideX, sideY);

                // Calculate the sine of the angle
                double sine = Trigonometry.Sine(rightTriangle);

                // Display the result in a message box
                MessageBox.Show($"Sine of the angle: {sine}", "Sine Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for side lengths.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void cosineButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values entered by the user
                string triangleName = nameTextBox.Text;
                double sideX = Convert.ToDouble(sideXTextBox.Text);
                double sideY = Convert.ToDouble(sideYTextBox.Text);

                // Create a new RightTriangle object with the provided values
                objects.TriangleExtended.RightTriangle rightTriangle = new objects.TriangleExtended.RightTriangle(triangleName, "RightTriangle", sideX, sideY);

                // Calculate the cosine of the angle
                double cosine = Trigonometry.Cosine(rightTriangle);

                // Display the result in a message box
                MessageBox.Show($"Cosine of the angle: {cosine}", "Cosine Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for side lengths.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void tangentButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values entered by the user
                string triangleName = nameTextBox.Text;
                double sideX = Convert.ToDouble(sideXTextBox.Text);
                double sideY = Convert.ToDouble(sideYTextBox.Text);

                // Create a new RightTriangle object with the provided values
                objects.TriangleExtended.RightTriangle rightTriangle = new objects.TriangleExtended.RightTriangle(triangleName, "RightTriangle", sideX, sideY);

                // Calculate the tangent of the angle
                double tangent = Trigonometry.Tangent(rightTriangle);

                // Display the result in a message box
                MessageBox.Show($"Tangent of the angle: {tangent}", "Tangent Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for side lengths.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void secantButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values entered by the user
                string triangleName = nameTextBox.Text;
                double sideX = Convert.ToDouble(sideXTextBox.Text);
                double sideY = Convert.ToDouble(sideYTextBox.Text);

                // Create a new RightTriangle object with the provided values
                objects.TriangleExtended.RightTriangle rightTriangle = new objects.TriangleExtended.RightTriangle(triangleName, "RightTriangle", sideX, sideY);

                // Calculate the secant of the angle
                double secant = Trigonometry.Secant(rightTriangle);

                // Display the result in a message box
                MessageBox.Show($"Secant of the angle: {secant}", "Secant Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for side lengths.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void cosecantButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values entered by the user
                string triangleName = nameTextBox.Text;
                double sideX = Convert.ToDouble(sideXTextBox.Text);
                double sideY = Convert.ToDouble(sideYTextBox.Text);

                // Create a new RightTriangle object with the provided values
                objects.TriangleExtended.RightTriangle rightTriangle = new objects.TriangleExtended.RightTriangle(triangleName, "RightTriangle", sideX, sideY);

                // Calculate the cosecant of the angle
                double cosecant = Trigonometry.Cosecant(rightTriangle);

                // Display the result in a message box
                MessageBox.Show($"Cosecant of the angle: {cosecant}", "Cosecant Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for side lengths.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void cotengantbutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values entered by the user
                string triangleName = nameTextBox.Text;
                double sideX = Convert.ToDouble(sideXTextBox.Text);
                double sideY = Convert.ToDouble(sideYTextBox.Text);

                // Create a new RightTriangle object with the provided values
                objects.TriangleExtended.RightTriangle rightTriangle = new objects.TriangleExtended.RightTriangle(triangleName, "RightTriangle", sideX, sideY);

                // Calculate the cotangent of the angle
                double cotangent = Trigonometry.Cotangent(rightTriangle);

                // Display the result in a message box
                MessageBox.Show($"Cotangent of the angle: {cotangent}", "Cotangent Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for side lengths.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private Label objectSideZ;
        private Label ObjectSideY;
        private Label objectSide;
        private Label objectHypotenuse;
        private Label objectName;
        private GroupBox groupBox2;
        private Button cotengantbutton;
        private Button secantButton;
        private Button cosecantButton;
        private Button tangentButton;
        private Button cosineButton;
        private Button sineButton;
    }
}