﻿#pragma checksum "..\..\..\Pages\KayıtAlbüm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "715885E02103E463115D3E7C71C9E7685E1416B8D3636BC622BCF80A9F62DC74"
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
    /// KayıtAlbüm
    /// </summary>
    public partial class KayıtAlbüm : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Pages\KayıtAlbüm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbAlbümAd;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\KayıtAlbüm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpAlbümYıl;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\KayıtAlbüm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbKayıtYeri;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\KayıtAlbüm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnResimEkle;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\KayıtAlbüm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgResim;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\KayıtAlbüm.xaml"
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
            System.Uri resourceLocater = new System.Uri("/76;component/pages/kay%c4%b1talb%c3%bcm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\KayıtAlbüm.xaml"
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
            this.tbAlbümAd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.dpAlbümYıl = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.cbKayıtYeri = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.btnResimEkle = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Pages\KayıtAlbüm.xaml"
            this.btnResimEkle.Click += new System.Windows.RoutedEventHandler(this.btnResimEkle_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.imgResim = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.btnKaydet = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Pages\KayıtAlbüm.xaml"
            this.btnKaydet.Click += new System.Windows.RoutedEventHandler(this.btnKaydet_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

