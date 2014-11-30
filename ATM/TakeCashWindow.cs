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
        public TakeCashWindow()
        {
            InitializeComponent();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            this.Close();

            Transaction transaction = new Transaction();
            transaction.Date = DateTime.Today.ToString();
            transaction.CountOfMoney = -100;
            XmlHelper.InsertTransaction(transaction, _xmlPath);

            withReceiptWindow.ShowDialog();
            this.Show();
        }



    }
}
