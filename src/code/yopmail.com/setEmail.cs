using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.mainPage
{
    public class setEmail
    {
        public TextBox setTextNewEmail = new TextBox(By.XPath("//input[@placeholder='Enter your inbox here']"));

        public void ClickCreateEmail()
        {
            Button addNewEmail = new Button(By.XPath("//div[@id='refreshbut']/button[1]"));
            addNewEmail.Click();
        }

    }
}
