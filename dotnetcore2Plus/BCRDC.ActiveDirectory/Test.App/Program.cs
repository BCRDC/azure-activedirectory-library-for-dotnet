using BCRDC.Aad;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;

namespace Test.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var authority = "https://login.chinacloudapi.cn";
            var clientID = "3616ba46-b2b1-4cba-ac37-ee42fbb3d19f";
            var resource = "https://analysis.chinacloudapi.cn/powerbi/api";
            var userName = "";
            var pwd = "";
            var tenant = "common";

            var authenticationContext = new AuthenticationContext($"{authority}/{tenant}");

            // Authentication using master user credentials
            var credential = new UserPasswordCredential(userName, pwd);
            var authenticationResult = authenticationContext.AcquireTokenAsync(resource, clientID, credential).Result;
            Console.WriteLine("Hello World!");
        }
    }
}
