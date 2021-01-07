using Prism.Regions;
using System.Windows.Controls;

namespace PrismJPKEditor.Modules.TaskBar.Views
{
    /// <summary>
    /// Interaction logic for TaskBarView
    /// </summary>
    public partial class TaskBarView : MenuItem
    {
        public TaskBarView()
        {

            InitializeComponent();

            //RegionContext.GetObservableContext(this).Value = 5;

        }
    }
}
