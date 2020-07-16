using SeleniumExtras.PageObjects;

namespace SeleniumFramework.Base
{
    public abstract class BasePage
    {

        public BasePage()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
        }
    }
}
