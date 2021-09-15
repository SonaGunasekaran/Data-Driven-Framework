/*
 * Project:Data Driven Framework
 * Author:Sona G
 * Date :12/09/2021
 */
using NUnit.Framework;

namespace FBDatadriven
{
    public class Tests : Base.Baseclass
    {
        string csvFilePath = @"C:\Users\sona.g\source\repos\FBDatadriven\FBDatadriven\CsvFile\FBfile.csv";
        DoAction.DoActions action =new DoAction.DoActions();
        
        [Test]
        public void Test1()
        {
            action.LoadUserData(csvFilePath,"Email,Password");
        }
    }
}
