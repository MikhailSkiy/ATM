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

        // Fields for transaction
       public int amount;
       public string date;
       public int total;


       public string languageMode;



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
                    languageMode = "RUS";
                    break;
                case "ENG":
                    ChangeLabels(this, languageSettings);
                    languageMode = "ENG";
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

        public void PutInfoAboutTransaction(Transaction transaction)
         {
             this.amount = transaction.CountOfMoney;
             this.date = transaction.Date;
             this.total = transaction.Total;
         }

        
        private void btnWithReceipt_Click(object sender, EventArgs e)
        {
            this.Close();
            List<string> infoForReceipt = new List<string>();
            CreateList(ref infoForReceipt, languageMode);
 

            // Window for receipt (info about transaction)
            Receipt receipt = new Receipt(infoForReceipt);

            
            receipt.ShowDialog();

        }
        private void CreateList(ref List<string> infoForReceipt, string languageMode)
        {
            switch (languageMode)
            {
                case "RUS": 
                    infoForReceipt.Add(LanguageSettingsForReceipt.RUS_AMOUNT +":" + amount.ToString());
                    infoForReceipt.Add(LanguageSettingsForReceipt.RUS_DATE + ":" + date);
                    infoForReceipt.Add(LanguageSettingsForReceipt.RUS_TOTAL + ":" +total.ToString());
                    break;
                case "ENG":
                    infoForReceipt.Add(LanguageSettingsForReceipt.ENG_AMOUNT + ":" + amount.ToString());
                    infoForReceipt.Add(LanguageSettingsForReceipt.ENG_DATE + ":" + date);
                    infoForReceipt.Add(LanguageSettingsForReceipt.ENG_TOTAL + ":" + total.ToString());
                    break;
                default:
                    break;

            }
 
        }

        private void btnWithoutReceipt_Click(object sender, EventArgs e)
        {
            this.Close();
            WithoutReceipt withoutReceipt = new WithoutReceipt();
            withoutReceipt.ShowDialog();
        }
    }
}
