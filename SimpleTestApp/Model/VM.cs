using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SimpleTestApp.Model
{
    public class VM : ObservableValidator
    {
        public ObservableCollection<TestClass> Men { get; } = new ObservableCollection<TestClass>
        {
            new TestClass("Tim", 32),
            new TestClass("Tom Test", 170)
        };

        public ObservableCollection<TestClass> Women { get; } = new ObservableCollection<TestClass>
        {
            new TestClass("Katja", 15),
            new TestClass("Sylvi Dog", -7)
        };
    }
}
