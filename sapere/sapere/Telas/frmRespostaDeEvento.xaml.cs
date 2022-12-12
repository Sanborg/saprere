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
    /// Lógica interna para frmRespostaDeEvento.xaml
    /// </summary>
    public partial class frmRespostaDeEvento : Window
    {
        public Usuario usuario { get; }
        public Evento evento { get; }
        public frmRespostaDeEvento()
        {
            InitializeComponent();
        }
        public frmRespostaDeEvento(Usuario usuario, Evento evento)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.evento = evento;
        }
        private bool VerificaCampos()
        {
            if (boxEmail.Titulo != "" && boxSenha.Resposta != "")
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
        private void ResponderEvento()
        {
            if (VerificaCampos() == true)
            {
                bool foiRespondido = cEvento.ResponderEvento(evento.id, usuario.id, boxResposta.Text, boxTitulo.Text, boxLink1.Text, boxLink2.Text, boxLink3.Text);
                if (foiRespondido == true)
                {
                    Evento evento = cEvento.BuscarEvento(boxTitulo.Text);
                    frmMenu frmMenu = new frmMenu(usuario, evento, foiRespondido);
                    frmMenu.Show();
                    Close();
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show(
                    "Não foi possível enviar sua resposta. Tente novamente mais tarde.",
                    "Erro",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                    );
                }
            }
        }
        private void PressionarBtnResponder(object sender, MouseButtonEventArgs e)
        {
            ResponderEvento();
        }
        private void PressionarBtnVoltar(object sender, MouseButtonEventArgs e)
        {
            frmMenu frmMenu = new frmMenu(usuario, evento, false);
            frmMenu.Show();
            Close();
        }
    }
}
