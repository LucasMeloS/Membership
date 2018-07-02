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
    /// Interaction logic for Inserir_membro.xaml
    /// </summary>
    public partial class Inserir_membro : Window
    {
        MemberShipEntities db = new MemberShipEntities();
        Membro membros = new Membro();

        public Inserir_membro()
        {
            InitializeComponent();
        }

        private void AdicionarBtn_Click(object sender, RoutedEventArgs e)
        {

            
                 membros.nome = nomeTextBox.Text;
                 membros.genero = generoComboBox.Text;
                 membros.email = emailTextBox.Text;
                 membros.idade = Convert.ToByte(idadeTextBox.Text);




            db.Membros.Add(membros);
            db.SaveChanges();
            MainWindow.dataGrid.ItemsSource = db.Membros.ToList();
            this.Hide();

              

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
       
        }

        private void nomeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
