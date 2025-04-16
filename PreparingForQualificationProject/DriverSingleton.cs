using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace PreparingForQualificationProject
{
    public class DriverSingleton
    {
        private static WebDriver? driver;

        private DriverSingleton() { }

        public static WebDriver GetDriver(BrowserTypes type)
        {
            if (driver == null)
            {
                switch (type)
                {
                    case BrowserTypes.CHROME:
                        driver = new ChromeDriver();
                        break;
                    case BrowserTypes.FIREFOX:
                        driver = new FirefoxDriver();
                        break;
                    case BrowserTypes.EGDE:
                        driver = new EdgeDriver();
                        break;
                }
            }

            return driver;
        }
    }
}
