using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void calculateVector1length()
        {
            try
            {
                var vector1x = double.Parse(textVector1x.Text);

                var vector1y = double.Parse(textVector1y.Text);

                var vector1z = double.Parse(textVector1z.Text);

                Vector vector1 = new Vector(vector1x, vector1y, vector1z);

                textVectorlength1.Text = vector1.Vectorlength().ToString();
            }
            catch (FormatException)
            {

            }
        }
        private void calculateVector2length()
        {
            try
            {
                var vector2x = double.Parse(textVector2x.Text);

                var vector2y = double.Parse(textVector2y.Text);

                var vector2z = double.Parse(textVector2z.Text);

                Vector vector2 = new Vector(vector2x, vector2y, vector2z);

                textVectorlength2.Text = vector2.Vectorlength().ToString();
            }
            catch (FormatException)
            {

            }
        }

        private void textVector1x_TextChanged(object sender, EventArgs e)
        {
            calculateVector1length();
        }

        private void textVector2x_TextChanged(object sender, EventArgs e)
        {
            calculateVector2length();
        }

        private void textVector1y_TextChanged(object sender, EventArgs e)
        {
            calculateVector1length();
        }

        private void textVector2y_TextChanged(object sender, EventArgs e)
        {
            calculateVector2length();
        }

        private void textVector1z_TextChanged(object sender, EventArgs e)
        {
            calculateVector1length();
        }

        private void textVector2z_TextChanged(object sender, EventArgs e)
        {
            calculateVector2length();
        }
    }
}
