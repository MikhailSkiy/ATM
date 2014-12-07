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
    public partial class TakeCashWindow : Form
    {
        string _xmlPath = @"d:\\transactions.xml";

        WithReceiptWindow withReceiptWindow = new WithReceiptWindow();
        InsufficientFunds insufficientFunds= new InsufficientFunds();
        public TakeCashWindow()
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
                    // Switch language in the another window
                    withReceiptWindow.SetLanguage(languageSettings);
                    // Swithc language in the Insufficient Funds window
                    insufficientFunds.SetLanguage(languageSettings);
                    break;
                case "ENG":
                    // Switch language in the current window
                    ChangeLabels(this, languageSettings);
                    // Switch language in the another window
                    withReceiptWindow.SetLanguage(languageSettings);
                    // Swithc language in the Insufficient Funds window
                    insufficientFunds.SetLanguage(languageSettings);
                    break;
                default:
                    break;
            }
        }

        private void ChangeLabels(TakeCashWindow takeCashWindow, LanguageSettings languageSettings)
        {
            this.btnAnotherAmount.Text = languageSettings.BtnTakeAnotherAmount;
        }

        // Take 100 euro
        private void btn100_Click(object sender, EventArgs e)
        {
            this.Hide();

            Transaction currentTransaction = new Transaction();
            currentTransaction.Date = DateTime.Now.ToString();
            currentTransaction.CountOfMoney = -100;

            Transaction lastTransaction = XmlHelper.GetLastTransaction( _xmlPath);

            // Compute the amount of money for this transaction
            // total = lastTransaction.Total + (-currentTransaction);
            if (CheckBalance(lastTransaction.Total, currentTransaction.CountOfMoney))
            {
                currentTransaction.Total = lastTransaction.Total + currentTransaction.CountOfMoney;
                // Insert Info about transaction
                XmlHelper.InsertTransaction(currentTransaction, _xmlPath);

                // Put Info about transaction to the next window for printing receipt
                withReceiptWindow.PutInfoAboutTransaction(currentTransaction);

                withReceiptWindow.ShowDialog();
            }
            else
            // Insufficient funds
            {
                insufficientFunds.ShowDialog();
            }
            this.Show();
        }

        // Take 200
        private void btn200_Click(object sender, EventArgs e)
        {
            this.Hide();

            Transaction currentTransaction = new Transaction();
            currentTransaction.Date = DateTime.Now.ToString();
            currentTransaction.CountOfMoney = -200;

            Transaction lastTransaction = XmlHelper.GetLastTransaction(_xmlPath);

            // Compute the amount of money for this transaction
            // total = lastTransaction.Total + (-currentTransaction);
            if (CheckBalance(lastTransaction.Total, currentTransaction.CountOfMoney))
            {
                currentTransaction.Total = lastTransaction.Total + currentTransaction.CountOfMoney;
                // Insert Info about transaction
                XmlHelper.InsertTransaction(currentTransaction, _xmlPath);

                // Put Info about transaction to the next window for printing receipt
                withReceiptWindow.PutInfoAboutTransaction(currentTransaction);

                withReceiptWindow.ShowDialog();
            }
            else
            // Insufficient funds
            {
                insufficientFunds.ShowDialog();
            }
            this.Show();

        }
        
        // Take 300
        private void btn300_Click(object sender, EventArgs e)
        {
            this.Hide();

            Transaction currentTransaction = new Transaction();
            currentTransaction.Date = DateTime.Now.ToString();
            currentTransaction.CountOfMoney = -300;

            Transaction lastTransaction = XmlHelper.GetLastTransaction(_xmlPath);

            // Compute the amount of money for this transaction
            // total = lastTransaction.Total + (-currentTransaction);
            if (CheckBalance(lastTransaction.Total, currentTransaction.CountOfMoney))
            {
                currentTransaction.Total = lastTransaction.Total + currentTransaction.CountOfMoney;
                // Insert Info about transaction
                XmlHelper.InsertTransaction(currentTransaction, _xmlPath);

                // Put Info about transaction to the next window for printing receipt
                withReceiptWindow.PutInfoAboutTransaction(currentTransaction);

                withReceiptWindow.ShowDialog();
            }
            else
            // Insufficient funds
            {
                insufficientFunds.ShowDialog();
            }

            this.Show();

        }

        // Take 500
        private void btn500_Click(object sender, EventArgs e)
        {
            this.Hide();

            Transaction currentTransaction = new Transaction();
            currentTransaction.Date = DateTime.Now.ToString();
            currentTransaction.CountOfMoney = -500;

            Transaction lastTransaction = XmlHelper.GetLastTransaction( _xmlPath);

            // Compute the amount of money for this transaction
            // total = lastTransaction.Total + (-currentTransaction);
            if (CheckBalance(lastTransaction.Total, currentTransaction.CountOfMoney))
            {
                currentTransaction.Total = lastTransaction.Total + currentTransaction.CountOfMoney;
                // Insert Info about transaction
                XmlHelper.InsertTransaction(currentTransaction, _xmlPath);

                // Put Info about transaction to the next window for printing receipt
                withReceiptWindow.PutInfoAboutTransaction(currentTransaction);

                withReceiptWindow.ShowDialog();
            }
            else
            // Insufficient funds
            {
                insufficientFunds.ShowDialog();
            }

            this.Show();

        }

        // Take 1000
        private void btn1000_Click(object sender, EventArgs e)
        {
            this.Hide();

            Transaction currentTransaction = new Transaction();
            currentTransaction.Date = DateTime.Now.ToString();
            currentTransaction.CountOfMoney = -1000;

            Transaction lastTransaction = XmlHelper.GetLastTransaction(_xmlPath);

            // Compute the amount of money for this transaction
            // total = lastTransaction.Total + (-currentTransaction);
            if (CheckBalance(lastTransaction.Total, currentTransaction.CountOfMoney))
            {
                currentTransaction.Total = lastTransaction.Total + currentTransaction.CountOfMoney;
                // Insert Info about transaction
                XmlHelper.InsertTransaction(currentTransaction, _xmlPath);

                // Put Info about transaction to the next window for printing receipt
                withReceiptWindow.PutInfoAboutTransaction(currentTransaction);

                withReceiptWindow.ShowDialog();
            }
            else
            // Insufficient funds
            {
                insufficientFunds.ShowDialog();
            }
            this.Show();

        }


        // Take another amount, the user should to write amount 
        private void btnAnotherAmount_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Check Balance before other operations
        /// </summary>
        /// <param name="total"> Total amount of money</param>
        /// <param name="currentAmount"> Amount of money which user want to take</param>
        /// <returns></returns>
        public bool CheckBalance(int total, int currentAmount)
        {
            int current = -(currentAmount);
            if (total > current)
            {
                return true;
            }
            else return false;
        }



    }
}
