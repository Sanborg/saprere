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
                MessageBoxResult result = MessageBox.Show(
                "Preencha todos os campos",
                "Atenção",
                MessageBoxButton.OK,
                MessageBoxImage.Warning
                );
                return false;
            }
        }
        private void CadastrarUsuario(string email, string senha)
        {
            if (VerificaCampos() == true)
            {
                if(boxSenha.Password == boxConfirmaSenha.Password)
                {
                    int tamanhoSenha = senha.Length;
                    bool caractereEspecial = false;
                    bool caractereNumerico = false;
                    bool caractereAlfabeticoMaiusculo = false;
                    bool caractereAlfabeticoMinusculo = false;
                    bool ponto = false;
                    bool arroba = false;

                    foreach (char i in senha)
                    {
                        if (Char.IsNumber(i) == true)
                        {
                            caractereNumerico = true;
                        }
                        else if (Char.IsLetter(i) == true)
                        {
                            if (Char.IsUpper(i) == true)
                            {
                                caractereAlfabeticoMaiusculo = true;
                            }
                            else if (Char.IsLower(i) == true)
                            {
                                caractereAlfabeticoMinusculo = true;
                            }
                        }
                        else if (i.ToString() == "%" || i.ToString() == "$" || i.ToString() == "#" || i.ToString() == "@")
                        {
                            caractereEspecial = true;
                        }
                    }
                    foreach (char i in email)
                    {
                        if (i.ToString() == "@")
                        {
                            arroba = true;
                        }
                        else if (i.ToString() == ".")
                        {
                            ponto = true;
                        }
                    }
                    if (caractereNumerico == true && caractereEspecial == true && caractereAlfabeticoMaiusculo == true && caractereAlfabeticoMinusculo == true && tamanhoSenha >= 8)
                    {
                        if (arroba == true && ponto == true)
                        {
                            bool foiInserido = cUsuario.CadastrarUsuario(boxNome.Text, boxEmail.Text, boxSenha.Password);
                            Usuario usuario = cUsuario.BuscarDadosUsuario(boxEmail.Text, boxSenha.Password);
                            if (foiInserido == true && usuario != null)
                            {
                                frmOpcaoDeCadastro frmOpcaoDeCadastro = new frmOpcaoDeCadastro(usuario, null, false);
                                frmOpcaoDeCadastro.Show();
                                Close();
                            }
                            else
                            {
                                MessageBoxResult result = MessageBox.Show(
                                "Não foi possível criar o usuário",
                                "Erro",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error
                                );
                            }
                        }
                        else
                        {
                            MessageBoxResult result = MessageBox.Show(
                            "Email invalido.",
                            "Infomação",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning
                            );
                        }
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show(
                        "Senha Invalida. A senha deve conter caracteres maiúsculos, minúsculos, numéricos e especiais (@, #, % ou $), além de no minimo 8 caracteres.",
                        "Informação",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning
                        );
                    }
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show(
                    "Os campos Senha e Confirma Senha não possuem o mesmo conteúdo",
                    "Infomação",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                    );
                }
            }
        }
        private void PressionarBtnCadastrarUsuario(object sender, MouseButtonEventArgs e)
        {
            CadastrarUsuario(boxEmail.Text, boxSenha.Password);
        }
        private void PressionarBtnVoltar(object sender, MouseButtonEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            Close();
        }
    }
}

