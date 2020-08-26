using Xamarin.Forms;
using XFWPFNetCore.Services;
using XFWPFNetCore.WPF;

[assembly: Dependency(typeof(SecondaryWindowService))]
namespace XFWPFNetCore.WPF
{
    public class SecondaryWindowService : ISecondaryWindowService
    {
        public void OpenSecondaryWindow()
        {
            var secondaryWindow = new SecondaryWindow();
            secondaryWindow.Show();
        }
    }
}
