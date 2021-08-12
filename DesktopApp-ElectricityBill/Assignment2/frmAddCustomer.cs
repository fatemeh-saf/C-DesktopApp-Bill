using CustomerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment2
{
    /// <summary>
    /// Assignment 2. 
    /// allows getting user data and creating customer obj
    /// keep track of customer electricity bill
    /// Author: Fatemeh Safari
    /// date: July 10, 2021 
    /// </summary>
    public partial class frmAddCustomer : Form
    {
        //new customer
        Customers newCust;
        private decimal bill = 0;
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        //when form loads display the initial bill amount value
        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            lblBillAmount.Text = bill.ToString();
        }
         
        //when button calculate is clicked, create new customer and save in form Tag property
        private void btcCalcBill_Click(object sender, EventArgs e)
        {
            //validating user input data: 
            if (Validator.IsPresent(txtFName)&& Validator.IsPresent(txtLName)&&
                Validator.IsPresent(txtKWUsed)&&Validator.IsNonNegativeDecimal(txtKWUsed))
            {
                //get the customer data from the form and instantiate the new customer object: 
                newCust = new Customers(txtFName.Text, txtLName.Text, Convert.ToDecimal(txtKWUsed.Text));
                bill = newCust.CalculateCharges();
                lblBillAmount.Text = bill.ToString("c");
                Refresh();
            }

                        
        }

        //store data in form tag property to be able to use it in the second form 
        private void btnSave_Click(object sender, EventArgs e)
        {   //validating user input data: 
            if (Validator.IsPresent(txtFName) && Validator.IsPresent(txtLName) &&
                Validator.IsPresent(txtKWUsed) && Validator.IsNonNegativeDecimal(txtKWUsed))
            {
                this.Tag = newCust;
                this.DialogResult = DialogResult.OK; //change the status to OK to use in the second form 

            }
                
        }



    }
}
