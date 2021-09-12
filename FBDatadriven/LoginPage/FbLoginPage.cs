/*
 * Project:Data Driven Framework
 * Author:Sona G
 * Date :12/09/2021
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FBDatadriven.LoginPage
{
    public class FbLoginPage : UserAdapter
    {
        string[] userData;
        Dictionary<string, UserData> dataMap;
        public Dictionary<string, UserData> LoadCensusData(string csvFilePath, string dataHeader)
        {
            dataMap = new Dictionary<string, UserData>();
            userData = GetUserData(csvFilePath, dataHeader);
            foreach (string data in userData.Skip(1))
            {
                if (!data.Contains(","))
                    throw new UserDataException("File contains invalid Delimiter", UserDataException.ExceptionType.INCORRECT_DELIMITER);
                string[] column = data.Split(",");
                if (csvFilePath.Contains("FBfile.csv"))
                    dataMap.Add(column[0],(new UserData(column[0], column[1], column[2])));
            }
            return dataMap;
        }
    }

}
