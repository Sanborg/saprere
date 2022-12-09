using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Lógica interna para frmReportagemDeEvento.xaml
    /// </summary>
    public partial class frmReportagemDeEvento : Window
    {
        public Usuario usuario { get; }
        bool pressionouAnexarImagem = false;
        bool pressionouAnexarVideo= false;
        bool pressionouAnexarAudio = false;
        public frmReportagemDeEvento()
        {
            InitializeComponent();
            IncluiItensComboBox();
        }
        public frmReportagemDeEvento(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        private void IncluiItensComboBox()
        {
            comEscopoDoEvento.Items.Add("Planta");
            comEscopoDoEvento.Items.Add("Animal");
            comEscopoDoEvento.Items.Add("Fungo");
            comEscopoDoEvento.Items.Add("Fenômeno meteorológico");
            comEscopoDoEvento.Items.Add("Fenômeno geológico");
            comEscopoDoEvento.Items.Add("Fenômeno físico");
            comEscopoDoEvento.Items.Add("Fenômeno químico");
        }
        private bool VerificaCampos()
        {
            if (boxTitulo.Text != "" && boxDescricao.Text != "" && boxHora.Text != "" && boxData.Text != "")
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
        private void VerificaAnexos()
        {
            if (pressionouAnexarImagem == true)
            {
                imgFotoEnviada.Visibility = Visibility.Visible;
                btnAdicionarFoto.IsHitTestVisible = false;
            }
            if (pressionouAnexarVideo == true)
            {
                imgVideoEnviado.Visibility = Visibility.Visible;
                btnAdicionarVideo.IsHitTestVisible = false;
            }
            if (pressionouAnexarAudio == true)
            {
                imgAudioEnviado.Visibility = Visibility.Visible;
                btnAdicionarAudio.IsHitTestVisible = false;
            }
        }
        public void ReportarEvento(string titulo, string descricao, string escopoDoEvento, string localDeVisualizacao, DateTime dataHoraVisualizacao)
        {
            bool foiReportado = cEvento.CriarEvento(usuario.id, titulo, descricao, escopoDoEvento, localDeVisualizacao, dataHoraVisualizacao);
            if (foiReportado == true)
            {
                Evento evento = cEvento.BuscarEvento(titulo);
                frmMenu frmMenu = new frmMenu(usuario, evento, false);
                frmMenu.Show();
                Close();
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                "Não foi possível reportar o evento. Tente novamente mais tarde.",
                "Erro",
                MessageBoxButton.OK,
                MessageBoxImage.Error
                );
            }
        }
        private void CriarEvento(object sender, MouseButtonEventArgs e)
        {
            if (VerificaCampos() == true)
            {
                if (DateTime.TryParse(boxData.Text, out var dataVisualizacao) && DateTime.TryParse(boxHora.Text, out var horarioVisualizacao))
                {
                    string dataHoraTexto = $"{boxData.Text} {boxHora.Text}";
                    DateTime dataHoraDatetime = DateTime.ParseExact(dataHoraTexto, "G", CultureInfo.CreateSpecificCulture("pt-BR"));
                    ReportarEvento(boxTitulo.Text, boxDescricao.Text, comEscopoDoEvento.SelectedItem.ToString(), boxLocalDeVisualizacao.Text, dataHoraDatetime);
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show(
                    "Campo Data ou Hora não preenchido corretamente." +
                    " O campo data não deve conter espaços, com dia, mês e ano separados por '/'." +
                    " O campo hora não deve conter espaços, com hora, minuto e segundo separado por ':'.",
                    "Erro",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                    );
                }
            }
        }
        private void SimularAnexarImagem(object sender, MouseButtonEventArgs e)
        {
            if (pressionouAnexarImagem == false)
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
                if (opf.ShowDialog() == DialogResult.HasValue)
                {

                }
            }
            pressionouAnexarImagem = true;
            VerificaAnexos();
        }
        private void SimularAnexarVideo(object sender, MouseButtonEventArgs e)
        {
            if (pressionouAnexarVideo == false)
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Choose Image(*.mp4; *.avi; *.mov)|*.mp4; *.avi; *.mov";
                if (opf.ShowDialog() == DialogResult.HasValue)
                {

                }
                pressionouAnexarVideo = true;
                VerificaAnexos();
            }

        }
        private void SimularAnexarAudio(object sender, MouseButtonEventArgs e)
        {
            if (pressionouAnexarAudio == false)
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Choose Image(*.mp3; *.wav; *.flac)|*.mp3; *.wav; *.flac";
                if (opf.ShowDialog() == DialogResult.HasValue)
                {

                }
                pressionouAnexarAudio= true;
                VerificaAnexos();
            }
        }
        private void PressionarBtnVoltar(object sender, MouseButtonEventArgs e)
        {
            frmMenu frmMenu = new frmMenu(usuario, null, false);
            frmMenu.Show();
            Close();
        }
    }
}
