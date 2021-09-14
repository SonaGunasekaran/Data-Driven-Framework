/*
 * Project:Data Driven Framework
 * Author:Sona G
 * Date :12/09/2021
 */
using OpenQA.Selenium;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace FBDatadriven.LoginPage
{
    public class FbLoginPage : Base.Baseclass
    {
        string[] userData;
        Dictionary<string, UserData> user;
        public Dictionary<string, UserData> LoadUserData(string csvFilePath, string dataHeader)
        {
            //Read all lines from csv file
            userData = File.ReadAllLines(csvFilePath);

            user = new Dictionary<string, UserData>();
            //Skip the header
            foreach (string data in userData.Skip(1))
            {
                //Split the column by comma
                string[] column = data.Split(",");
                if (csvFilePath.Contains("FBfile.csv"))
                {
                    //Add the column to the dictionary
                    user.Add(column[0], new UserData(column[0], column[1]));

                    //Find the element by name and pass the value
                    driver.FindElement(By.Name("email")).SendKeys(column[0]);
                    System.Threading.Thread.Sleep(1000);

                    //Find the element by Id and pass the value
                    driver.FindElement(By.Id("pass")).SendKeys(column[1]);
                    System.Threading.Thread.Sleep(1000);

                    driver.FindElement(By.Name("login")).Click();
                    System.Threading.Thread.Sleep(1000);
                }
            }
            return user;
        }
    }

}

