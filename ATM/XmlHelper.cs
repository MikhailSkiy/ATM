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
        public static void CreateLanguageSettings(LanguageSettings languageSettings, string PathToXmlFile)
        {
            // Check the input arguments
            Debug.Assert(languageSettings != null);
            Debug.Assert(PathToXmlFile != null);

            XDocument loadedXDocument = new XDocument();

            // Create language settings which will be used in controls
            XElement xmlTree =
            new XElement("LanguageSettings",
            new XElement("Type", languageSettings.Language),
            new XElement("BtnCancel", languageSettings.BtnCancel),
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

        public static void SetUpSettings(XMLSettings settings, string PathToSettings)
        {
            Debug.Assert(settings != null);
            Debug.Assert(PathToSettings != null);
            XDocument loadedXDocument = XDocument.Load(PathToSettings);

            // Create settings 
            XElement xmlTree =
                new XElement("Settings",
                new XElement("PIN", settings.PIN),
                new XElement("Total", settings.Total)
                );

            if (!System.IO.File.Exists(PathToSettings))
            {
                XElement xmlRoot = new XElement("User Settings", xmlTree);
                loadedXDocument.Add(xmlRoot);
                loadedXDocument.Save(PathToSettings);
            }
        }

        /// <summary>
        /// Write all information about transaction
        /// </summary>
        /// <param name="trasnsactionDetails"></param>
        /// <param name="PathToXmlFile"></param>
        public static void InsertTransaction(Transaction trasnsactionDetails, string PathToXmlFile)
        {
            Debug.Assert(trasnsactionDetails != null);
            Debug.Assert(PathToXmlFile != null);

            XDocument loadedXDocument = XDocument.Load(PathToXmlFile);

            // Create language settings which will be used in controls
            XElement xmlTree =
            new XElement("Transaction",
            new XElement("Date", trasnsactionDetails.Date),
            new XElement("CountOfMoney", trasnsactionDetails.CountOfMoney),
            new XElement("Total",trasnsactionDetails.Total)
            );


            //  If file doesn't exist, initialize root elemnt and after insert data
            if (!System.IO.File.Exists(PathToXmlFile))
            {
                XElement xmlRoot = new XElement("Catalog",
                                                 new XElement("Transactions", xmlTree));
                loadedXDocument.Add(xmlRoot);
                loadedXDocument.Save(PathToXmlFile);
            }
            else
            {
                loadedXDocument.Descendants("Transaction").Last().AddAfterSelf(xmlTree);
                loadedXDocument.Save(PathToXmlFile);
            }

        }

        /// <summary>
        /// Select all transaction from XML 
        /// </summary>
        /// <returns>List of all transactions </returns>
        public static List<Transaction> CreateListOfTransaction(string PathToXmlFile)
        {
            // Проверка входящих значений
            Debug.Assert(PathToXmlFile != null);

            List<Transaction> selectedAddresses = new List<Transaction>();
            // Выборка из XML - файла            
            // Читаем данные из файла
            if (System.IO.File.Exists(PathToXmlFile))
            {
                XDocument openedXDocument = XDocument.Load(PathToXmlFile);
                // Проходим по каждому элементу
                foreach (XElement element in openedXDocument.Descendants("Transaction"))
                {
                    // Каждый XElemnt Address в XML файле преобразуем в объект
                    Transaction loadedAddress = new Transaction();
                    loadedAddress = ConvertXmlElementTransactionToObjectTransaction(element);
                    // Добавляем в список адресов
                    selectedAddresses.Add(loadedAddress);
                }
            }
            return selectedAddresses;
        }

        /// <summary>
        /// Convert XML into Object
        /// </summary>
        /// <param name="xElement">XML</param>
        /// <returns>Object transaction with attributes</returns>
        public static Transaction ConvertXmlElementTransactionToObjectTransaction(XElement xElement)
        {
            Debug.Assert(xElement != null);

            Transaction newTransaction = new Transaction();
 
            newTransaction.CountOfMoney = Int32.Parse(xElement.Element("CountOfMoney").Value);
            newTransaction.Date = xElement.Element("Date").Value;
            newTransaction.Total = Int32.Parse(xElement.Element("Total").Value);

            
            return newTransaction;
        }

        /// <summary>
        /// Return info about last transaction
        /// </summary>
        /// <param name="transaction"></param>
        /// <param name="PathToXmlFile"></param>
        /// <returns></returns>
        public static Transaction GetLastTransaction(string PathToXmlFile)
        {
            // Check input           
            Debug.Assert(PathToXmlFile != null);
  

            XDocument xDocument = XDocument.Load(PathToXmlFile);

            XElement selectedElementForEdit = xDocument.Root.Element("Transactions");
            var lastTransactionNode = selectedElementForEdit.LastNode;
            XElement xElement = (XElement)lastTransactionNode;

            Transaction lastTransaction = ConvertXmlElementTransactionToObjectTransaction(xElement);

            return lastTransaction;
        }



    }
}
