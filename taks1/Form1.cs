using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taks1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void operations()
        {
            try
            {
                var vector1x = double.Parse(textVector1x.Text);

                var vector1y = double.Parse(textVector1y.Text);

                var vector1z = double.Parse(textVector1z.Text);

                Vector vector1 = new Vector(vector1x, vector1y, vector1z);

                var vector2x = double.Parse(textVector2x.Text);

                var vector2y = double.Parse(textVector2y.Text);

                var vector2z = double.Parse(textVector2z.Text);

                Vector vector2 = new Vector(vector2x, vector2y, vector2z);

                textVectorlength1.Text = vector1.Vectorlength().ToString();
                textVectorlength2.Text = vector2.Vectorlength().ToString();

                var message = "";
                switch (cmbOperation.Text)
                {
                    case "+ векторов":
                        message = (vector1 + vector2).Verbose();
                        break;
                    case "- векторов":
                        message = (vector1 - vector2).Verbose();
                        break;
                    case "* векторов":
                        message = (vector1 * vector2).ToString();
                        break;
                    case "векторное произведение":
                        message = Vector.VectorProduct(vector1, vector2).Verbose();
                        break;
                }
                textResult.Text = message;
            }
            catch (FormatException)
            {

            }

        }

        private void onValueChanged(object sender, EventArgs e)
        {
            operations();
        }
    }
}
