using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolarToRectangularConverter
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// About Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display messagebox describing the program
            MessageBox.Show("Use this application to convert your\nPolar Coordinates to easy to use 'x,y' coordinates\n\nEnjoy,\nTheCreator");
        }

        /// <summary>
        /// Exit Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Button Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Declare some constants
            int
                TWO = 2;

           if (txtRTheta != null)
            {
                //declare an array
                string[]
                    corSplit = new string[TWO];

                double
                    radius,
                    angle;
                //declare string to store coordinates in
                string
                    corRT = txtRTheta.Text;

                //Split the string and save values in array
                corSplit = corRT.Split();

                radius = double.Parse(corSplit[1]);
                angle = double.Parse(corSplit[0]);

                txtXY.Text = ($"({FindX(radius, angle):N2},{FindY(radius, angle):N2}");
            }

           else if (txtXY != null)
            {
                //declare an array
                string[]
                    corSplit = new string[TWO];

                //declare string to store coordinates in
                string 
                    corXY = txtXY.Text;

                //Split the string and save values in array
                corSplit = corXY.Split();

            }

            else
            {
                MessageBox.Show("Please enter the coordinates");
            }

        }

        static public double FindX(double radius, double angle)
        {
            //Multiply the radius by the cosine of the angle and return it
            double xCor = radius * (Math.Cos(angle));
            return xCor;
        }

        static public double FindY(double radius, double angle)
        {
            //Multiply the radius by the cosine of the angle and return it
            double yCor = radius * (Math.Sin(angle));
            return yCor;
        }
    }
}
