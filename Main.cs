using Xrigonometry.Views;
using Xrigonometry.Views.TriangleExtended;

namespace Xrigonometry
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void sphereButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            Sphere sphereForm = new Sphere();

            // Show the new form
            sphereForm.Show();
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            Triangle triangleForm = new Triangle();

            // Show the new form
            triangleForm.Show();
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            Square squareForm = new Square();

            // Show the new form
            squareForm.Show();
        }

        private void Rectanglebutton_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            Rctngle rectangleForm = new Rctngle();

            // Show the new form
            rectangleForm.Show();
        }

        private void polygonButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            Polygon polygonForm = new Polygon();

            // Show the new form
            polygonForm.Show();
        }

        private void hexagonButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            Hexagon hexagonForm = new Hexagon();

            // Show the new form
            hexagonForm.Show();
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            Circle circleForm = new Circle();

            // Show the new form
            circleForm.Show();
        }

        private void rightTriangleButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            RightTriangle rightTriangleForm = new RightTriangle();

            // Show the new form
            rightTriangleForm.Show();
        }

        private void pentagonButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            Pentagon pentagonForm = new Pentagon();

            // Show the new form
            pentagonForm.Show();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Version: 1.0\n" +
                $" Release Date: April 4th 2024\n" +
                $" Developed by: Deniz K. Acikbas (X27)\n" +
                $" 2024 © Deniz K. Acikbas. All rights are reserved.", "About Xrigonometry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}