namespace ATM
{
    partial class GeneralMenu
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
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnOtherServices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.Location = new System.Drawing.Point(40, 52);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(100, 41);
            this.btnWithdrawal.TabIndex = 0;
            this.btnWithdrawal.Text = "Withdrawal";
            this.btnWithdrawal.UseVisualStyleBackColor = true;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Location = new System.Drawing.Point(40, 122);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(100, 40);
            this.btnCheckBalance.TabIndex = 1;
            this.btnCheckBalance.Text = "Check balance";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(40, 201);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(100, 40);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(573, 52);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(93, 41);
            this.btnPayments.TabIndex = 3;
            this.btnPayments.Text = "Paymetns";
            this.btnPayments.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(573, 122);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(93, 40);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnOtherServices
            // 
            this.btnOtherServices.Location = new System.Drawing.Point(573, 201);
            this.btnOtherServices.Name = "btnOtherServices";
            this.btnOtherServices.Size = new System.Drawing.Size(93, 39);
            this.btnOtherServices.TabIndex = 5;
            this.btnOtherServices.Text = "Other Services";
            this.btnOtherServices.UseVisualStyleBackColor = true;
            // 
            // GeneralMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 350);
            this.Controls.Add(this.btnOtherServices);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnWithdrawal);
            this.Name = "GeneralMenu";
            this.Text = "GeneralMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnOtherServices;
    }
}