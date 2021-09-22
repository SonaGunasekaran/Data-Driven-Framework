/*
 * Project:Data Driven Framework
 * Author:Sona G
 * Date :12/09/2021
 */
using AventStack.ExtentReports;
using FBDatadriven.ExtendReport;
using NUnit.Framework;

namespace FBDatadriven
{
    public class Tests : Base.Baseclass
    {
        ExtentReports reports = ExtendReportclass.report();
        ExtentTest test;
        string csvFilePath = @"C:\Users\sona.g\source\repos\FBDatadriven\FBDatadriven\CsvFile\FBfile.csv";
        string emailCsvPath = @"C:\Users\sona.g\source\repos\FBDatadriven\FBDatadriven\CsvFile\Emailfile.csv";
        [Test]
        public void Test1()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automation FaceBook");
            DoAction.DoActions.LoadUserData(csvFilePath, "Email,Password");

            test.Log(Status.Pass, "Test Passes");
            reports.Flush();

        }
        [Test]
        public void TestMethodForEmailSending()
        {
            Email.EmailContainer.UserData(emailCsvPath, "From,To,Password");
        }
    }
}
