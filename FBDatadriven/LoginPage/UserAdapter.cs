/*
 * Project:Data Driven Framework
 * Author:Sona G
 * Date :12/09/2021
 */
using System.IO;

namespace FBDatadriven.LoginPage
{
    public class UserAdapter
    {
        public string[] GetUserData(string csvFilePath, string dataHeader)
        {
            string[] userData;
            if (!File.Exists(csvFilePath))
            {
                throw new UserDataException("File Not Found",UserDataException.ExceptionType.FILE_NOT_FOUND);
            }
            userData = File.ReadAllLines(csvFilePath);
            return userData;
        }
    }
}

