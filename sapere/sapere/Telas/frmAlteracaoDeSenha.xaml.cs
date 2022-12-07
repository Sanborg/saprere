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
    /// Lógica interna para frmAlteracaoDeSenha.xaml
    /// </summary>
    public partial class frmAlteracaoDeSenha : Window
    {
        public string email { get; }
        public frmAlteracaoDeSenha()
        {
            InitializeComponent();
        }
        public frmAlteracaoDeSenha(string email)
        {
            InitializeComponent();
            this.email = email;
        }
        public void AlterarSenha(string senha, string confirmaSenha)
        {
            if(VerificaCampos() == true)
            {
                if (senha == confirmaSenha)
                {
                    int tamanhoSenha = senha.Length;
                    bool caractereEspecial = false;
                    bool caractereNumerico = false;
                    bool caractereAlfabeticoMaiusculo = false;
                    bool caractereAlfabeticoMinusculo = false;
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
                    if (caractereNumerico == true && caractereEspecial == true && caractereAlfabeticoMaiusculo == true && caractereAlfabeticoMinusculo == true && tamanhoSenha >= 8)
                    {
                        bool foiAlterado = cUsuario.AlterarSenha(email, senha);
                        if(foiAlterado == true)
                        {
                            MessageBoxResult result = MessageBox.Show(
                            "Senha alterada com sucesso.",
                            "Informação",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information
                            );
                            frmLogin frmLogin = new frmLogin();
                            frmLogin.Show();
                            Close();
                        }
                        else
                        {
                            MessageBoxResult result = MessageBox.Show(
                            "Não foi possível alterar a senha",
                            "Erro",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error
                            );
                            frmLogin frmLogin = new frmLogin();
                            frmLogin.Show();
                            Close();
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
        public bool VerificaCampos()
        {
            if (boxSenha.Password != "" && boxConfirmaSenha.Password != "")
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
        private void PressionarBtnAlterarSenha(object sender, MouseButtonEventArgs e)
        {
            AlterarSenha(boxSenha.Password, boxConfirmaSenha.Password);
        }
    }
}
