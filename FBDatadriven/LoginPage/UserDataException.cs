/*
 * Project:Data Driven Framework
 * Author:Sona G
 * Date :12/09/2021
 */
using System;

namespace FBDatadriven.LoginPage
{
    public class UserDataException : Exception
    {
        public ExceptionType exception;
        public enum ExceptionType
        {
            FILE_NOT_FOUND, INCORRECT_DELIMITER
        }

        public UserDataException(string message, ExceptionType exception) : base(message)
        {
            this.exception = exception;
        }
    }
}
