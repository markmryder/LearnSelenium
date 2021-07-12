using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWithCSharp.Pages
{
	class LoginPage : DriverHelper
	{
		IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));
		IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
		IWebElement btnLogin => Driver.FindElement(By.CssSelector(".btn-default"));

		public void EnterUserNameAndPassword(string username, string password)
		{
			txtUserName.SendKeys(username);
			txtPassword.SendKeys(password);
		}

		public void ClickLogin()
		{
			btnLogin.Click();
		}
	}
}
