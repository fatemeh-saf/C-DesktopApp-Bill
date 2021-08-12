
namespace Assignment2
{
    partial class frmElectricityBill
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.grpStat = new System.Windows.Forms.GroupBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalKW = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNoCustomers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 21;
            this.lstCustomers.Location = new System.Drawing.Point(29, 35);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(524, 361);
            this.lstCustomers.TabIndex = 0;
            // 
            // grpStat
            // 
            this.grpStat.Controls.Add(this.lblAverage);
            this.grpStat.Controls.Add(this.label4);
            this.grpStat.Controls.Add(this.lblTotalKW);
            this.grpStat.Controls.Add(this.label3);
            this.grpStat.Controls.Add(this.lblNoCustomers);
            this.grpStat.Controls.Add(this.label1);
            this.grpStat.Location = new System.Drawing.Point(574, 35);
            this.grpStat.Name = "grpStat";
            this.grpStat.Size = new System.Drawing.Size(432, 224);
            this.grpStat.TabIndex = 1;
            this.grpStat.TabStop = false;
            this.grpStat.Text = "Stat Data";
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Location = new System.Drawing.Point(233, 167);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(158, 29);
            this.lblAverage.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Average Bill Amount";
            // 
            // lblTotalKW
            // 
            this.lblTotalKW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalKW.Location = new System.Drawing.Point(233, 110);
            this.lblTotalKW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalKW.Name = "lblTotalKW";
            this.lblTotalKW.Size = new System.Drawing.Size(158, 29);
            this.lblTotalKW.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total kW Used";
            // 
            // lblNoCustomers
            // 
            this.lblNoCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNoCustomers.Location = new System.Drawing.Point(233, 50);
            this.lblNoCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoCustomers.Name = "lblNoCustomers";
            this.lblNoCustomers.Size = new System.Drawing.Size(158, 29);
            this.lblNoCustomers.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "#Customers Processed";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(581, 287);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 51);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "$Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(807, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 51);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "$Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmElectricityBill
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1031, 564);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpStat);
            this.Controls.Add(this.lstCustomers);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmElectricityBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electricity Bill";
            this.Load += new System.EventHandler(this.frmElectricityBill_Load);
            this.grpStat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.GroupBox grpStat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalKW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNoCustomers;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
    }
}

