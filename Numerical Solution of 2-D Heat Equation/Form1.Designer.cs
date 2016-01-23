namespace Numerical_Solution_of_2_D_Heat_Equation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iteration_num = new System.Windows.Forms.TextBox();
            this.num_iteration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.biot_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.initial_temperature = new System.Windows.Forms.TextBox();
            this.left = new System.Windows.Forms.TextBox();
            this.right = new System.Windows.Forms.TextBox();
            this.bottom = new System.Windows.Forms.TextBox();
            this.top = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.processor_num = new System.Windows.Forms.TextBox();
            this.process = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ROW = new System.Windows.Forms.TextBox();
            this.COL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // iteration_num
            // 
            this.iteration_num.Location = new System.Drawing.Point(251, 61);
            this.iteration_num.Name = "iteration_num";
            this.iteration_num.Size = new System.Drawing.Size(100, 22);
            this.iteration_num.TabIndex = 0;
            this.iteration_num.Text = "10";
            // 
            // num_iteration
            // 
            this.num_iteration.AutoSize = true;
            this.num_iteration.Location = new System.Drawing.Point(50, 66);
            this.num_iteration.Name = "num_iteration";
            this.num_iteration.Size = new System.Drawing.Size(94, 17);
            this.num_iteration.TabIndex = 1;
            this.num_iteration.Text = "num_iteration";
            this.num_iteration.Click += new System.EventHandler(this.num_iteration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "biot number";
            // 
            // biot_number
            // 
            this.biot_number.Location = new System.Drawing.Point(251, 115);
            this.biot_number.Name = "biot_number";
            this.biot_number.Size = new System.Drawing.Size(100, 22);
            this.biot_number.TabIndex = 3;
            this.biot_number.Text = "0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "initial temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "left side";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "right side";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "bottom side";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "top side";
            // 
            // initial_temperature
            // 
            this.initial_temperature.Location = new System.Drawing.Point(251, 157);
            this.initial_temperature.Name = "initial_temperature";
            this.initial_temperature.Size = new System.Drawing.Size(100, 22);
            this.initial_temperature.TabIndex = 9;
            this.initial_temperature.Text = "35";
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(251, 196);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(100, 22);
            this.left.TabIndex = 10;
            this.left.Text = "20";
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(251, 234);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(100, 22);
            this.right.TabIndex = 11;
            this.right.Text = "20";
            // 
            // bottom
            // 
            this.bottom.Location = new System.Drawing.Point(251, 271);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(100, 22);
            this.bottom.TabIndex = 12;
            this.bottom.Text = "100";
            // 
            // top
            // 
            this.top.Location = new System.Drawing.Point(251, 304);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(100, 22);
            this.top.TabIndex = 13;
            this.top.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "processor num";
            // 
            // processor_num
            // 
            this.processor_num.Location = new System.Drawing.Point(251, 341);
            this.processor_num.Name = "processor_num";
            this.processor_num.Size = new System.Drawing.Size(100, 22);
            this.processor_num.TabIndex = 15;
            this.processor_num.Text = "1";
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(113, 471);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(140, 46);
            this.process.TabIndex = 16;
            this.process.Text = "process";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "row size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "column size";
            // 
            // ROW
            // 
            this.ROW.Location = new System.Drawing.Point(251, 377);
            this.ROW.Name = "ROW";
            this.ROW.Size = new System.Drawing.Size(100, 22);
            this.ROW.TabIndex = 19;
            this.ROW.Text = "5";
            // 
            // COL
            // 
            this.COL.Location = new System.Drawing.Point(251, 408);
            this.COL.Name = "COL";
            this.COL.Size = new System.Drawing.Size(100, 22);
            this.COL.TabIndex = 20;
            this.COL.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 586);
            this.Controls.Add(this.COL);
            this.Controls.Add(this.ROW);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.process);
            this.Controls.Add(this.processor_num);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.top);
            this.Controls.Add(this.bottom);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.initial_temperature);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.biot_number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_iteration);
            this.Controls.Add(this.iteration_num);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iteration_num;
        private System.Windows.Forms.Label num_iteration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox biot_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox initial_temperature;
        private System.Windows.Forms.TextBox left;
        private System.Windows.Forms.TextBox right;
        private System.Windows.Forms.TextBox bottom;
        private System.Windows.Forms.TextBox top;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox processor_num;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ROW;
        private System.Windows.Forms.TextBox COL;
    }
}

