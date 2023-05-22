using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.mainPage
{
    public class LoginPage
    {
        
        public TextBox inputEmail = new TextBox(By.XPath("//input[contains(@placeholder,\"Enter your email...\")]"));
        public TextBox inputPassword = new TextBox(By.XPath("//input[contains(@placeholder,\"Enter your password...\")]"));
        public Button singUpButton = new Button(By.XPath("//span[contains(text(),\"Log in\")]/.."));
        public TextBox banner = new TextBox(By.Id("top_bar_inner"));

        
        //public bool VerifyIfEmailWasReceived(string email, string subject) {
        //    TextBox newEmailReceived = new TextBox(By.XPath($"//span[contains(text(),\"{email.ToLower()}\")]"));
        //    TextBox subjectReceived = new TextBox(By.XPath($"//div[contains(text(),\"{subject}\")]"));
        //    return newEmailReceived.IsControlDisplayed();
        //}

        //public void changeToFrame(string frame) {
        //    switch (frame)
        //    {
        //        case "parent":
        //            session.Session.Instance().GetBrowser().SwitchTo().ParentFrame();
        //            break;
        //        default:
        //            session.Session.Instance().GetBrowser().SwitchTo().Frame(frame);
        //            break;
        //    }
        //}
    }
}
