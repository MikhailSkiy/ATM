using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class WithReceiptWindow : Form
    {
        public WithReceiptWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set the language for all controls
        /// </summary>
        /// <param name="language">
        /// the member of enum ConstantsForLocalization
        /// </param>
        public void SetLanguage(LanguageSettings languageSettings)
        {

            switch (languageSettings.Language)
            {
                case "RUS":
                    ChangeLabels(this, languageSettings);
                    break;
                case "ENG":
                    ChangeLabels(this, languageSettings);
                    break;
                default:
                    break;
            }
        }

        private void ChangeLabels(WithReceiptWindow withReceiptWindow, LanguageSettings languageSettings)
        {
            this.btnWithReceipt.Text = languageSettings.BtnWithReceipt;
            this.btnWithoutReceipt.Text = languageSettings.BtnWithoutReceipt;

        }

        private void btnWithReceipt_Click(object sender, EventArgs e)
        {

        }

        private void btnWithoutReceipt_Click(object sender, EventArgs e)
        {
        }
    }
}
