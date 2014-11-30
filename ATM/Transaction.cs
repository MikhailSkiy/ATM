using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    /// <summary>
    /// Transaction
    /// </summary>
   public class Transaction
    {
        #region Private variables

        string _date;               // The date of transaction
        int _countOfMoney;          // Amount of money whcih was taken

        #endregion

        #region Properties
        public string Date { get; set; }
        public int CountOfMoney 
        {
            get { return _countOfMoney; }  // add the checking of count (must be less 1000 euro)
            set { _countOfMoney = value; }
        }
        #endregion
    }
}
