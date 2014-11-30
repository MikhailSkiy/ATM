namespace ATM
{
    partial class WithReceiptWindow
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
            this.btnWithReceipt = new System.Windows.Forms.Button();
            this.btnWithoutReceipt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWithReceipt
            // 
            this.btnWithReceipt.Location = new System.Drawing.Point(61, 100);
            this.btnWithReceipt.Name = "btnWithReceipt";
            this.btnWithReceipt.Size = new System.Drawing.Size(117, 38);
            this.btnWithReceipt.TabIndex = 0;
            this.btnWithReceipt.Text = "With receipt";
            this.btnWithReceipt.UseVisualStyleBackColor = true;
            this.btnWithReceipt.Click += new System.EventHandler(this.btnWithReceipt_Click);
            // 
            // btnWithoutReceipt
            // 
            this.btnWithoutReceipt.Location = new System.Drawing.Point(500, 100);
            this.btnWithoutReceipt.Name = "btnWithoutReceipt";
            this.btnWithoutReceipt.Size = new System.Drawing.Size(124, 38);
            this.btnWithoutReceipt.TabIndex = 1;
            this.btnWithoutReceipt.Text = "Without receipt";
            this.btnWithoutReceipt.UseVisualStyleBackColor = true;
            this.btnWithoutReceipt.Click += new System.EventHandler(this.btnWithoutReceipt_Click);
            // 
            // WithReceiptWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 358);
            this.Controls.Add(this.btnWithoutReceipt);
            this.Controls.Add(this.btnWithReceipt);
            this.Name = "WithReceiptWindow";
            this.Text = "WithReceiptWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWithReceipt;
        private System.Windows.Forms.Button btnWithoutReceipt;
    }
}