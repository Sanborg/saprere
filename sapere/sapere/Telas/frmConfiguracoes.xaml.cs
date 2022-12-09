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
    /// Lógica interna para frmConfiguracoes.xaml
    /// </summary>
    public partial class frmConfiguracoes : Window
    {
        public Usuario usuario { get; }
        public frmConfiguracoes()
        {
            InitializeComponent();
        }
        public frmConfiguracoes(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void PressionarBtnTrocarUsuario(object sender, MouseButtonEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            Close();
        }

        private void PressionarBtnAlterarSenha(object sender, MouseButtonEventArgs e)
        {
            frmAlteracaoDeSenha frmAlteracaoDeSenha = new frmAlteracaoDeSenha(usuario.email);
            frmAlteracaoDeSenha.Show();
            Close();
        }

        private void PressionarBtnExcluirConta(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void PressionarTornarContribuinte(object sender, MouseButtonEventArgs e)
        {
            frmCadastroUsuarioContribuinte frmCadastroUsuarioContribuinte = new frmCadastroUsuarioContribuinte(usuario);
            frmCadastroUsuarioContribuinte.Show();
            Close();
        }
    }
}
