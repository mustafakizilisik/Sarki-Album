﻿#pragma checksum "..\..\..\Pages\KayıtAlbümŞarkı.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BE9886EC63ED9821D606D91EB9C86911E67EF24EB4901096D9289EDAEF8A0BA6"
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
using _76.Pages;


namespace _76.Pages {
    
    
    /// <summary>
    /// KayıtAlbümŞarkı
    /// </summary>
    public partial class KayıtAlbümŞarkı : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Pages\KayıtAlbümŞarkı.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbŞarkıUzunluğu;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\KayıtAlbümŞarkı.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbŞarkıAdı;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\KayıtAlbümŞarkı.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbAlbümAdı;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\KayıtAlbümŞarkı.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnKaydet;
        
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
            System.Uri resourceLocater = new System.Uri("/76;component/pages/kay%c4%b1talb%c3%bcm%c5%9eark%c4%b1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\KayıtAlbümŞarkı.xaml"
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
            this.tbŞarkıUzunluğu = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cbŞarkıAdı = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.cbAlbümAdı = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.btnKaydet = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Pages\KayıtAlbümŞarkı.xaml"
            this.btnKaydet.Click += new System.Windows.RoutedEventHandler(this.btnKaydet_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

