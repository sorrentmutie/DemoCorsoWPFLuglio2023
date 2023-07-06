using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DemoCorsoWPF
{
    /// <summary>
    /// Logica di interazione per SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        private readonly ILogger<SecondWindow> logger;

        public SecondWindow(ILogger<SecondWindow> logger)
        {
            InitializeComponent();
            this.logger = logger;
            this.logger.LogInformation("SecondWindow created");
        }
    }
}
