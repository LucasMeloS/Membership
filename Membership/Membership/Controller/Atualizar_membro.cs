using Membership.DAL;
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

namespace Membership
{
    /// <summary>
    /// Interaction logic for Atualizar_membro.xaml
    /// </summary>
    public partial class Atualizar_membro : Window
    {
        MemberShipEntities db = new MemberShipEntities();
        int Id;
        public Atualizar_membro(int membroId)
        {
            InitializeComponent();
            Id = membroId;
        }

        private void AtualizarBtn_Click(object sender, RoutedEventArgs e)
        {
            Membro AtualizaMembro = (from m in db.Membros
                                     where m.id == Id
                                     select m).Single();

            AtualizaMembro.nome = nomeTextBox.Text;
            AtualizaMembro.genero = generoComboBox.Text;
            AtualizaMembro.email = emailTextBox.Text;
            AtualizaMembro.idade = Convert.ToByte(idadeTextBox.Text);
            db.SaveChanges();
            MainWindow.dataGrid.ItemsSource = db.Membros.ToList();




        }
    }
}
