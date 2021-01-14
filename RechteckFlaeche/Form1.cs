using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RechteckFlaeche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            string inputWidth = widthInput.Text;
            string inputLength = lengthInput.Text;
            try
            {
                Rect rectangle = new Rect(inputLength, inputWidth);
                areaResult.Text = rectangle.getArea().ToString();
            }
            catch
            {
                MessageBox.Show("Input has to be a number.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
