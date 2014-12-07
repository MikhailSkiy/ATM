using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static Language langugaeMode;
        public enum Language
        {
            RUS,
            ENG
        }

public static class Trans
{
    public static string Value { get; set; }
    public static string Date { get; set; }
}

public static class Settings
{
    public static string PIN { get; set; }
    public static string Total { get; set; }
}

    }
}
