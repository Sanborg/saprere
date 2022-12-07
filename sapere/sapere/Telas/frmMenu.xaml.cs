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

        public frmMenu()
        {
            InitializeComponent();

        }
        public frmMenu(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        private void PressionarBtnReportarEvento(object sender, MouseButtonEventArgs e)
        {
            frmReportagemDeEvento frmReportagemDeEvento = new frmReportagemDeEvento(usuario);
            frmReportagemDeEvento.Show();
            Close();
        }

        private void PressionarBtnMenu(object sender, MouseButtonEventArgs e)
        {
            frmMenu frmMenu = new frmMenu(usuario);
            frmMenu.Show();
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
        public void CumprimentarUsuario()
        {
            txtCumprimento.Text = $"Olá, {usuario.nome}!";
        }
    }
}
