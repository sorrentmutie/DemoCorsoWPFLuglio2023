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
          
        }

       
    }
}
