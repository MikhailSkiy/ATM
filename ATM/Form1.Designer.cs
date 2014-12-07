namespace ATM
{
    partial class Form1
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnEnglishLng = new System.Windows.Forms.Button();
            this.btnRussianLng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(519, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 82);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnEnglishLng
            // 
            this.btnEnglishLng.Image = global::ATM.Properties.Resources.uk;
            this.btnEnglishLng.Location = new System.Drawing.Point(312, 105);
            this.btnEnglishLng.Name = "btnEnglishLng";
            this.btnEnglishLng.Size = new System.Drawing.Size(139, 82);
            this.btnEnglishLng.TabIndex = 1;
            this.btnEnglishLng.UseVisualStyleBackColor = true;
            this.btnEnglishLng.Click += new System.EventHandler(this.btnEnglishLng_Click);
            // 
            // btnRussianLng
            // 
            this.btnRussianLng.Image = global::ATM.Properties.Resources.flag_russia;
            this.btnRussianLng.Location = new System.Drawing.Point(117, 105);
            this.btnRussianLng.Name = "btnRussianLng";
            this.btnRussianLng.Size = new System.Drawing.Size(127, 82);
            this.btnRussianLng.TabIndex = 0;
            this.btnRussianLng.UseVisualStyleBackColor = true;
            this.btnRussianLng.Click += new System.EventHandler(this.selectRussian);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 404);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEnglishLng);
            this.Controls.Add(this.btnRussianLng);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRussianLng;
        private System.Windows.Forms.Button btnEnglishLng;
        private System.Windows.Forms.Button button3;

    }
}

