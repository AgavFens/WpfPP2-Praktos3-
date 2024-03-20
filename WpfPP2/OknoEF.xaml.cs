using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
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
using System.Xml;
using WpfPP2.bazadannihPPDataSetTableAdapters;

namespace WpfPP2
{
    public partial class OknoEF : Window
    {
        private bazadannihPPEntities context = new bazadannihPPEntities();
        public OknoEF()
        {
            InitializeComponent();
            CybersportDataGrid.ItemsSource = context.BigView.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CybersportDataGrid.Columns[0].Visibility = Visibility.Collapsed;

        }

        private void Back_knopka_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

    }
}


