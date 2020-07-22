using System;
using System.IO;
using System.Xml.XPath;

namespace SeleniumFramework.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {
            XPathItem SUT;
            XPathItem BrowserType;
            XPathItem UserName;
            XPathItem CheckBoxTitle;
            XPathItem RadioButtonTitle;
            XPathItem SimpleFormTitle;

            string fileName = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
            FileStream stream = new FileStream(fileName, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            SUT = navigator.SelectSingleNode("SeleniumFramework/RunSettings/SUT");
            BrowserType = navigator.SelectSingleNode("SeleniumFramework/RunSettings/BrowserType");
            UserName = navigator.SelectSingleNode("SeleniumFramework/RunSettings/UserName");
            CheckBoxTitle = navigator.SelectSingleNode("SeleniumFramework/Titles/CheckBoxTitle");
            RadioButtonTitle = navigator.SelectSingleNode("SeleniumFramework/Titles/RadioButtonTitle");
            SimpleFormTitle = navigator.SelectSingleNode("SeleniumFramework/Titles/SimpleFormTitle");


            Settings.SUT = SUT.Value.ToString();
            Settings.BrowserType = (Base.BrowserType)Enum.Parse(typeof(Base.BrowserType), BrowserType.Value.ToString());
            Settings.UserName = UserName.Value.ToString();
            Settings.CheckBoxTitle = CheckBoxTitle.Value.ToString();
            Settings.RadioButtonTitle = RadioButtonTitle.Value.ToString();
            Settings.SimpleFormTitle = SimpleFormTitle.Value.ToString();
        }
    }
}
