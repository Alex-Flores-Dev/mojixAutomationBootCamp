using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.todoPage
{
    public class SetProject
    {
        public Button newProject = new Button(By.XPath("//button[contains(@aria-label,\"Add project\")]"));
        public TextBox projectName = new TextBox(By.Id("edit_project_modal_field_name"));
        public Button selectColor = new Button(By.XPath("//button[@aria-labelledby=\"edit_project_modal_field_color_label\"]"));
        public Button colorElements = new Button(By.Id("dropdown-select-0-option-yellow"));  
        public Button submitProjectProject = new Button(By.XPath("//button[@type=\"submit\"]"));
    }
}
