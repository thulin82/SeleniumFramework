namespace SeleniumFramework
{
    public static class Config
    {
        public static int ElementsWaitingTimeout = 5;
        public static string BaseURL = "https://www.seleniumeasy.com/test/";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Email = "";
                public static string Username = "";
                public static string Password = "";
            }

            public static class Invalid
            {
                public static class Email
                {
                    public static string NoUser = "";
                    public static string NoAt = "";
                    public static string NoDomain = "";
                    public static string NoExtension = "";
                }

                public static class Username
                {
                    public static string FourCharacters = "abcd";
                    public static string ThirteenCharacters = "abcdabcdabcda";
                    public static string OnlyLetters = "abcdabcd";
                    public static string OnlyNumbers = "123456789";
                    public static string OnlySpecialSymbols = "$#@%)(*$%#%?><";
                    public static string NoSpecialSymbol = "asd1234";
                }

                public static class Password
                {
                    public static string FourCharacters = "abcd";
                    public static string ThirteenCharacters = "abcdabcdabcda";
                    public static string OnlyLetters = "abcdabcd";
                    public static string OnlyNumbers = "123456789";
                    public static string OnlySpecialSymbols = "$#@%)(*$%#%?><";
                    public static string NoSpecialSymbol = "asd1234";
                }
            }
        }

        public static class Title
        {
            public static string CheckBoxTitle = "Selenium Easy - Checkbox demo for automation using selenium";
            public static string RadioButtonTitle = "Selenium Easy Demo - Radio buttons demo for Automation";
            public static string SimpleFormTitle = "Selenium Easy Demo - Simple Form to Automate using Selenium";

        }
    }
}
