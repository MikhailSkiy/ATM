namespace ATM
{
    partial class TakeCashWindow
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
            this.btn100 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn300 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn1000 = new System.Windows.Forms.Button();
            this.btnAnotherAmount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(39, 65);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(99, 39);
            this.btn100.TabIndex = 0;
            this.btn100.Text = "100";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn200
            // 
            this.btn200.Location = new System.Drawing.Point(39, 167);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(99, 37);
            this.btn200.TabIndex = 1;
            this.btn200.Text = "200";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Click += new System.EventHandler(this.btn200_Click);
            // 
            // btn300
            // 
            this.btn300.Location = new System.Drawing.Point(39, 260);
            this.btn300.Name = "btn300";
            this.btn300.Size = new System.Drawing.Size(99, 37);
            this.btn300.TabIndex = 2;
            this.btn300.Text = "300";
            this.btn300.UseVisualStyleBackColor = true;
            this.btn300.Click += new System.EventHandler(this.btn300_Click);
            // 
            // btn500
            // 
            this.btn500.Location = new System.Drawing.Point(605, 65);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(111, 39);
            this.btn500.TabIndex = 3;
            this.btn500.Text = "500";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
            // 
            // btn1000
            // 
            this.btn1000.Location = new System.Drawing.Point(605, 167);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(111, 37);
            this.btn1000.TabIndex = 4;
            this.btn1000.Text = "1000";
            this.btn1000.UseVisualStyleBackColor = true;
            this.btn1000.Click += new System.EventHandler(this.btn1000_Click);
            // 
            // btnAnotherAmount
            // 
            this.btnAnotherAmount.Location = new System.Drawing.Point(605, 252);
            this.btnAnotherAmount.Name = "btnAnotherAmount";
            this.btnAnotherAmount.Size = new System.Drawing.Size(111, 45);
            this.btnAnotherAmount.TabIndex = 5;
            this.btnAnotherAmount.Text = "button1";
            this.btnAnotherAmount.UseVisualStyleBackColor = true;
            // 
            // TakeCashWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 404);
            this.Controls.Add(this.btnAnotherAmount);
            this.Controls.Add(this.btn1000);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btn300);
            this.Controls.Add(this.btn200);
            this.Controls.Add(this.btn100);
            this.Name = "TakeCashWindow";
            this.Text = "TakeCashWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn300;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Button btnAnotherAmount;
    }
}