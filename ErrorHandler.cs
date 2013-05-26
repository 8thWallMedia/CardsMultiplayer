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
        Error Codes 1-99 = Launcher Errors
        Error Codes 100-199 = Login Errors
        Error Codes A200-C299 = Runtime Errors
        Error Ending -1 = Error Reported
        Error Ending -0 = Error Not Reported
    */
    class ErrorHandler
    {
        public static const int ERROR_INVALID_CREDENTIALS = 100;
        public static const int ERROR_INVALID_LOGIN_OFFLINE = 101;
        public static const int ERROR_INVALID_LOGIN_RESPONSE = 102;
        public static const int ERROR_LOGINSERVER_TIMEOUT = 103;
        public static const int ERROR_ACCOUNT_DISABLE = 104;
        public static const int ERROR_HOST_BANNED = 105;
        public static string GetErrorMessage(int ErrorID)
        {
            switch (ErrorID)
            {
                case ERROR_INVALID_CREDENTIALS: return "The username/password was incorrect.";
                case ERROR_INVALID_LOGIN_OFFLINE: return "The login server is offline.";
                case ERROR_INVALID_LOGIN_RESPONSE: return "The server returned an unexpected response.";
                case ERROR_LOGINSERVER_TIMEOUT: return "The login request has timed out.";
                case ERROR_ACCOUNT_DISABLE: return "Your account has been disabled!";
                case ERROR_HOST_BANNED: return "Your host address was rejected by the server.";
            }
            return "Unhandled Exception.";
        }
    }
}
