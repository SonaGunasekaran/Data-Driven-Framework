/*
 * Project:Data Driven Framework
 * Author:Sona G
 * Date :12/09/2021
 */
using FBDatadriven.LoginPage;
using NUnit.Framework;
using System.Collections.Generic;

namespace FBDatadriven
{
    public class Tests : Base.Baseclass
    {
        Dictionary<string, UserData> userRecord= new Dictionary<string, UserData>();
        string csvFilePath = @"C:\Users\sona.g\source\repos\FBDatadriven\FBDatadriven\CsvFile\FBfile.csv";
        LoginPage.FbLoginPage login=new LoginPage.FbLoginPage();

        [Test]
        public void Test1()
        {
            userRecord =login.LoadUserData(csvFilePath,"Email,Password");
            //int actual = userRecord.Count;
            //int expected = 3;
            //assertion
            //Assert.AreEqual(actual, expected);
        }
    }
}