using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Linq;

namespace ATM
{
    /// <summary>
    /// All operations with XML here
    /// </summary>
     static class XmlHelper
    {
        /// <summary>
        /// Create XML-file for language settings
        /// </summary>
        /// <param name="languageSettings"></param>
        /// <param name="PathToXmlFile"></param>
       public static void CreateLanguageSettings (LanguageSettings languageSettings, string PathToXmlFile)
        {
            // Check the input arguments
            Debug.Assert(languageSettings != null);
            Debug.Assert(PathToXmlFile != null);

            XDocument loadedXDocument = new XDocument();

            // Create language settings which will be used in controls
            XElement xmlTree =
            new XElement("LanguageSettings",
            new XElement("Type", languageSettings.Language),
            new XElement("BtnCancel", languageSettings.BtnCancel ),
            new XElement("BtnCorrect", languageSettings.BtnCorrect),
            new XElement("BtnConfirm", languageSettings.BtnConfirm)
            );

            //  If file doesn't exist, initialize root elemnt and after insert data
            if (!System.IO.File.Exists(PathToXmlFile))
            {
                XElement xmlRoot = new XElement("Catalog", new XElement("Languages", xmlTree));
                loadedXDocument.Add(xmlRoot);
                loadedXDocument.Save(PathToXmlFile);
            }
            else
            {
                loadedXDocument.Descendants("LanguageSettings").Last().AddAfterSelf(xmlTree);
                loadedXDocument.Save(PathToXmlFile);
            }


        }

       public static void InsertTransaction(Transaction trasnsactionDetails,string PathToXmlFile)
       {
           Debug.Assert(trasnsactionDetails != null);
           Debug.Assert(PathToXmlFile != null);

           XDocument loadedXDocument = new XDocument();

           // Create language settings which will be used in controls
           XElement xmlTree =
           new XElement("Transaction",
           new XElement("Date", trasnsactionDetails.Date),
           new XElement("CountOfMoney", trasnsactionDetails.CountOfMoney)
           );

           //  If file doesn't exist, initialize root elemnt and after insert data
           if (!System.IO.File.Exists(PathToXmlFile))
           {
               XElement xmlRoot = new XElement("Catalog", new XElement("Transactions", xmlTree));
               loadedXDocument.Add(xmlRoot);
               loadedXDocument.Save(PathToXmlFile);
           }
           else
           {
               loadedXDocument.Descendants("Transaction").Last().AddAfterSelf(xmlTree);
               loadedXDocument.Save(PathToXmlFile);
           }
 
       }
    }

}
