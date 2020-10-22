using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile_Cost_Calculator
{
    public partial class frmAutomobileCost : Form
    {
        public frmAutomobileCost()
        {
            InitializeComponent();
        }

        private void submitExpenses(object sender, EventArgs e)
        {
            String carNoteStr = InTxtCarNote.Text;
            String carInsureStr = InTxtCarInsurance.Text;
            String carGasStr = InTxtCarGas.Text;
            String carOilStr = InTxtCarOil.Text;
            String carRepairStr = InTxtCarRepairs.Text;
            String carRegStr = InTxtCarRegistration.Text;


            Double carNoteDbl = Convert.ToDouble(carNoteStr);
            Double carInsureDbl = Convert.ToDouble(carInsureStr);
            Double carGasDbl = Convert.ToDouble(carGasStr);
            Double carOilDbl = Convert.ToDouble(carOilStr);
            Double carRepairDbl = Convert.ToDouble(carRepairStr);
            Double carRegtrDbl = Convert.ToDouble(carRegStr);


            Double monthlyExpense = carNoteDbl + carInsureDbl + carGasDbl + carOilDbl + carOilDbl + carRepairDbl + carRegtrDbl;
            Double yearlyExpense = monthlyExpense * 2;


            outTxtResults.Text = "";

            outTxtResults.Text = "***Final Results***" + Environment.NewLine;
            outTxtResults.AppendText("Total Monthly Cost:" + monthlyExpense.ToString("C") + Environment.NewLine);
            outTxtResults.AppendText("Total yearly Cost:" + yearlyExpense.ToString("C") + Environment.NewLine);
        }
       
    }
}
