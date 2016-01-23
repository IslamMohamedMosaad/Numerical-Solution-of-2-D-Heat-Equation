using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Solution_of_2_D_Heat_Equation
{
   public class controller
    {

        static room temperature_room;
        static sequential_solution sequential;
        static system_output DGV;

        public static double initial_temperature ,left_side, right_side, bottom_side, top_side;
        public static double biot_numer;
        public static int iteration_number;
        public static int rows;
        public static int cols;
        public static int num_prosessor_used;
        public static system_output output;

       public static void user_input(string iteration_num, string biot_num, string initial_temper, string left, string right, string bottom, string top,string processor_used, string iRows, string iCols)
        {
            iteration_number = Convert.ToInt32(iteration_num);
            biot_numer = Convert.ToDouble(biot_num);
            initial_temperature = Convert.ToDouble(initial_temper);
            left_side = Convert.ToDouble(left);
            right_side = Convert.ToDouble(right);
            bottom_side = Convert.ToDouble(bottom);
            top_side = Convert.ToDouble(top);
            num_prosessor_used = Convert.ToInt32(processor_used);
            rows = Convert.ToInt32(iRows);
            cols = Convert.ToInt32(iCols);
        }

       public static void call_seq()
        {
            DGV = new system_output();
            temperature_room = new room(rows, cols);
            temperature_room = temperature_room.intialize_room(initial_temperature, left_side, right_side, bottom_side, top_side,DGV);
            sequential = new sequential_solution();
            sequential.calculate(rows, biot_numer, temperature_room, iteration_number,DGV);
            DGV.Show();

            
            
        }

    }
}
