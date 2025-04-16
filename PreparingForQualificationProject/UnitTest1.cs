using Allure.Net.Commons;
using Allure.NUnit;
using Allure.NUnit.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PreparingForQualificationProject
{
    [AllureNUnit]
    [TestFixture]
    public class Tests
    {
        static WebDriver driver;

        [SetUp]
        public void Setup()
        {
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://the-internet.herokuapp.com");
            //driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/forgot_password");
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]  // Устанавливаем уровень важности теста
        [AllureTag("Smoke")]  // Добавляем тег для теста
        [AllureDescription("This test checks the functionality of the forgot password form.")]
        [AllureStep("Step for testing")]
        public void Test1()
        {
            //Cookie cookie = new Cookie("testKey", "testValue");
            //driver.Manage().Cookies.AddCookie(cookie);
            //Assert.IsTrue(driver.Manage().Cookies.AllCookies.Contains(cookie), "There is no cookie");
            //driver.Manage().Cookies.DeleteCookie(cookie);
            //Assert.IsTrue(!driver.Manage().Cookies.AllCookies.Contains(cookie), "There is cookie");
            //string filepath = "C:/Users/d.zhaksylyk/source/repos/PreparingForQualificationProject/PreparingForQualificationProject/FileName.txt";
            //driver.FindElement(By.XPath("//input[@id = 'file-upload']")).SendKeys(filepath);
            //driver.FindElement(By.XPath("//input[@id = 'file-submit']")).Click();
            var locator = RelativeBy.WithLocator(By.TagName("input")).Above(By.XPath("//button[@id = 'form_submit']"));
            driver.FindElement(locator).SendKeys("av");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}