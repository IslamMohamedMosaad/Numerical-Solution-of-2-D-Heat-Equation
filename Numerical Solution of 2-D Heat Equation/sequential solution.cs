using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Solution_of_2_D_Heat_Equation
{
   public class sequential_solution
    {

     
       public void calculate(int n, double c, room target_room, int num_iter,system_output DGV)
        {            
            double[,] new_temperature = new double[target_room.rows ,target_room.cols];
            double delta_s=1/(float)(n+1);
            double delta_t=  (delta_s*delta_s) / (4*c);

            DGV.after.ColumnCount = target_room.cols;
            DGV.after.RowCount = target_room.rows; 

            for(int i = 0 ; i <num_iter ; i++)
            {
                new_temperature = new double[target_room.rows, target_room.cols];

                for (int j = 0; j < target_room.rows; j++)
                {
                    for (int k = 0; k < target_room.cols; k++)
                    {
                        if (j == 0)
                            new_temperature[j, k] = target_room.Degree[j, k];
                        else if (j == target_room.rows - 1)
                            new_temperature[j, k] = target_room.Degree[j, k];
                        else if (k == 0)
                            new_temperature[j, k] = target_room.Degree[j, k];
                        else if (k == target_room.cols - 1)
                            new_temperature[j, k] = target_room.Degree[j, k];
                        else
                            new_temperature[j, k] = target_room.Degree[j, k] + (c * (delta_t / Math.Pow(delta_s, 2))) * (target_room.Degree[j + 1, k] + target_room.Degree[j - 1, k] - 4 * target_room.Degree[j, k] + target_room.Degree[j, k + 1] + target_room.Degree[j, k - 1]);
                       
                        if(i==num_iter-1)
                            DGV.after.Rows[j].Cells[k].Value = new_temperature[j, k];
                    } 
                }
                target_room.Degree = new_temperature;
            }
        }
    }
}
