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
    /// Lógica interna para frmCadastroUsuarioComum.xaml
    /// </summary>
    public partial class frmCadastroUsuarioComum : Window
    {
        public frmCadastroUsuarioComum()
        {
            InitializeComponent();
        }
        private bool VerificaCampos()
        {
            if (boxNome.Text != "" && boxEmail.Text != "" && boxSenha.Password != "" && boxConfirmaSenha.Password != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CadastrarUsuario(object sender, MouseButtonEventArgs e)
        {
            if(VerificaCampos() == true)
            {
                bool foiInserido = cUsuario.CadastrarUsuario(boxNome.Text, boxSenha.Password);
                if (foiInserido == true)
                {
                    frmOpcaoDeCadastro frmOpcaoDeCadastro = new frmOpcaoDeCadastro();
                    frmOpcaoDeCadastro.Show();
                    Close();
                }
            }
        }
    }

}
