using System.Windows;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace XFWPFNetCore.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();
            Forms.Init();
            Syncfusion.SfDataGrid.XForms.WPF.SfDataGridRenderer.Init();
            LoadApplication(new XFWPFNetCore.App());
        }
    }
}
