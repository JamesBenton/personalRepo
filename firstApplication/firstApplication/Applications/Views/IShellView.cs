using System.Waf.Applications;

namespace firstApplication.Applications.Views
{
    internal interface IShellView : IView
    {
        void Show();

        void Close();
    }
}
