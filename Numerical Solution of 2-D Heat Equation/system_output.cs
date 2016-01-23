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
    public partial class system_output : Form
    {
        public DataGridView before;
        public DataGridView after;
        public system_output()
        {
            InitializeComponent();
            before= dataGridView1;
            after = dataGridView2;
        }

        private void system_output_Load(object sender, EventArgs e)
        {

        }
    }
}
