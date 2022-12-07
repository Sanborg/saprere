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
    /// Lógica interna para frmReportagemDeEvento.xaml
    /// </summary>
    public partial class frmReportagemDeEvento : Window
    {
        public Usuario usuario { get; }
        public frmReportagemDeEvento()
        {
            InitializeComponent();
        }
        public frmReportagemDeEvento(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
    }
}
