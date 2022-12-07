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
    /// Lógica interna para frmPerfil.xaml
    /// </summary>
    public partial class frmPerfil : Window
    {
        public Usuario usuario { get; }
        public frmPerfil()
        {
            InitializeComponent();
        }
        public frmPerfil(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
    }
}
