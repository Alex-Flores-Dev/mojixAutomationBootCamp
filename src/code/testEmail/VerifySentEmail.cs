using SeleniumTraining.src.code.mainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class VerifySentEmail : TestBase
    {
        sendEmailIframe sendEmail = new sendEmailIframe();
        setEmail setEmail = new setEmail();
        InboxIframe inboxEmail = new InboxIframe();

        protected override string UrlBase()
        {
            return "https://yopmail.com/";
        }

        [TestMethod]
        public void VerifyEmail()
        {
            
            //Arrange
            Random rnd = new Random();
            int num = rnd.Next();

            string email = $"AlexFlores{num}";
            string subject = $"I'm a subject {num}";

            //Act
            setEmail.setTextNewEmail.SetText(email);
            setEmail.ClickCreateEmail();

            sendEmail.newEmail.Click();
            sendEmail.changeToFrame("ifmail");
            sendEmail.messageTo.SetText($"{email}@yopmail.com");
            sendEmail.messageSubject.SetText(subject);
            sendEmail.messageBody.SetText("Hi I'm an email");
            sendEmail.messageSend.Click();
            
            inboxEmail.messageSendPopUp.IsControlDisplayed();
            inboxEmail.changeToFrame("parent");
            Thread.Sleep(50000);

            inboxEmail.refreshPage.Click();
            inboxEmail.changeToFrame("ifinbox");

            //Assert
            Assert.IsTrue(inboxEmail.VerifyIfEmailWasReceived($"{email}@yopmail.com", subject));
        }
    }
}
