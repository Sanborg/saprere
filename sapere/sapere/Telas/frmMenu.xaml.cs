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
    /// Lógica interna para frmMenu.xaml
    /// </summary>
    public partial class frmMenu : Window
    {
        public Usuario usuario { get; }
        public Evento evento { get; }
        public bool respondeuEvento { get; }
        public frmMenu()
        {
            InitializeComponent();
        }
        public frmMenu(Usuario usuario, Evento evento, bool respondeuEvento)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.evento = evento;
            this.respondeuEvento = respondeuEvento;
            if (evento != null && respondeuEvento == false)
            {
                txtTituloEventoNaoRespondido.Text = evento.titulo;
                txtDescricaoEventoNaoRespondido.Text = evento.descricao;
                imgEventoNaoRespondido.Visibility = Visibility.Visible;
                txtTituloEventoNaoRespondido.Visibility = Visibility.Visible;
                txtDescricaoEventoNaoRespondido.Visibility = Visibility.Visible;
            }
            else if(evento != null && respondeuEvento == true)
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
        private void PressionarBtnReportarEvento(object sender, MouseButtonEventArgs e)
        {
            frmReportagemDeEvento frmReportagemDeEvento = new frmReportagemDeEvento(usuario);
            frmReportagemDeEvento.Show();
            Close();
        }
        private void PressionarBtnPesquisarEvento(object sender, MouseButtonEventArgs e)
        {
            frmPesquisaDeEvento frmPesquisaDeEvento = new frmPesquisaDeEvento(usuario);
            frmPesquisaDeEvento.Show();
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
            frmConfiguracoes frmConfiguracoes = new frmConfiguracoes(usuario);
            frmConfiguracoes.Show();
            Close();
        }
        public void CumprimentarUsuario()
        {
            txtCumprimento.Text = $"Olá, {usuario.nome}!";
        }
        private void PressionarEventoNaoRespondido(object sender, MouseButtonEventArgs e)
        {
            frmVisualizacaoEventoNaoRespondido frmVisualizacaoEventoNaoRespondido = new frmVisualizacaoEventoNaoRespondido(usuario, evento);
            frmVisualizacaoEventoNaoRespondido.Show();
            Close();
        }
        private void PressionarEventoRespondido(object sender, MouseButtonEventArgs e)
        {
            frmVisualizacaoEventoRespondidoParte1 frmVisualizacaoEventoRespondidoParte1 = new frmVisualizacaoEventoRespondidoParte1(usuario, evento, respondeuEvento);
            frmVisualizacaoEventoRespondidoParte1.Show();
            Close();
        }
    }
}
