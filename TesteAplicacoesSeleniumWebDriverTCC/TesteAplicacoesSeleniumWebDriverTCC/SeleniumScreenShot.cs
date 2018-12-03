using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing.Imaging;
using NUnit.Framework;

namespace TesteAplicacoesSeleniumWebDriverTCC
{
    class SeleniumScreenShot
    {
       [Test]
        public static void TirarScreenShot()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.facebook.com");

            Screenshot ss = ((ITakesScreenshot)PropertiesCollection.driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\dougl\Desktop\facebook.png", ImageFormat.Png);
        }
        
    }
}
