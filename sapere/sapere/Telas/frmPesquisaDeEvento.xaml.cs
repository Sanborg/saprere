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
    /// Lógica interna para frmPesquisaDeEvento.xaml
    /// </summary>
    public partial class frmPesquisaDeEvento : Window
    {
        public Usuario usuario { get; }
        public Evento evento { get; }
        public bool respondeuEvento { get; }
        public frmPesquisaDeEvento()
        {
            InitializeComponent();
        }
        public frmPesquisaDeEvento(Usuario usuario, Evento evento, bool respondeuEvento)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.evento = evento;
            this.respondeuEvento = respondeuEvento;
        }
        private bool VerificaCampo()
        {
            if (boxPesquisarEvento.Text != "")
            {
                return true;
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                "Preencha o campo da barra de pesquisa",
                "Atenção",
                MessageBoxButton.OK,
                MessageBoxImage.Warning
                );
                return false;
            }
        }
        public void PesquisarEvento()
        {
            if(VerificaCampo() == true)
            {
                Evento evento = cEvento.BuscarEvento(boxPesquisarEvento.Text);
                if (evento != null && respondeuEvento == false)
                {
                    txtTituloEventoNaoRespondido.Text = evento.titulo;
                    txtDescricaoEventoNaoRespondido.Text = evento.descricao;
                    imgEventoNaoRespondido.Visibility = Visibility.Visible;
                    txtTituloEventoNaoRespondido.Visibility = Visibility.Visible;
                    txtDescricaoEventoNaoRespondido.Visibility = Visibility.Visible;
                }
                else if (evento != null && respondeuEvento == true)
                {
                    txtTituloEventoRespondido.Text = evento.titulo;
                    txtDescricaoEventoRespondido.Text = evento.descricao;
                    imgEventoRespondido.Visibility = Visibility.Visible;
                    txtTituloEventoRespondido.Visibility = Visibility.Visible;
                    txtDescricaoEventoRespondido.Visibility = Visibility.Visible;
                }
                else
                {
                    txtNenhumEventoEncontrado.Visibility = Visibility.Visible;
                }
            }
        }
        private void PressionarBtnTelaInicial(object sender, MouseButtonEventArgs e)
        {
            frmMenu frmMenu = new frmMenu(usuario, evento, respondeuEvento);
            frmMenu.Show();
            Close();
        }
        private void PressionarBtnReportarEvento(object sender, MouseButtonEventArgs e)
        {
            frmReportagemDeEvento frmReportagemDeEvento = new frmReportagemDeEvento(usuario);
            frmReportagemDeEvento.Show();
            Close();
        }
        private void PressionarBtnPerfil(object sender, MouseButtonEventArgs e)
        {
            frmPerfil frmPerfil = new frmPerfil(usuario, evento, respondeuEvento);
            frmPerfil.Show();
            Close();
        }
        private void PressionarBtnConfiguracoes(object sender, MouseButtonEventArgs e)
        {
            frmConfiguracoes frmConfiguracoes = new frmConfiguracoes(usuario, evento, respondeuEvento);
            frmConfiguracoes.Show();
            Close();
        }
        private void PressionarBtnPesquisarEvento(object sender, MouseButtonEventArgs e)
        {
            PesquisarEvento();
        }
    }
}
