﻿#pragma checksum "..\..\..\..\Telas\frmConfiguracoes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B38AE2A11EBFC51F6E08D5ECF52AA75924073CAA"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using sapere.View;


namespace sapere.View {
    
    
    /// <summary>
    /// frmConfiguracoes
    /// </summary>
    public partial class frmConfiguracoes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Telas\frmConfiguracoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgFundoConfiguracoes;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Telas\frmConfiguracoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnTrocarUsuario;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Telas\frmConfiguracoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnAlterarSenha;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Telas\frmConfiguracoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnExcluirConta;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Telas\frmConfiguracoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnTornarContribuidor;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Telas\frmConfiguracoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnVoltar;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Telas\frmConfiguracoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtConfiguracoes;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/sapere.View;component/telas/frmconfiguracoes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Telas\frmConfiguracoes.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.imgFundoConfiguracoes = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.btnTrocarUsuario = ((System.Windows.Controls.TextBlock)(target));
            
            #line 23 "..\..\..\..\Telas\frmConfiguracoes.xaml"
            this.btnTrocarUsuario.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PressionarBtnTrocarUsuario);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnAlterarSenha = ((System.Windows.Controls.TextBlock)(target));
            
            #line 24 "..\..\..\..\Telas\frmConfiguracoes.xaml"
            this.btnAlterarSenha.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PressionarBtnAlterarSenha);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnExcluirConta = ((System.Windows.Controls.TextBlock)(target));
            
            #line 25 "..\..\..\..\Telas\frmConfiguracoes.xaml"
            this.btnExcluirConta.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PressionarBtnExcluirConta);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnTornarContribuidor = ((System.Windows.Controls.TextBlock)(target));
            
            #line 26 "..\..\..\..\Telas\frmConfiguracoes.xaml"
            this.btnTornarContribuidor.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PressionarTornarContribuinte);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnVoltar = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txtConfiguracoes = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

