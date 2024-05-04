using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using objects;

namespace Xrigonometry.Views
{
    public partial class Square : Form
    {
        public Square()
        {
            InitializeComponent();
        }

        private void generateObjectButton_Click(object sender, EventArgs e)
        {
            // Get the name and side length entered by the user
            string squareName = nameTextBox.Text;
            double sideLength = Convert.ToDouble(sideTextBox.Text);

            // Create a new Square object with the provided values
            objects.Square square = new objects.Square(squareName, "Square", sideLength);

            // Update the object details labels with the newly created Square object's information
            objectNameLabel.Text = square.getName();
            perimeterLabel.Text = square.Perimeter().ToString();
            areaLabel.Text = square.Area().ToString();
        }
    }
}
