using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWithCSharp
{
	public class CustomControl : DriverHelper
	{
		public static void ComboBoxControl(string controlName, string value)
		{
			var comboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
			comboControl.Clear();
			comboControl.SendKeys(value);

			Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();

		}

		public static void EnterText(IWebElement webElement, string value)
		{
			webElement.SendKeys(value);
		}

		public static void ClickElement(IWebElement webElement)
		{
			webElement.Click();
		}
		public static void SelectByValue(IWebElement webElement, string value)
		{
			SelectElement selectElement = new SelectElement(webElement);
			selectElement.SelectByValue(value);
		}
		public static void SelectByText(IWebElement webElement, string text)
		{
			SelectElement selectElement = new SelectElement(webElement);
			selectElement.SelectByText(text);
		}
	}
}
