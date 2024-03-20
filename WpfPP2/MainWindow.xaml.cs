using System;
using System.Collections.Generic;
using System.Data;
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
using WpfPP2.bazadannihPPDataSetTableAdapters;

namespace WpfPP2
{
    public partial class MainWindow : Window
    {
        string selectedTable = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DataSetknopka_Click(object sender, RoutedEventArgs e)
        {
            new OknoDataGrid().Show();
            this.Close();
        }

        private void Efknopka_Click(object sender, RoutedEventArgs e)
        {
            new OknoEF().Show();
            this.Close();
        }
        private void Exitknopka_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
