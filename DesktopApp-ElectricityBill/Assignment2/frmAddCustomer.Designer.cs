
namespace Assignment2
{
    partial class frmAddCustomer
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
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKWUsed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btcCalcBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(142, 47);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(197, 29);
            this.txtFName.TabIndex = 1;
            this.txtFName.Tag = "FirstName";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(142, 121);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(197, 29);
            this.txtLName.TabIndex = 3;
            this.txtLName.Tag = "LastName";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtKWUsed
            // 
            this.txtKWUsed.Location = new System.Drawing.Point(142, 198);
            this.txtKWUsed.Name = "txtKWUsed";
            this.txtKWUsed.Size = new System.Drawing.Size(197, 29);
            this.txtKWUsed.TabIndex = 5;
            this.txtKWUsed.Tag = "KW";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "kW Used";
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBillAmount.Location = new System.Drawing.Point(205, 273);
            this.lblBillAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(158, 29);
            this.lblBillAmount.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 51);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "$Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(256, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 51);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "$Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btcCalcBill
            // 
            this.btcCalcBill.Location = new System.Drawing.Point(13, 273);
            this.btcCalcBill.Name = "btcCalcBill";
            this.btcCalcBill.Size = new System.Drawing.Size(154, 37);
            this.btcCalcBill.TabIndex = 10;
            this.btcCalcBill.Text = "calculate Bill";
            this.btcCalcBill.UseVisualStyleBackColor = true;
            this.btcCalcBill.Click += new System.EventHandler(this.btcCalcBill_Click);
            // 
            // frmAddCustomer
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(434, 486);
            this.Controls.Add(this.btcCalcBill);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblBillAmount);
            this.Controls.Add(this.txtKWUsed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddCustomer";
            this.Load += new System.EventHandler(this.frmAddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKWUsed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btcCalcBill;
    }
}