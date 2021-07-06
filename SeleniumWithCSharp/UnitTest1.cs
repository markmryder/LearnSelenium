using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;

namespace SeleniumWithCSharp
{
	public class Tests : DriverHelper
	{
		//public static IWebDriver Driver;

		[SetUp]
		public void Setup()
		{
			Debug.WriteLine("Setup");
			Driver = new ChromeDriver("E:\\SeleniumAutomation\\drivers");
			//Driver = new ChromeDriver();
			//Driver.Manage().Window();
		}

		[Test]
		public void Test1()
		{
			Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
			var element = Driver.FindElement(By.Id("ContentPlaceHolder1_Meal"));
			element.SendKeys("Tomato");

			var checkbox = Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']"));
			checkbox.Click();

			string comboControlName = "ContentPlaceHolder1_AllMealsCombo";
			CustomControl control = new CustomControl();
			control.ComboBoxControl(comboControlName, "Almond");

			
			Console.WriteLine("Test1");
			Assert.Pass();
		}
	}
}