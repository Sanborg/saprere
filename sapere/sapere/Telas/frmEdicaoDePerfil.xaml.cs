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
    /// Lógica interna para frmEdicaoDePerfil.xaml
    /// </summary>
    public partial class frmEdicaoDePerfil : Window
    {
        public Usuario usuario { get; }
        public Evento evento { get; }
        public bool respondeuEvento { get; }
        bool pressionouAnexarImagem = false;
        public frmEdicaoDePerfil()
        {
            InitializeComponent();
        }
        public frmEdicaoDePerfil(Usuario usuario, Evento evento, bool respondeuEvento)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.evento = evento;
            this.respondeuEvento = respondeuEvento;
        }
        public void AjustarCampos()
        {
            boxNome.Text = usuario.nome;
            boxEmail.Text = usuario.email;
        }
        private bool VerificaCampos()
        {
            if (boxNome.Text != "" && boxEmail.Text != "")
            {
                return true;
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                "Preencha todos os campos",
                "Atenção",
                MessageBoxButton.OK,
                MessageBoxImage.Warning
                );
                return false;
            }
        }
        public void AtualizarPerfil()
        {
            if(VerificaCampos() == true)
            {
                bool foiAtualizado = cUsuario.EditarPerfil(usuario.id, boxNome.Text, boxEmail.Text);
                if (foiAtualizado == true)
                {
                    Usuario usuario = cUsuario.BuscarDadosUsuario(boxEmail.Text, boxSenha.Password);
                    frmPerfil frmPerfil = new frmPerfil();
                    frmPerfil.Show();
                    Close();
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show(
                    "Não foi possível realizar a edição de perfil. Tente novamente mais tarde.",
                    "Erro",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                    );
                }
            }
        }
        private void PressionarBtnAtualizarPerfil(object sender, MouseButtonEventArgs e)
        {
            AtualizarPerfil();
        }
        private void PressionarBtnVoltar(object sender, MouseButtonEventArgs e)
        {
            frmPerfil frmPerfil = new frmPerfil(usuario, evento, respondeuEvento);
            frmPerfil.Show();
            Close();
        }
    }
}
