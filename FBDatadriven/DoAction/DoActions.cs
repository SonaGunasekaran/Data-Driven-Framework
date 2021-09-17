/*
 * Project:Data Driven Framework
 * Author:Sona G
 * Date :12/09/2021
 */
using FBDatadriven.LoginPage;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Linq;


namespace FBDatadriven.DoAction
{
    public class DoActions : Base.Baseclass
    {
        
        public void LoadUserData(string csvFilePath, string dataHeader)
        {
            using (TextFieldParser csvParser = new TextFieldParser(csvFilePath))
            {
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                 
                    FbLoginPage login = new FbLoginPage(driver);
                    //Check email by name
                    login.email.SendKeys(fields[0]);
                    System.Threading.Thread.Sleep(1000);

                    //check password by id
                    login.password.SendKeys(fields[1]);
                    System.Threading.Thread.Sleep(1000);

                    //check login by loginbutton
                    login.loginbtn.Click();
                }
            }
        }
    }
}

