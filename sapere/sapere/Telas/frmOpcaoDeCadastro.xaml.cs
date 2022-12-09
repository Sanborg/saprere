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

namespace sapere.View
{
    /// <summary>
    /// Lógica interna para frmOpcaoDeCadastro.xaml
    /// </summary>
    public partial class frmOpcaoDeCadastro : Window
    {
        public Usuario usuario { get; }
        public frmOpcaoDeCadastro()
        {
            InitializeComponent();
        }
        public frmOpcaoDeCadastro(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        private void PressionarBotaoTornarContribuinte(object sender, MouseButtonEventArgs e)
        {
            frmCadastroUsuarioContribuinte frmCadastroUsuarioContribuinte = new frmCadastroUsuarioContribuinte(usuario);
            frmCadastroUsuarioContribuinte.Show();
            Close();
        }

        private void PressionarBotaoNaoTornarContribuinte(object sender, MouseButtonEventArgs e)
        {
            frmMenu frmMenu = new frmMenu(usuario, null, false);
            frmMenu.Show();
            Close();
        }
    }
}
