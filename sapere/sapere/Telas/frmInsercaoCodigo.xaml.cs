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
    /// Lógica interna para frmInsercaoCodigo.xaml
    /// </summary>
    public partial class frmInsercaoCodigo : Window
    {
        public Evento evento { get; }
        public bool respondeuEvento { get; }
        public string email { get; }
        public int codigo { get; }
        public frmInsercaoCodigo()
        {
            InitializeComponent();
        }
        public frmInsercaoCodigo(Evento evento, bool respondeuEvento, string email, int codigo)
        {
            InitializeComponent();
            this.evento = evento;
            this.respondeuEvento = respondeuEvento;
            this.email = email;
            this.codigo = codigo;
        }
        public void ValidarCodigo()
        {
            if(boxCodigoDeRecuperacao.Text != "")
            {
                if(codigo == int.Parse(boxCodigoDeRecuperacao.Text))
                {
                    frmAlteracaoDeSenha frmAlteracaoDeSenha = new frmAlteracaoDeSenha(evento, respondeuEvento, email);
                    frmAlteracaoDeSenha.Show();
                    Close();
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show(
                    "Código não validado",
                    "Erro",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                    );
                    frmEsqueceuSenha frmEsqueceuSenha = new frmEsqueceuSenha();
                    frmEsqueceuSenha.Show();
                    Close();
                }
            }
        }
        private void PressionarBtnOk(object sender, MouseButtonEventArgs e)
        {
            ValidarCodigo();
        }
    }
}
