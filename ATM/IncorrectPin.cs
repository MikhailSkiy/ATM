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
    public partial class IncorrectPin : Form
    {
        public IncorrectPin()
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
                    // Switch language in the current window
                    ChangeLabels(this, languageSettings);

                    break;
                case "ENG":
                    // Switch language in the current window
                    ChangeLabels(this, languageSettings);

                    break;
                default:
                    break;
            }
        }

        private void ChangeLabels(IncorrectPin incorrectPin, LanguageSettings languageSettings)
        {
            this.lbIncorrectPin.Text = languageSettings.LbIncorrectPin;
        }
    }
}
