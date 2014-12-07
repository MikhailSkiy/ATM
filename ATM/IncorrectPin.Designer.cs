namespace ATM
{
    partial class IncorrectPin
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
            this.lbIncorrectPin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIncorrectPin
            // 
            this.lbIncorrectPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIncorrectPin.Location = new System.Drawing.Point(126, 40);
            this.lbIncorrectPin.Name = "lbIncorrectPin";
            this.lbIncorrectPin.Size = new System.Drawing.Size(260, 105);
            this.lbIncorrectPin.TabIndex = 0;
            this.lbIncorrectPin.Text = "label1";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(197, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IncorrectPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbIncorrectPin);
            this.Name = "IncorrectPin";
            this.Text = "IncorrectPin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbIncorrectPin;
        private System.Windows.Forms.Button button1;
    }
}