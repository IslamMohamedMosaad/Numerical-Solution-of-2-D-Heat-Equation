using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Solution_of_2_D_Heat_Equation
{
    public class room
    {
        public int rows;
        public int cols;
        public double [,] Degree;
        

       public room(int iRows, int iCols)
        {
            rows = iRows;
            cols = iCols;
            Degree = new double[rows, cols];
        }

       public room intialize_room(double initial_temperature, double left_side, double right_side, double bottom_side, double top_side,system_output DGV)
        {
            DGV.before.ColumnCount = cols;
            DGV.before.RowCount = rows;

            for (int j = 0; j < rows; j++)
                for (int k = 0; k < cols; k++)
                {
                    if (j == 0)
                        Degree[j, k] = top_side;
                    else if (j == rows - 1)
                        Degree[j, k] = bottom_side;
                    else if (k == 0)
                        Degree[j, k] = left_side;
                    else if (k == cols - 1)
                        Degree[j, k] = right_side;
                    else
                        Degree[j, k] = initial_temperature;
                    DGV.before.Rows[j].Cells[k].Value = Degree[j, k];

                }
            
            return this;
        }
    }
}
