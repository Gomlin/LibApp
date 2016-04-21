using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace LibAppWebAPI
{
    public static class CredentialsHandler
    {
        public static string DBUser;
        public static string DBPassword;

        public static void setCredentials()
        {
            string[] Credentials = File.ReadAllText(@"C:\Users\Andre\Projects\LibApp\Secretfile.txt").Split(new string[] { "\r\n" }, StringSplitOptions.None);
            DBUser = Credentials[0];
            DBPassword = Credentials[1];
        }
    }
}