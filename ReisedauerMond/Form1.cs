using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReisedauerMond
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            bool timeAsDays = selDays.Checked;
            try
            {
                Travel travel = new Travel(inputSpeed.Text, timeAsDays);
                resultBox.Text = travel.GetTravelTime().ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
