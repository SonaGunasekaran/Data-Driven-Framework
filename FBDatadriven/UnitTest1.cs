/*
 * Project:Data Driven Framework
 * Author:Sona G
 * Date :12/09/2021
 */
using NUnit.Framework;

namespace FBDatadriven
{
    public class Tests
    {
        string csvFilePath = @"C:\Users\sona.g\source\repos\FBDatadriven\FBDatadriven\FBfile.csv";
        LoginPage.UserAdapter adapter;
        [SetUp]
        public void Setup()
        {
            adapter = new LoginPage.UserAdapter();
        }

        [Test]
        public void Test1()
        {
            adapter.GetUserData(csvFilePath,"UserId,Email,Password");
        }
    }
}