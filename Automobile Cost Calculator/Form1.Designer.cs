﻿namespace Automobile_Cost_Calculator
{
    partial class frmAutomobileCost
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InTxtCarNote = new System.Windows.Forms.TextBox();
            this.InTxtCarInsurance = new System.Windows.Forms.TextBox();
            this.InTxtCarGas = new System.Windows.Forms.TextBox();
            this.InTxtCarOil = new System.Windows.Forms.TextBox();
            this.InTxtCarRepairs = new System.Windows.Forms.TextBox();
            this.InTxtCarRegistration = new System.Windows.Forms.TextBox();
            this.outTxtResults = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car Insurance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Oil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Repairs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Registration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 6;
            // 
            // InTxtCarNote
            // 
            this.InTxtCarNote.Location = new System.Drawing.Point(185, 60);
            this.InTxtCarNote.Name = "InTxtCarNote";
            this.InTxtCarNote.Size = new System.Drawing.Size(285, 31);
            this.InTxtCarNote.TabIndex = 7;
            // 
            // InTxtCarInsurance
            // 
            this.InTxtCarInsurance.Location = new System.Drawing.Point(185, 97);
            this.InTxtCarInsurance.Name = "InTxtCarInsurance";
            this.InTxtCarInsurance.Size = new System.Drawing.Size(285, 31);
            this.InTxtCarInsurance.TabIndex = 8;
           
            // 
            // InTxtCarGas
            // 
            this.InTxtCarGas.Location = new System.Drawing.Point(185, 143);
            this.InTxtCarGas.Name = "InTxtCarGas";
            this.InTxtCarGas.Size = new System.Drawing.Size(285, 31);
            this.InTxtCarGas.TabIndex = 9;
            // 
            // InTxtCarOil
            // 
            this.InTxtCarOil.Location = new System.Drawing.Point(185, 185);
            this.InTxtCarOil.Name = "InTxtCarOil";
            this.InTxtCarOil.Size = new System.Drawing.Size(285, 31);
            this.InTxtCarOil.TabIndex = 10;
            
            // 
            // InTxtCarRepairs
            // 
            this.InTxtCarRepairs.Location = new System.Drawing.Point(185, 225);
            this.InTxtCarRepairs.Name = "InTxtCarRepairs";
            this.InTxtCarRepairs.Size = new System.Drawing.Size(285, 31);
            this.InTxtCarRepairs.TabIndex = 11;
            // 
            // InTxtCarRegistration
            // 
            this.InTxtCarRegistration.Location = new System.Drawing.Point(185, 265);
            this.InTxtCarRegistration.Name = "InTxtCarRegistration";
            this.InTxtCarRegistration.Size = new System.Drawing.Size(285, 31);
            this.InTxtCarRegistration.TabIndex = 12;
            // 
            // outTxtResults
            // 
            this.outTxtResults.Location = new System.Drawing.Point(12, 423);
            this.outTxtResults.Multiline = true;
            this.outTxtResults.Name = "outTxtResults";
            this.outTxtResults.Size = new System.Drawing.Size(541, 140);
            this.outTxtResults.TabIndex = 13;
            this.outTxtResults.Text = " ***Final Results***\r\nTotal Monthly Cost: $\r\nTotal Annual Cost: $\r\n\r\n";
        
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(203, 353);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(134, 39);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // frmAutomobileCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 618);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.outTxtResults);
            this.Controls.Add(this.InTxtCarRegistration);
            this.Controls.Add(this.InTxtCarRepairs);
            this.Controls.Add(this.InTxtCarOil);
            this.Controls.Add(this.InTxtCarGas);
            this.Controls.Add(this.InTxtCarInsurance);
            this.Controls.Add(this.InTxtCarNote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAutomobileCost";
            this.Text = "Auto Cost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InTxtCarNote;
        private System.Windows.Forms.TextBox InTxtCarInsurance;
        private System.Windows.Forms.TextBox InTxtCarGas;
        private System.Windows.Forms.TextBox InTxtCarOil;
        private System.Windows.Forms.TextBox InTxtCarRepairs;
        private System.Windows.Forms.TextBox InTxtCarRegistration;
        private System.Windows.Forms.TextBox outTxtResults;
        private System.Windows.Forms.Button btnCalculate;
    }
}
