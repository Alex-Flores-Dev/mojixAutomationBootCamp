using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.mainPage
{
    public class sendEmailIframe
    {
        public Button newEmail = new Button(By.Id("newmail"));
        public TextBox messageTo = new TextBox(By.Id("msgto"));
        public TextBox messageBody = new TextBox(By.Id("msgbody"));
        public TextBox messageSubject = new TextBox(By.Id("msgsubject"));
        public Button messageSend = new Button(By.Id("msgsend"));
        

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
