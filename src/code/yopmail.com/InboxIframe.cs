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
    public class InboxIframe
    {
        
        public Button refreshPage = new Button(By.Id("refresh"));
        public TextBox messageSendPopUp = new TextBox(By.XPath("//div[contains(text(),\"Your message has been sent\")]"));
        
        public bool VerifyIfEmailWasReceived(string email, string subject) {
            TextBox newEmailReceived = new TextBox(By.XPath($"//span[contains(text(),\"{email.ToLower()}\")]"));
            TextBox subjectReceived = new TextBox(By.XPath($"//div[contains(text(),\"{subject}\")]"));
            return newEmailReceived.IsControlDisplayed();
        }

        public void changeToFrame(string frame) {
            switch (frame)
            {
                case "parent":
                    session.Session.Instance().GetBrowser().SwitchTo().ParentFrame();
                    break;
                default:
                    session.Session.Instance().GetBrowser().SwitchTo().Frame(frame);
                    break;
            }
        }
    }
}
