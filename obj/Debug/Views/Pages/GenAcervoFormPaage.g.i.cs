﻿#pragma checksum "..\..\..\..\Views\Pages\GenAcervoFormPaage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0832C1B0B36C1B8FE2C1649B27C651208748F7C4660605E50F248C37F56B84D3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using System_Biblioteca.Views.Pages;


namespace System_Biblioteca.Views.Pages {
    
    
    /// <summary>
    /// GenAcervoFormPaage
    /// </summary>
    public partial class GenAcervoFormPaage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\..\Views\Pages\GenAcervoFormPaage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbmLivro;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Views\Pages\GenAcervoFormPaage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPesquisar;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Views\Pages\GenAcervoFormPaage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridLivros;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Views\Pages\GenAcervoFormPaage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgPerfil;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\Views\Pages\GenAcervoFormPaage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditarLivro;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\Views\Pages\GenAcervoFormPaage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExcluirLivro;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/System-Biblioteca;component/views/pages/genacervoformpaage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Pages\GenAcervoFormPaage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.cbmLivro = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.btnPesquisar = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.dataGridLivros = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.imgPerfil = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.btnEditarLivro = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\..\Views\Pages\GenAcervoFormPaage.xaml"
            this.btnEditarLivro.Click += new System.Windows.RoutedEventHandler(this.btnEditarLivro_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnExcluirLivro = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\..\..\Views\Pages\GenAcervoFormPaage.xaml"
            this.btnExcluirLivro.Click += new System.Windows.RoutedEventHandler(this.btnExcluirLivro_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

