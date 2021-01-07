using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PrismJPKEditor.Modules.JPK.Extensions
{
    public static class DependencyObjectExtensions
    {
        public static IEnumerable<T> FindVisualChildren<T>([NotNull] this DependencyObject dependencyObject)
            where T : DependencyObject
        {
            if (dependencyObject == null) throw new ArgumentNullException(nameof(dependencyObject));

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(dependencyObject); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(dependencyObject, i);
                if (child is T o)
                    yield return o;

                foreach (T childOfChild in FindVisualChildren<T>(child))
                    yield return childOfChild;
            }
        }

        public static childItem FindFirstVisualChild<childItem>([NotNull] this DependencyObject dependencyObject)
            where childItem : DependencyObject
        {
            if (dependencyObject == null) throw new ArgumentNullException(nameof(dependencyObject));

            return FindVisualChildren<childItem>(dependencyObject).FirstOrDefault();
        }
    }
}
