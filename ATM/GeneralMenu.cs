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
    public partial class GeneralMenu : Form
    {
        // Initialize all windows, which user can choose

        TakeCashWindow takeCashWindow = new TakeCashWindow();

        /// <summary>
        /// Class for general options (Check Balance, Transfer money etc)
        /// </summary>
        public GeneralMenu()
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

        private void ChangeLabels(GeneralMenu generalMenu, LanguageSettings languageSettings)
        {
            this.btnWithdrawal.Text = languageSettings.BtnWithdrawal;
            this.btnCheckBalance.Text = languageSettings.BtnCheckBalance;
            this.btnTransfer.Text = languageSettings.BtnTransfer;
            this.btnPayments.Text = languageSettings.BtnPayments;
            this.btnDeposit.Text = languageSettings.BtnDeposit;
            this.btnOtherServices.Text = languageSettings.BtnOtherServices;

        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            this.Hide();
            takeCashWindow.ShowDialog();
            this.Show();
        }

    }
}
