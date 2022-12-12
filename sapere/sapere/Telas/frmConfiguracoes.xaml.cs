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
        public Evento evento { get; }
        public bool respondeuEvento { get; }
        public frmConfiguracoes()
        {
            InitializeComponent();
        }
        public frmConfiguracoes(Usuario usuario, Evento evento, bool respondeuEvento)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.evento = evento;
            this.respondeuEvento = respondeuEvento;
        }
        private void PressionarBtnTrocarUsuario(object sender, MouseButtonEventArgs e)
        {
            frmLogin frmLogin = new frmLogin(evento, respondeuEvento);
            frmLogin.Show();
            Close();
        }
        private void PressionarBtnAlterarSenha(object sender, MouseButtonEventArgs e)
        {
            frmAlteracaoDeSenha frmAlteracaoDeSenha = new frmAlteracaoDeSenha(evento, usuario.email);
            frmAlteracaoDeSenha.Show();
            Close();
        }
        private void PressionarBtnExcluirConta(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
            "Você deseja realmente deletar sua conta",
            "Atenção",
            MessageBoxButton.YesNo,
            MessageBoxImage.Warning
            );
            if(result == MessageBoxResult.Yes)
            {
                bool foiExcluido = cUsuario.ExcluirUsuario(usuario.id);
                if(foiExcluido == true)
                {
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.Show();
                    Close();
                }
                else
                {
                    MessageBoxResult result2 = MessageBox.Show(
                    "Não foi possível deletar sua conta. Tente novamente mais tarde.",
                    "Erro",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                    );
                }
            }
            else if(result == MessageBoxResult.No)
            {

            }
        }
        private void PressionarTornarContribuinte(object sender, MouseButtonEventArgs e)
        {
            frmCadastroUsuarioContribuinte frmCadastroUsuarioContribuinte = new frmCadastroUsuarioContribuinte(usuario, evento, respondeuEvento);
            frmCadastroUsuarioContribuinte.Show();
            Close();
        }
    }
}
