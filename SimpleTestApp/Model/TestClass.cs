using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimpleTestApp.Model
{
    public class TestClass : ObservableValidator
    {
        public TestClass() { }
       

        public TestClass(string name, int age)
        {
            Name = name;
            Age = age;
        }

        private string _Name;
        [Required (AllowEmptyStrings = false, ErrorMessage = "What's your Name?")]
        [RegularExpression (@"^\w+[\s][\w\s]+\w+$", ErrorMessage = "Check your name")]
        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value, true); }
        }

        private int _Age;
        [Range(0,120, ErrorMessage = "What a strange age")]
        public int Age
        {
            get { return _Age; }
            set { SetProperty(ref _Age, value, true); }
        }

    }
}
