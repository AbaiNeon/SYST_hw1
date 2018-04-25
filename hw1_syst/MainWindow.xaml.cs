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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace hw1_syst
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnProccesses_Click(object sender, RoutedEventArgs e)
        {
            Process[] processes = Process.GetProcesses();

            var result = from p in processes
                         select new
                         {
                             Id = p.Id,
                             Name = p.ProcessName
                             //State = p.
                             //UserName = p.
                         };

            myDataGrid.ItemsSource = result;
        }
    }
}
