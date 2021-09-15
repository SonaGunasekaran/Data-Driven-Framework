/*
 * Project:Data Driven Framework
 * Author:Sona G
 * Date :12/09/2021
 */
using FBDatadriven.LoginPage;
using System.IO;
using System.Linq;


namespace FBDatadriven.DoAction
{
    public class DoActions : Base.Baseclass
    {
        string[] userData;
        public void LoadUserData(string csvFilePath, string dataHeader)
        {
            //Read all lines from csv file
            userData = File.ReadAllLines(csvFilePath);

            //Skip the header
            //string[] column = new string[1];
            foreach (var data in userData.Skip(1))
            {
                //Split the column by comma
                string[] column = data.Split(",");
                if (csvFilePath.Contains("FBfile.csv"))
                {
                    FbLoginPage login = new FbLoginPage(driver);
                    //Check email by name 
                    login.email.SendKeys(column[0]);
                    System.Threading.Thread.Sleep(1000);
                    //check password by id
                    login.password.SendKeys(column[1]);
                    System.Threading.Thread.Sleep(1000);
                    //check login by loginbutton
                    login.loginbtn.Click();
                    System.Threading.Thread.Sleep(1000);

                }
            }

        }

    }
}


