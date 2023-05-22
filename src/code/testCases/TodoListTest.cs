using SeleniumTraining.src.code.mainPage;
using SeleniumTraining.src.code.test;
using SeleniumTraining.src.code.todoPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.testEmail
{
    [TestClass]
    public class TodoListTest:TestBase
    {
        LoginPage loginPage = new LoginPage();
        ProjectOptions projectOptions = new ProjectOptions();
        SetProject setProject = new SetProject();
        protected override string UrlBase()
        {
            return "https://todoist.com/auth/login";
        }

        [TestMethod]
        public void Login()
        {
            Random rnd = new Random();
            int num = rnd.Next();
            string email = "alexflores.devp@gmail.com";
            string password = "GJ4#*jr1vjT2";
            string projectName = "ProjectNameRandom";
            string projectNameUpdated = $"Proyecto {num}";

            loginPage.inputEmail.SetText(email);
            loginPage.inputPassword.SetText(password);
            loginPage.singUpButton.Click();
            Assert.IsTrue(loginPage.banner.IsControlDisplayed());

            setProject.newProject.Click();
            setProject.projectName.SetText(projectName);
            setProject.selectColor.Click();
            setProject.colorElements.Click();
            setProject.submitProjectProject.Click();
            Assert.IsTrue(projectOptions.ProjectName(projectName));

            projectOptions.clickOption(projectName);
            projectOptions.editProject.Click();
            setProject.projectName.SetText(projectNameUpdated);
            setProject.submitProjectProject.Click();
            Assert.IsTrue(projectOptions.ProjectName(projectNameUpdated));

            projectOptions.clickOption(projectNameUpdated);
            projectOptions.deleteProject.Click();
            projectOptions.confirmDelete.Click();
            Assert.IsTrue(!projectOptions.ProjectName(projectNameUpdated));
        }


    }
}
