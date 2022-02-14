using System.Configuration;

namespace TaxService.Models
{
    public static class GlobalSettings
    {
        public static class Environment
        {
            public static bool IsProduction = ConfigurationManager.AppSettings["ReleaseMode"] == "release";
        }

        public static class RegularExpressions
        {
            public const string EmailAddresses = @"^[^@]+@[^@]+\.[^@]+$";  // Has only one @ symbol, at least one character before the @, at least one character between the @ and the period, and at least one character after the period
            public const string LoginName = "^[a-zA-Z0-9]{3,}$";
            public const string Password = "^.{1,50}$";
            public const string PhoneNumber = @"\d{10,11}$";
        }
       
    }

      
       

}
