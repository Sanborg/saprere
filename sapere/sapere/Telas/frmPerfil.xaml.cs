using Microsoft.Win32;
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
    /// Lógica interna para frmPerfil.xaml
    /// </summary>
    public partial class frmPerfil : Window
    {
        public Usuario usuario { get; }
        public Evento evento { get; }
        public  bool respondeuEvento { get; }
        bool pressionouAnexarImagem = false;
        public frmPerfil()
        {
            InitializeComponent();
        }
        public frmPerfil(Usuario usuario, Evento evento, bool respondeuEvento)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.evento = evento;
            this.respondeuEvento = respondeuEvento;
        }
        public void AjustarCampos()
        {
            txtNomeUsuario.Text = usuario.nome;
            if(usuario.descricao != null)
            {
                boxDescricao.Text = usuario.descricao;
            }
        }
        private bool VerificaCampo()
        {
            if (boxDescricao.Text != "")
            {
                return true;
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                "Preencha o campo de descrição para enviá-la",
                "Atenção",
                MessageBoxButton.OK,
                MessageBoxImage.Warning
                );
                return false;
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
            imgFotoPerfil.Visibility = Visibility.Visible;
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
        private void PressionarBtnConfiguracoes(object sender, MouseButtonEventArgs e)
        {
            frmConfiguracoes frmConfiguracoes = new frmConfiguracoes(usuario, evento, respondeuEvento);
            frmConfiguracoes.Show();
            Close();
        }
        private void PressionarBtnPesquisarEvento(object sender, MouseButtonEventArgs e)
        {
            frmPesquisaDeEvento frmPesquisaDeEvento = new frmPesquisaDeEvento(usuario, evento, respondeuEvento);
            frmPesquisaDeEvento.Show();
            Close();
        }
        private void PressionarBtnSalvarDescricao(object sender, MouseButtonEventArgs e)
        {
            if(VerificaCampo() == true)
            {
                bool foiInserido = cUsuario.InserirDescricao(usuario.id, boxDescricao.Text);
                if(foiInserido == false)
                {
                    MessageBoxResult result = MessageBox.Show(
                    "Não foi possível inserir descrição. Tente novamente mais tarde.",
                    "Erro",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                    );
                }
            }
        }
        private void PressionarCampoDescricao(object sender, MouseButtonEventArgs e)
        {
            btnSalvarDescricao.Visibility = Visibility.Visible;
        }
        private void PressionarBtnEditarPerfil(object sender, MouseButtonEventArgs e)
        {

            frmEdicaoDePerfil frmEdicaoDePerfil = new frmEdicaoDePerfil(usuario, evento, respondeuEvento);
            frmEdicaoDePerfil.Show();
            Close();
        }
    }
}
