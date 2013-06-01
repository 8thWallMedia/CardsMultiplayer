/*  
 * Class: ErrorHandler.cs
 * Purpose: Provide error handling data to requesting scripts. Use as static.
 * Author: Cameron 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsMultiplayer
{
    /*
        Error Code 0 = Non-Error. Response OK
        Error Codes 1-99 = Launcher Errors
        Error Codes 100-199 = Login Errors
        Error Codes 200-599 = Runtime Errors
        Error Codes 600-699 = Registration Errors
        Error Ending -1 = Error Reported
        Error Ending -0 = Error Not Reported
    */
    class ErrorHandler
    {
        //Login Errors
        public const int LOGIN_OK = 100;
        public const int ERROR_INVALID_CREDENTIALS = 101;
        public const int ERROR_LOGIN_OFFLINE = 10061;
        public const int ERROR_INVALID_LOGIN_RESPONSE = 103;
        public const int ERROR_LOGINSERVER_TIMEOUT = 104;
        public const int ERROR_ACCOUNT_DISABLE = 105;
        public const int ERROR_HOST_BANNED = 106;
        public const int NOERROR_REGISTRATION_VALIDATION = 107;
        public const int ERROR_INVALID_CHARACTERS = 108;

        //Runtime Errors
        public const int ERROR_AUTH_MISMATCH = 200;
        public const int ERROR_CLIENT_MODIFICATION_DETECTED = 201;

        //Registration Errors
        public const int REGISTER_OK = 600;
        public const int ERROR_ACCOUNT_EXISTS = 601;
        public const int ERROR_ACCOUNT_ALREADY_AUTHORIZED = 602;
        public const int ERROR_REGISTER_CODE_INCORRECT = 603;
        public const int ERROR_EMAIL_ALREADY_USED = 604;
        public const int ERROR_NOT_ALL_INFORMATION_PROVIDED = 605;
        public const int ERROR_EMAIL_FORMAT_INCORRECT = 606;
        
        public static string GetErrorMessage(int ErrorID)
        {
            switch (ErrorID)
            {
                case LOGIN_OK: return "Your credentials were validated.";
                case ERROR_INVALID_CREDENTIALS: return "The username/password was incorrect.";
                case ERROR_LOGIN_OFFLINE: return "The login server is offline.";
                case ERROR_INVALID_LOGIN_RESPONSE: return "The server returned an unexpected response.";
                case ERROR_LOGINSERVER_TIMEOUT: return "The login request has timed out.";
                case ERROR_ACCOUNT_DISABLE: return "Your account has been disabled!";
                case ERROR_HOST_BANNED: return "Your host address was rejected by the server.";
                case NOERROR_REGISTRATION_VALIDATION: return "Please enter the registration code!";
                case ERROR_INVALID_CHARACTERS: return "Username contains invalid characters!";

                case ERROR_ACCOUNT_EXISTS: return "That account already exists. Please try another name.";
                case ERROR_ACCOUNT_ALREADY_AUTHORIZED: return "Your account is already activated!";
                case ERROR_REGISTER_CODE_INCORRECT: return "Check your email for a valid registration code.";
                case ERROR_EMAIL_ALREADY_USED: return "That email is already in use. Please use the account recovery system.";
                case ERROR_NOT_ALL_INFORMATION_PROVIDED: return "Not all information was provided!";
                case ERROR_EMAIL_FORMAT_INCORRECT: return "The email was not correctly formatted.";

                case ERROR_CLIENT_MODIFICATION_DETECTED: return "Client modification detected. Contact Customer Support.";
            }
            return "Unhandled Exception.";
        }
    }
}
