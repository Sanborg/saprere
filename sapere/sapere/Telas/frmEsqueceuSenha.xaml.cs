using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
    /// Lógica interna para frmEsqueceuSenha.xaml
    /// </summary>
    public partial class frmEsqueceuSenha : Window
    {
        public frmEsqueceuSenha()
        {
            InitializeComponent();
        }
        public void EnviarEmailRecuperacao(string email)
        {
            if (boxEmail.Text != "")
            {
                bool emailExiste = cUsuario.VerificaExistenciaEmail(email);
                if(emailExiste == true)
                {
                    bool ponto = false;
                    bool arroba = false;
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
                    if (arroba == true && ponto == true)
                    {
                        Random random = new Random();
                        int codigo = random.Next(100000, 999999);
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("sapere@gmail.com");
                        mail.To.Add(email);
                        mail.Subject = "Recuperação de senha";
                        mail.Body = $"O seu código de recuperação de conta é {codigo}. Insira-o no campo apropriado do aplicativo.";
                        SmtpClient smpt = new SmtpClient("smpt@gmail.com");
                        smpt.Send(mail);
                        frmInsercaoCodigo frmInsercaoCodigo = new frmInsercaoCodigo(email, codigo);
                        frmInsercaoCodigo.Show();
                        Close();
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
                    "Email não cadastrado.",
                    "Infomação",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                    );
                }
            }
        }
        private void PressionarBtnEnviarEmail(object sender, MouseButtonEventArgs e)
        {
            EnviarEmailRecuperacao(boxEmail.Text);
        }

        private void PressionarBtnVoltar(object sender, MouseButtonEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            Close();
        }
    }
}
