﻿#pragma checksum "..\..\..\frmLogin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "659A0E4718CB5A78CFA1240757A8B168D380A882"
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
        
        
        #line 15 "..\..\..\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btnTornarContribuidor;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox boxEmailUsuarioLogin;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnLogin;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtEsqueceuSenhaLogin;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnCriarConta;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox boxSenhaLogin;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/sapere.View;V1.0.0.0;component/frmlogin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\frmLogin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnTornarContribuidor = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.boxEmailUsuarioLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnLogin = ((System.Windows.Controls.TextBlock)(target));
            
            #line 22 "..\..\..\frmLogin.xaml"
            this.btnLogin.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.RealizarLogin);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtEsqueceuSenhaLogin = ((System.Windows.Controls.TextBlock)(target));
            
            #line 23 "..\..\..\frmLogin.xaml"
            this.txtEsqueceuSenhaLogin.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PressionarEsqueceuSenha);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCriarConta = ((System.Windows.Controls.TextBlock)(target));
            
            #line 24 "..\..\..\frmLogin.xaml"
            this.btnCriarConta.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CriarConta);
            
            #line default
            #line hidden
            return;
            case 6:
            this.boxSenhaLogin = ((System.Windows.Controls.PasswordBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

