using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
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
    public partial class OknoDataGrid : Window
    {
        BigViewTableAdapter BigView = new BigViewTableAdapter();
        TeamsTableAdapter Teams = new TeamsTableAdapter();
        IgrokisTableAdapter Igrokis = new IgrokisTableAdapter();
        TurnirisTableAdapter Turniris = new TurnirisTableAdapter();
        KomandiTurniriTableAdapter KomandiTurniri = new KomandiTurniriTableAdapter();
        TeamsViewTableAdapter TeamsView = new TeamsViewTableAdapter();
        PlayersViewTableAdapter PlayersView = new PlayersViewTableAdapter();
        TournamentsViewTableAdapter TournamentsView = new TournamentsViewTableAdapter();
        bazadannihPPDataSet dataSet;
        List<string> tableNames = new List<string> {"Объединенная таблица"};
        public OknoDataGrid()
        {
            InitializeComponent();
            CybersportDataGrid.ItemsSource = BigView.GetDataBy();

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
