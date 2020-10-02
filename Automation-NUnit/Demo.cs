using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_NUnit
{
    class Demo
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\mujta\\Desktop\\Selenium2\\");
        }

        [Test]
        public void test()
        {
            driver.Url = "http://www.google.com.pk";
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
