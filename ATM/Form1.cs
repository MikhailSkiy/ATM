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

        string _xmlPath = @"d:\\languages.xml";
        InsertingPinWindow insertPinWindow = new InsertingPinWindow();

        LanguageSettings RusLanguageSettings = new LanguageSettings("RUS", "Пожалуйста, введите пин", "Отмена", "Изменить", "Подтвердить", "Снять наличные","Проверить баланс", "Перевод", "Платежи","Депозит","Другие операции", "С чеком", "Без чека","Другую сумму","Введен неправильный пин-код, пожалуйста попробуйте еще раз","Недостаточно стредств");
        LanguageSettings EngLanguageSettings = new LanguageSettings("ENG", "Insert pin-code, please", "Cancel", "Correct", "Confirm", "Withdrawal", "Check balance", "Transfer", "Payments", "Deposit", "Other Services", "With receipt", "Without receipt", "Another amount", "Incorrect pin,please try again", "Insufficient funds");
       

        private void selectRussian(object sender, EventArgs e)
        {
            // create xml-file
            //XmlHelper.CreateLanguageSettings(RusLanguageSettings, _xmlPath);

            this.Hide();
 

            // User chose Russian language
            if (sender.Equals(btnRussianLng))
            {
                // Switch the language
             
                insertPinWindow.SetLanguage(RusLanguageSettings);
                insertPinWindow.ShowDialog();
            }
            this.Show();
        }

        // user chose English language
        private void btnEnglishLng_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (sender.Equals(btnEnglishLng))
            {
                // Switch the language
                insertPinWindow.SetLanguage(EngLanguageSettings);
                insertPinWindow.ShowDialog();
            }
            this.Show();
        }
    }
}
