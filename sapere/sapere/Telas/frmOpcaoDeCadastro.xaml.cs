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
    /// Lógica interna para frmOpcaoDeCadastro.xaml
    /// </summary>
    public partial class frmOpcaoDeCadastro : Window
    {
        public Usuario usuario { get; }
        public Evento evento { get; }
        public bool respondeuEvento { get; }
        public frmOpcaoDeCadastro()
        {
            InitializeComponent();
        }
        public frmOpcaoDeCadastro(Usuario usuario, Evento evento, bool respondeuEvento)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.evento = evento;
            this.respondeuEvento = respondeuEvento;
        }
        private void PressionarBotaoTornarContribuinte(object sender, MouseButtonEventArgs e)
        {
            frmCadastroUsuarioContribuinte frmCadastroUsuarioContribuinte = new frmCadastroUsuarioContribuinte(usuario, evento, respondeuEvento);
            frmCadastroUsuarioContribuinte.Show();
            Close();
        }

        private void PressionarBotaoNaoTornarContribuinte(object sender, MouseButtonEventArgs e)
        {
            frmMenu frmMenu = new frmMenu(usuario, null, false);
            frmMenu.Show();
            Close();
        }
    }
}
