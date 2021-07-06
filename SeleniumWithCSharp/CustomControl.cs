using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
	}
}
