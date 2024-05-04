using objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xrigonometry.Views
{
    public partial class Rctngle : Form
    {
        public Rctngle()
        {
            InitializeComponent();
        }

        private void generateObjectButton_Click(object sender, EventArgs e)
        {
            //Initialize object variables
            String name = nametextBox.Text;
            string widthText = widthTextBox.Text;
            float width = float.Parse(widthText);
            string lengthText = lengthTextBox.Text;
            float length = float.Parse(lengthText);
            string diagonalText = diagonaltextBox.Text;
            float diagonal = float.Parse(lengthText);
            String objectType = "Sphere";
            objects.Rectangle rectangle = new objects.Rectangle(name, objectType, width, diagonal, length);

            objectNamelabel.Text = rectangle.getName();
            widthIndicator.Text = rectangle.getWidth().ToString();
            diagonallabel.Text = rectangle.getDiagonal().ToString();
            lengthIndicatorLabel.Text = rectangle.getLength().ToString();
            areaIndicatorlabel.Text = rectangle.Area().ToString();
            perimeterIndicator.Text = rectangle.Perimeter().ToString();
        }
    }
}
