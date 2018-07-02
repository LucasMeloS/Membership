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
            Inserir_membro Imembro = new Inserir_membro();
            Imembro.ShowDialog();
        }

        private void AtualizarBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (MeuDataGrid.SelectedItem as Membro).id;
            Atualizar_membro Amembro = new Atualizar_membro(Id);
            Amembro.ShowDialog(); 
        }

        private void ExcluirBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (MeuDataGrid.SelectedItem as Membro).id;
            var deletamembro = db.Membros.Where(m => m.id == Id).Single();
            db.Membros.Remove(deletamembro);
            db.SaveChanges();
            MeuDataGrid.ItemsSource = db.Membros.ToList();
        }
    }
}
