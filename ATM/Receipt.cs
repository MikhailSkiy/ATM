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
    public partial class Receipt : Form
    {
        public Receipt(List<string> info)
        {
 
            InitializeComponent();
            this.tbInfo.Text = CreateInfoText(info);
        }

        // Crate text for receipt
        public string CreateInfoText(List<string> info)
        {
            string text= "";
            for (int i = 0; i < info.Count; i++)
            {
                text +=  info[i] + "\r\n";
            }
            return text;
        }


    }
}
