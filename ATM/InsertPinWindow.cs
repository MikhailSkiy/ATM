using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATM
{
    /// <summary>
    /// Class for Inserting Pin window
    /// </summary>
    class InsertingPinWindow : Form
    {
        private TextBox tbInsertPin;
        private Button btnConfirm;
        private Button btnCorrect;
        private Button btnCancel;
        private Label lbPleaseInsertPin;

        GeneralMenu generalMenu = new GeneralMenu();
        TakeCashWindow takeCashWindow = new TakeCashWindow();
        IncorrectPin incorrectPin = new IncorrectPin();
    
        public InsertingPinWindow() 
        {
            InitializeComponent();            
        }

        /// <summary>
        /// Set the language for all controls. YOU SHOULD WRITE ALL WINDOWS WHERE IT IS IMPORTANT TO SWITCH LANGUAGE
        /// </summary>
        /// <param name="language">
        /// the member of enum ConstantsForLocalization
        /// </param>
        public  void SetLanguage(LanguageSettings languageSettings)
        {

            switch (languageSettings.Language)
            {
                case "RUS":
                    // Switch language for InsertPinWindow
                    ChangeLabels(this, languageSettings);
                    // Switch language for GeneralMenu
                    generalMenu.SetLanguage (languageSettings);
                    // Switch language for TakeCashWindow
                    takeCashWindow.SetLanguage(languageSettings);
                    // Switch language for incorrectPin window
                    incorrectPin.SetLanguage(languageSettings);

                    break;
                case "ENG":
                    // Switch language for InsertPinWindow
                    ChangeLabels(this, languageSettings);
                    // Switch language for GeneralMenu
                    generalMenu.SetLanguage(languageSettings);
                    // Switch language for TakeCashWindow
                    takeCashWindow.SetLanguage(languageSettings);
                    // Switch language for incorrectPin window
                    incorrectPin.SetLanguage(languageSettings);
                    break;
                default:
                    break;
            }
        }

        private void ChangeLabels(InsertingPinWindow insertPinWindow, LanguageSettings languageSettings)
        {
            insertPinWindow.lbPleaseInsertPin.Text = languageSettings.LblPleaseInsertPin;
            insertPinWindow.btnCancel.Text = languageSettings.BtnCancel;
            insertPinWindow.btnCorrect.Text = languageSettings.BtnCorrect;
            insertPinWindow.btnConfirm.Text = languageSettings.BtnConfirm;
        }
        private void InitializeComponent()
        {
            this.lbPleaseInsertPin = new System.Windows.Forms.Label();
            this.tbInsertPin = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPleaseInsertPin
            // 
            this.lbPleaseInsertPin.AutoSize = true;
            this.lbPleaseInsertPin.Location = new System.Drawing.Point(305, 126);
            this.lbPleaseInsertPin.Name = "lbPleaseInsertPin";
            this.lbPleaseInsertPin.Size = new System.Drawing.Size(35, 13);
            this.lbPleaseInsertPin.TabIndex = 0;
            this.lbPleaseInsertPin.Text = "label1";
            // 
            // tbInsertPin
            // 
            this.tbInsertPin.Location = new System.Drawing.Point(224, 142);
            this.tbInsertPin.MaxLength = 4;
            this.tbInsertPin.Name = "tbInsertPin";
            this.tbInsertPin.Size = new System.Drawing.Size(223, 20);
            this.tbInsertPin.TabIndex = 1;
            this.tbInsertPin.UseSystemPasswordChar = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(603, 289);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCorrect
            // 
            this.btnCorrect.Location = new System.Drawing.Point(308, 289);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(75, 23);
            this.btnCorrect.TabIndex = 3;
            this.btnCorrect.Text = "Correct";
            this.btnCorrect.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(33, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // InsertingPinWindow
            // 
            this.ClientSize = new System.Drawing.Size(708, 339);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbInsertPin);
            this.Controls.Add(this.lbPleaseInsertPin);
            this.Name = "InsertingPinWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (this.tbInsertPin.Text == "1234")
            {
                generalMenu.ShowDialog();
            }
            else incorrectPin.ShowDialog();

            this.Show();
        }
    }
}
