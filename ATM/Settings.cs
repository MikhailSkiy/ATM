using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    /// <summary>
    /// Keep all user settings like Pin, amount of money etc
    /// </summary>
  public  class XMLSettings
  {
      #region Private variables

      string _PIN;
      string _Total;

      #endregion

      #region Public Properties;

      public string PIN
      {
          get { return _PIN; }
          set { _PIN = value; }
      }

      public string Total
      {
          get { return _Total; }
          set { _Total = value; }
      }

      #endregion
  }
}
