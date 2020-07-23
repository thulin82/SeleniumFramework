using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Xml.XPath;

namespace SeleniumFramework.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfigurationRoot configRoot = builder.Build();

            Settings.SUT = configRoot.GetSection("testSettings").Get<TestSettings>().sut;
            Settings.BrowserType = configRoot.GetSection("testSettings").Get<TestSettings>().browser;
            Settings.UserName = configRoot.GetSection("testData").Get<TestData>().username;
            Settings.CheckBoxTitle = configRoot.GetSection("testData").Get<TestData>().checkboxtitle;
            Settings.RadioButtonTitle = configRoot.GetSection("testData").Get<TestData>().radiobuttontitle;
            Settings.SimpleFormTitle = configRoot.GetSection("testData").Get<TestData>().simpleformtitle;
        }
    }
}
