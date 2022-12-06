﻿using System;
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
    /// Lógica interna para frmLogin.xaml
    /// </summary>
    public partial class frmLogin : Window
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void CriarConta(object sender, MouseButtonEventArgs e)
        {
            frmCadastroUsuarioComum frmCadastroUsuarioComum = new frmCadastroUsuarioComum();
            frmCadastroUsuarioComum.Show();
            Close();
        }
        private void RealizarLogin(object sender, MouseButtonEventArgs e)
        {
            if (VerificaCampos() == true)
            {
                string email = boxEmail.Text;
                string senha = boxSenha.Password;
                Login(email, senha);

            }
        }

        private void EsqueceuSenhaUsuario(object sender, MouseButtonEventArgs e)
        {
            frmEsqueceuSenha frmEsqueceuSenha = new frmEsqueceuSenha();
            frmEsqueceuSenha.Show();
            Close();
        }

        private bool VerificaCampos()
        {
            if (boxEmail.Text != "" && boxSenha.Password != "")
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
        public void Login(string email, string senha)
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
                    Usuario usuario = cUsuario.BuscarDadosUsuario(email, senha);
                    if (usuario != null)
                    {
                        frmMenu frmMenu = new frmMenu(usuario);
                        frmMenu.Show();
                        Close();
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show(
                        "Usuário não encontrado.",
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
        private void PressionarEsqueceuSenha(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
