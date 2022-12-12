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
    /// Lógica interna para frmVisualizacaoEventoRespondidoParte1.xaml
    /// </summary>
    public partial class frmVisualizacaoEventoRespondidoParte1 : Window
    {
        public Usuario usuario { get; }
        public Evento evento { get; }
        public bool respondeuEvento { get; }
        bool alternarPlayPauseVideo = false;
        bool alternarPlayPauseAudio = false;
        public frmVisualizacaoEventoRespondidoParte1()
        {
            InitializeComponent();
        }
        public frmVisualizacaoEventoRespondidoParte1(Usuario usuario, Evento evento,bool respondeuEvento)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.evento = evento;
            this.respondeuEvento = respondeuEvento;
        }
        public void AjustarEvento()
        {
            txtTituloEventoRespondido.Text = evento.titulo;
            txtDescricaoEvento.Text = evento.descricao;
            txtLocalizacaoEData.Text = $"{evento.localDeVisualizacao}\n{evento.dataHoraVisualizacao}";
        }
        private void PlayVideo()
        {
            if (alternarPlayPauseVideo == false)
            {
                vidEvento.Play();
                alternarPlayPauseVideo = true;
            }
            else if (alternarPlayPauseVideo == true)
            {
                vidEvento.Pause();
                alternarPlayPauseVideo = false;
            }

        }
        private void PlayAudio()
        {
            if (alternarPlayPauseAudio == false)
            {
                audEvento.Play();
                alternarPlayPauseAudio = true;
            }
            else if (alternarPlayPauseAudio == true)
            {
                audEvento.Pause();
                alternarPlayPauseAudio = false;
            }
        }
        private void PressionarBtnPlayPauseAudio(object sender, MouseButtonEventArgs e)
        {
            PlayAudio();
        }
        private void PressionarBtnPlayPauseVideo(object sender, MouseButtonEventArgs e)
        {
            PlayVideo();
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
        private void PressionarBtnDescer(object sender, MouseButtonEventArgs e)
        {
            frmVisualizacaoEventoRespondidoParte2 frmVisualizacaoEventoRespondidoParte2 = new frmVisualizacaoEventoRespondidoParte2(usuario, evento, respondeuEvento);
            frmVisualizacaoEventoRespondidoParte2.Show();
            Close();
        }
    }
}
