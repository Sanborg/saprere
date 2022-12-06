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
    /// Lógica interna para frmCadastroUsuarioContribuinte.xaml
    /// </summary>
    public partial class frmCadastroUsuarioContribuinte : Window
    {
        public Usuario usuario { get; }
        public frmCadastroUsuarioContribuinte()
        {
            InitializeComponent();
        }
        public frmCadastroUsuarioContribuinte(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        private bool VerificaCampos()
        {
            if (boxIdade.Text != "" && boxCpf.Text != "" && boxTelefone.Text != "" && boxCursoDeGraduacao.Text != "" && boxInstituicaoEnsinoSuperior.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void TornarContribuinte()
        {
            bool tornouContribuinte = cUsuario.TornarContribuinte(usuario.id, boxCpf.Text, int.Parse(boxIdade.Text), boxTelefone.Text, boxCursoDeGraduacao.Text, boxInstituicaoEnsinoSuperior.Text);
            if(tornouContribuinte == true)
            {
                frmMenu frmMenu = new frmMenu(usuario);
                frmMenu.Show();
                Close();
            }
        }
    }
}
