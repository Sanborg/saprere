using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
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
    /// Lógica interna para frmVisualizacaoEventoNaoRespondido.xaml
    /// </summary>
    public partial class frmVisualizacaoEventoNaoRespondido : Window
    {
        public Usuario usuario { get; }
        public Evento evento { get; }
        bool alternarPlayPauseVideo = false;
        bool alternarPlayPauseAudio = false;
        public frmVisualizacaoEventoNaoRespondido()
        {
            InitializeComponent();
        }
        public frmVisualizacaoEventoNaoRespondido(Usuario usuario, Evento evento)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.evento = evento;
        }
        public void AjustarEvento()
        {
            txtTituloEventoNaoRespondido.Text = evento.titulo;
            txtDescricaoEvento.Text = evento.descricao;
            txtLocalizacaoEData.Text = $"{evento.localDeVisualizacao}\n{evento.dataHoraVisualizacao}";
            if(usuario.tipoUsuario == "comum")
            {
                btnResponder.IsHitTestVisible = false;
            }
        }
        private void PlayVideo()
        {
            if(alternarPlayPauseVideo == false)
            {
                vidEvento.Play();
                alternarPlayPauseVideo = true;
            }
            else if(alternarPlayPauseVideo == true)
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
        private void PressionarBtnResponder(object sender, MouseButtonEventArgs e)
        {
            frmRespostaDeEvento frmRespostaDeEvento = new frmRespostaDeEvento(usuario, evento);
            frmRespostaDeEvento.Show();
            Close();
        }

        private void PressionarBtnVoltar(object sender, MouseButtonEventArgs e)
        {
            frmMenu frmMenu = new frmMenu(usuario, evento, false);
            frmMenu.Show();
            Close();
        }

        private void PressionarBtnReportarEvento(object sender, MouseButtonEventArgs e)
        {
            frmReportagemDeEvento frmReportagemDeEvento = new frmReportagemDeEvento(usuario);
            frmReportagemDeEvento.Show();
            Close();
        }

        private void PressionarBtnTelaInicial(object sender, MouseButtonEventArgs e)
        {
            frmMenu frmMenu = new frmMenu(usuario, evento, false);
            frmMenu.Show();
            Close();
        }

        private void PressionarBtnPerfil(object sender, MouseButtonEventArgs e)
        {
            frmPerfil frmPerfil = new frmPerfil(usuario);
            frmPerfil.Show();
            Close();
        }

        private void PressionarBtnConfiguracoes(object sender, MouseButtonEventArgs e)
        {
            frmConfiguracoes frmConfiguracoes = new frmConfiguracoes(usuario);
            frmConfiguracoes.Show();
            Close();
        }

        private void PressionarBtnPesquisarEvento(object sender, MouseButtonEventArgs e)
        {
            frmPesquisaDeEvento frmPesquisaDeEvento = new frmPesquisaDeEvento(usuario);
            frmPesquisaDeEvento.Show();
            Close();
        }
    }
}
