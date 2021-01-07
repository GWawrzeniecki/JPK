using MahApps.Metro.Controls;
using Prism.Regions;
using System.Windows;

namespace PrismJPKEditor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            RegionManager.SetRegionName(this.contentRegionControl, "ContentRegion");
            RegionManager.SetRegionManager(this.contentRegionControl, regionManager);

        }

    }
}
