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
    public partial class Sphere : Form
    {
        public Sphere()
        {
            InitializeComponent();
        }

        private void generateObjectButton_Click(object sender, EventArgs e)
        {
            //Initialize object variables
            String name = nametextBox.Text;
            string radiusText = radiustextBox.Text;
            float radius = float.Parse(radiusText);
            string diameterText = diameterTextBox.Text;
            float diameter = float.Parse(diameterText);
            String objectType = "Sphere";
            Sphr sphere = new Sphr(name, objectType, radius, diameter);

            objectNamelabel.Text = sphere.getName();
            radiusIndicator.Text = sphere.getRadius().ToString();
            diameterIndicatorLabel.Text = sphere.getDiameter().ToString();
            volumeIndicatorlabel.Text = sphere.Volume().ToString();
            surfaceAreaIndicator.Text = sphere.SurfaceArea().ToString();
        }
    }
}
