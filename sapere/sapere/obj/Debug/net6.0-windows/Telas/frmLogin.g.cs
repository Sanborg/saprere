﻿#pragma checksum "..\..\..\..\Telas\frmLogin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04418E42C940A5B793A26DF53F4E8FD7257C8857"
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
    /// frmLogin
    /// </summary>
    public partial class frmLogin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Telas\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgFundoLogin;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Telas\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox boxEmail;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Telas\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnLogin;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Telas\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnEsqueceuSenha;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Telas\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnCriarConta;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Telas\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox boxSenha;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Telas\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBoasVindas;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/sapere.View;component/telas/frmlogin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Telas\frmLogin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.imgFundoLogin = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.boxEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnLogin = ((System.Windows.Controls.TextBlock)(target));
            
            #line 14 "..\..\..\..\Telas\frmLogin.xaml"
            this.btnLogin.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.RealizarLogin);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnEsqueceuSenha = ((System.Windows.Controls.TextBlock)(target));
            
            #line 15 "..\..\..\..\Telas\frmLogin.xaml"
            this.btnEsqueceuSenha.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PressionarEsqueceuSenha);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCriarConta = ((System.Windows.Controls.TextBlock)(target));
            
            #line 16 "..\..\..\..\Telas\frmLogin.xaml"
            this.btnCriarConta.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CriarConta);
            
            #line default
            #line hidden
            return;
            case 6:
            this.boxSenha = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.txtBoasVindas = ((System.Windows.Controls.TextBlock)(target));
            
            #line 18 "..\..\..\..\Telas\frmLogin.xaml"
            this.txtBoasVindas.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PressionarEsqueceuSenha);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

