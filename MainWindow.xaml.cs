using DemoCorsoWPF.Data;
using Microsoft.Extensions.Configuration;
using System.Windows;


namespace DemoCorsoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IDataAccess dataAccess;
        private readonly SecondWindow secondWindow;
        private readonly IConfiguration configuration;

        public MainWindow(IDataAccess dataAccess, 
            SecondWindow secondWindow,
            IConfiguration configuration)
        {
            InitializeComponent();
            this.dataAccess = dataAccess;
            this.secondWindow = secondWindow;
            this.configuration = configuration;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var x = configuration["Prova"];
            data.Text = dataAccess.GetData();
        }

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            secondWindow.Show();
        }
    }
}
