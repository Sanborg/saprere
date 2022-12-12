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
    /// Lógica interna para frmVisualizacaoEventoRespondidoParte2.xaml
    /// </summary>
    public partial class frmVisualizacaoEventoRespondidoParte2 : Window
    {
        public Usuario usuario { get; }
        public Evento evento { get; }
        public bool respondeuEvento { get; }
        bool alternarPlayPauseVideo = false;
        bool alternarPlayPauseAudio = false;
        public frmVisualizacaoEventoRespondidoParte2()
        {
            InitializeComponent();
        }
        public frmVisualizacaoEventoRespondidoParte2(Usuario usuario, Evento evento, bool respondeuEvento)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.evento = evento;
            this.respondeuEvento = respondeuEvento;
        }
        public void AjustarEvento()
        {
            txtResposta.Text = evento.resposta;
            txtLink1.Text = evento.link1;
            txtLink2.Text = evento.link2;
            txtLink3.Text = evento.link3;
        }
        private void PressionarBtnReportarEvento(object sender, MouseButtonEventArgs e)
        {
            frmReportagemDeEvento frmReportagemDeEvento = new frmReportagemDeEvento(usuario);
            frmReportagemDeEvento.Show();
            Close();
        }
        private void PressionarBtnTelaInicial(object sender, MouseButtonEventArgs e)
        {
            frmMenu frmMenu = new frmMenu(usuario, evento, respondeuEvento);
            frmMenu.Show();
            Close();
        }
        private void PressionarBtnPerfil(object sender, MouseButtonEventArgs e)
        {
            frmPerfil frmPerfil = new frmPerfil(usuario, evento);
            frmPerfil.Show();
            Close();
        }
        private void PressionarBtnConfiguracoes(object sender, MouseButtonEventArgs e)
        {
            frmConfiguracoes frmConfiguracoes = new frmConfiguracoes(usuario, evento);
            frmConfiguracoes.Show();
            Close();
        }
        private void PressionarBtnPesquisarEvento(object sender, MouseButtonEventArgs e)
        {
            frmPesquisaDeEvento frmPesquisaDeEvento = new frmPesquisaDeEvento(usuario, evento);
            frmPesquisaDeEvento.Show();
            Close();
        }
        private void PressionarBtnSubir(object sender, MouseButtonEventArgs e)
        {
            frmVisualizacaoEventoRespondidoParte1 frmVisualizacaoEventoRespondidoParte1 = new frmVisualizacaoEventoRespondidoParte1(usuario, evento, respondeuEvento);
            frmVisualizacaoEventoRespondidoParte1.Show();
            Close();
        }
        private void PressionarBtnVoltar(object sender, MouseButtonEventArgs e)
        {
            frmMenu frmMenu = new frmMenu(usuario, evento, respondeuEvento);
            frmMenu.Show();
            Close();
        }
    }
}
