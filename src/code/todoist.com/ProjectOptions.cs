using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SeleniumTraining.src.code.todoPage
{
    public class ProjectOptions
    {
        public Button editProject = new Button(By.XPath("//div[contains(text(),\"Edit project\")]/../.."));
        public Button deleteProject = new Button(By.XPath("//div[contains(text(),\"Delete project\")]/../.."));
        public Button confirmDelete = new Button(By.XPath("//span[contains(text(),\"Delete\")]/.."));
        

        public Boolean ProjectName(string projectName)
        {
            TextBox findProjectName = new TextBox(By.XPath($"//span[contains(text(),\"{projectName}\")]"));
            return findProjectName.IsControlDisplayed();
        }

        public void clickOption(string text) {
            Button moreOptions = new Button(By.XPath($"//span[contains(text(),\"{text}\")]/../..//div/button"));
            moreOptions.Click();
        }
    }
        
}

