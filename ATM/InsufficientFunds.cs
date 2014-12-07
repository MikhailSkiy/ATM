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
    public partial class InsufficientFunds : Form
    {
        public InsufficientFunds()
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

        private void ChangeLabels(InsufficientFunds funds, LanguageSettings languageSettings)
        {
            this.lbInsufficientFunds.Text = languageSettings.LbInsufficientFunds;
        }
    }
}
