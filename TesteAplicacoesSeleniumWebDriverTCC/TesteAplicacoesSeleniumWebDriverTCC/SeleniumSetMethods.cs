using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing.Imaging;
namespace TesteAplicacoesSeleniumWebDriverTCC
{
    public static class SeleniumSetMethods
    {
        /// <summary>
        ///  Metodo extendido para digitar texto 
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);

            //if(elementType == PropertyType.Id)
            //    PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            //if (elementType == PropertyType.Name)
            //    PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        /// <summary>
        /// Clicar em botão, CheckBox, Opções, etc
        /// </summary>
        /// <param name="element"></param>
        public static void Clicks(this IWebElement element)
        {
            element.Click();

            //if (elementType == PropertyType.Id)
            //    PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            //if (elementType == PropertyType.Name)
            //    PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        }

        /// <summary>
        /// Selecionando um Controle DropDown
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);

            //if (elementType == PropertyType.Id)
            //    new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            //if (elementType == PropertyType.Name)
            //    new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
