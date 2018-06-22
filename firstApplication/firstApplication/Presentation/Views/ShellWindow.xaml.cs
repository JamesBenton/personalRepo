using System.ComponentModel.Composition;
using System.Windows;
using firstApplication.Applications.Views;

namespace firstApplication.Presentation.Views
{
    [Export(typeof(IShellView))]
    public partial class ShellWindow : Window, IShellView
    {
        public ShellWindow()
        {
            InitializeComponent();
        }
    }
}
