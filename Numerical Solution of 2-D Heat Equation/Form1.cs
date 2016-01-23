using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerical_Solution_of_2_D_Heat_Equation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void num_iteration_Click(object sender, EventArgs e)
        {

        }

        private void process_Click(object sender, EventArgs e)
        {
            controller.user_input(iteration_num.Text, biot_number.Text, initial_temperature.Text, left.Text, right.Text, bottom.Text, top.Text, processor_num.Text, ROW.Text, COL.Text);
            controller.call_seq();
        }


    }
}
