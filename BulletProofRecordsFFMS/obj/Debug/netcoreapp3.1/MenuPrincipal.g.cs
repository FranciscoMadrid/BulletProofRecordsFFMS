﻿#pragma checksum "..\..\..\MenuPrincipal.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F100D998089439104BA7444C15A9CD4ABF186D15"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BulletProofRecordsFFMS;
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


namespace BulletProofRecordsFFMS {
    
    
    /// <summary>
    /// MenuPrincipal
    /// </summary>
    public partial class MenuPrincipal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancion;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAlbum;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnArtista;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReporte;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalir;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BulletProofRecordsFFMS;component/menuprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MenuPrincipal.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnCancion = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\MenuPrincipal.xaml"
            this.btnCancion.Click += new System.Windows.RoutedEventHandler(this.btnCancion_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnAlbum = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\MenuPrincipal.xaml"
            this.btnAlbum.Click += new System.Windows.RoutedEventHandler(this.btnAlbum_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnArtista = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\MenuPrincipal.xaml"
            this.btnArtista.Click += new System.Windows.RoutedEventHandler(this.btnArtista_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnReporte = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\MenuPrincipal.xaml"
            this.btnReporte.Click += new System.Windows.RoutedEventHandler(this.btnReporte_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnSalir = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\MenuPrincipal.xaml"
            this.btnSalir.Click += new System.Windows.RoutedEventHandler(this.btnSalir_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

