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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        InsertPinWindow insertPinWindow = new InsertPinWindow();
        private void selectRussian(object sender, EventArgs e)
        {
            this.Hide();
            if (sender.Equals(btnRussianLng))
            {
                // Switch the language
                insertPinWindow.setLanguage(0);
                insertPinWindow.ShowDialog();
            }
            this.Show();
        }

        private void btnEnglishLng_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (sender.Equals(btnEnglishLng))
            {
                // Switch the language
                insertPinWindow.setLanguage(1);
                insertPinWindow.ShowDialog();
            }
            this.Show();
        }
    }
}
