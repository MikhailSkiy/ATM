using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    /// <summary>
    /// Language settings for different controls
    /// </summary>
    public class LanguageSettings
    {
        private string _language;

        // Labels 
        private string _lbPleaseInsertPin; // Insert pin label

        // Buttons
        // Insert Pin window
        private string _btnCancel;         // Cancel button
        private string _btnCorrect;        // Correct button
        private string _btnConfirm;        // Confirm button

        // Window for general menu
        private string _btnWithdrawal;    // Take money button
        private string _btnCheckBalance;  // Check Balance button
        private string _btnTransfer;      // Transfer money button

        private string _btnPaymetns;      // Operations with payments
        private string _btnDeposit;
        private string _btnOtherServices;

        // WithReceiptWindow
        private string _btnWithReceipt;     // With receipt
        private string _btnWithoutReceipt;  // Without Receipt

        #region Constructors
        public LanguageSettings() { }
        /// <summary>
        /// Create LanguageSettings class
        /// </summary>
        /// <param name="language"></param>
        /// <param name="lblPleaseInsertPin"></param>
        /// <param name="btnCancel"></param>
        /// <param name="btnCorrect"></param>
        /// <param name="btnConfirm"></param>
       public LanguageSettings(string language, 
                        string lblPleaseInsertPin,
                        string btnCancel,
                        string btnCorrect,
                        string btnConfirm,
                        string btnWithdrawal,
                        string btnCheckBalance,
                        string btnTransfer,
                        string btnPayments,
                        string btnDeposit,
                        string btnOtherServices,
                        string btnWithReceipt,
                        string btnWithoutReceipt) 
        {
            Language = language;
            LblPleaseInsertPin = lblPleaseInsertPin;
            BtnCancel = btnCancel;
            BtnCorrect = btnCorrect;
            BtnConfirm = btnConfirm;
            BtnWithdrawal = btnWithdrawal;
            BtnCheckBalance = btnCheckBalance;
            BtnTransfer = btnTransfer;
            BtnPayments = btnPayments;
            BtnDeposit = btnDeposit;
            BtnOtherServices = btnOtherServices;
            BtnWithReceipt = btnWithReceipt;
            BtnWithoutReceipt = btnWithoutReceipt;
           
        }

        #endregion

        #region Properties
        public string Language
        {
            get { return _language; }
            set {_language = value; }
        }

        // Labels 
        public string LblPleaseInsertPin
        {
            get { return _lbPleaseInsertPin;}
            set {_lbPleaseInsertPin = value;}
        }

        // Buttons
        public string BtnCancel
        {
            get { return _btnCancel; }
            set { _btnCancel = value; }
        }

        public string BtnCorrect
        {
            get { return _btnCorrect; }
            set { _btnCorrect = value; }
        }

        public string BtnConfirm 
        {
            get { return _btnConfirm; }
            set { _btnConfirm = value; }
        }

        public string BtnWithdrawal
        {
            get { return _btnWithdrawal; }
            set { _btnWithdrawal = value; }
        }

        public string BtnCheckBalance
        {
            get { return _btnCheckBalance; }
            set { _btnCheckBalance = value; }
        }

        public string BtnTransfer 
        {
            get { return _btnTransfer; }
            set { _btnTransfer = value; }
        }

        public string BtnPayments { get; set; }
        public string BtnDeposit { get; set; }
        public string BtnOtherServices { get; set; }

        public string BtnWithReceipt { get; set; }
        public string BtnWithoutReceipt { get; set; }
        #endregion

    }
}
