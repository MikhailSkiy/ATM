﻿namespace ATM
{
    partial class ShowTotal
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
            this.tbShowTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbShowTotal
            // 
            this.tbShowTotal.Location = new System.Drawing.Point(34, 49);
            this.tbShowTotal.Name = "tbShowTotal";
            this.tbShowTotal.ReadOnly = true;
            this.tbShowTotal.Size = new System.Drawing.Size(215, 20);
            this.tbShowTotal.TabIndex = 0;
            // 
            // ShowTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tbShowTotal);
            this.Name = "ShowTotal";
            this.Text = "ShowTotal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbShowTotal;
    }
}