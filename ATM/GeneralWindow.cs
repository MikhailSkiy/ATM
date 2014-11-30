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
    /// <summary>
    /// General class for all windows
    /// </summary>
    abstract public partial class  GeneralWindow : Form
    {
        private Label lbPleaseInsertCard;

  
        public GeneralWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Set the language for all controls
        /// </summary>
        /// <param name="language">
        /// the member of enum ConstantsForLocalization
        /// </param>
        abstract public void SetLanguage(LanguageSettings languageSetings);


    }
}
