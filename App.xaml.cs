using System.Windows;
using test;

namespace resx_wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_Startup(object sender, StartupEventArgs e)
        {
            System.Globalization.CultureInfo newUICulture = new System.Globalization.CultureInfo("de-DE");

            MyResource.Culture = newUICulture;

            System.Threading.Thread.CurrentThread.CurrentCulture = newUICulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = newUICulture;

            MainWindow = new MainWindow();
            MainWindow.Show();
        }
    }
}