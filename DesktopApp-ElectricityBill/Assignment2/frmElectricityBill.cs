using CustomerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    /// <summary>
    /// Assignment 2. 
    /// application that process electricity bill of multiple customers. 
    /// allows getting customer data from frmAddCustomer
    /// keep track of added customers and stat data (total usage, No of customers added, average bill)
    /// Author: Fatemeh Safari
    /// date: July 10, 2021 
    /// </summary>
    public partial class frmElectricityBill : Form
    {
        //create a new customer list which will be populated later by getting customer data from the second form
        List<Customers> customerList = new List<Customers>();

        //class-level variables for the stat data
        private decimal totalKW = 0; //can't access methods before the form is loaded 
        private decimal averageBill = 0;
        public frmElectricityBill()
        {
            InitializeComponent();
        }

        //when form loads, display the initial stat data 
        private void frmElectricityBill_Load(object sender, EventArgs e)
        {
            lblNoCustomers.Text = customerList.Count.ToString();
            lblTotalKW.Text = totalKW.ToString(); //replace with method? 
            lblAverage.Text = averageBill.ToString("c"); //replace with method? 
        }

        //when Add button is clicked, add new customer data
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create obj of second form to access customer data 
            frmAddCustomer secondForm = new frmAddCustomer();
            //display the second form data
            DialogResult result = secondForm.ShowDialog();

            //if the result is ok: get customer data, add to the customer list and display:
            if (result==DialogResult.OK)
            {
                //get data from second form (Tag)
                Customers newCust = (Customers)secondForm.Tag;

                //add to the list
                customerList.Add(newCust);

                //display data in the first form
                Display();
            }

        }

        private void Display()
        {
            lstCustomers.Items.Clear();
            foreach(Customers c in customerList)
            {
                lstCustomers.Items.Add(c);
            }
            lblAverage.Text = AverageBill().ToString("c");
            lblNoCustomers.Text = customerList.Count.ToString();
            lblTotalKW.Text = TotalUsage().ToString();
        }


        //methods to calculate the stat data
        private decimal TotalUsage()
        {
            foreach (Customers c in customerList) totalKW += c.KW;
            return totalKW;
        }

        private decimal AverageBill()
        {
            foreach (Customers c in customerList) averageBill += c.Bill;
            return averageBill / customerList.Count();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
