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

namespace Membership
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MemberShipEntities db = new MemberShipEntities();
        Inserir_membro Imembro = new Inserir_membro();
        Atualizar_membro Amembro = new Atualizar_membro();
        public static DataGrid dataGrid;

        public MainWindow()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            MeuDataGrid.ItemsSource = db.Membros.ToList();
            dataGrid = MeuDataGrid;
        }

        private void AdicionarBtn_Click(object sender, RoutedEventArgs e)
        {
            
            Imembro.ShowDialog();
        }

        private void AtualizarBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (MeuDataGrid.SelectedItem as Membros).id;
            Amembro.ShowDialog();
        }
    }
}
