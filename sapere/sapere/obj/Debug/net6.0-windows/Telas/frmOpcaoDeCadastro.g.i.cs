﻿#pragma checksum "..\..\..\..\Telas\frmOpcaoDeCadastro.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B499DA7D14C01FDED582789CA53E6260AF86EE76"
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
    /// frmOpcaoDeCadastro
    /// </summary>
    public partial class frmOpcaoDeCadastro : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Telas\frmOpcaoDeCadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgFundoOpcaoDeCadastro;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Telas\frmOpcaoDeCadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnTornarContribuidor;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Telas\frmOpcaoDeCadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnNaoTornarContribuidor;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Telas\frmOpcaoDeCadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtInformacaoOpcoes;
        
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
            System.Uri resourceLocater = new System.Uri("/sapere.View;V1.0.0.0;component/telas/frmopcaodecadastro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Telas\frmOpcaoDeCadastro.xaml"
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
            this.imgFundoOpcaoDeCadastro = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.btnTornarContribuidor = ((System.Windows.Controls.TextBlock)(target));
            
            #line 14 "..\..\..\..\Telas\frmOpcaoDeCadastro.xaml"
            this.btnTornarContribuidor.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PressionarBotaoTornarContribuinte);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnNaoTornarContribuidor = ((System.Windows.Controls.TextBlock)(target));
            
            #line 15 "..\..\..\..\Telas\frmOpcaoDeCadastro.xaml"
            this.btnNaoTornarContribuidor.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PressionarBotaoNaoTornarContribuinte);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtInformacaoOpcoes = ((System.Windows.Controls.TextBlock)(target));
            
            #line 16 "..\..\..\..\Telas\frmOpcaoDeCadastro.xaml"
            this.txtInformacaoOpcoes.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PressionarEsqueceuSenha);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

