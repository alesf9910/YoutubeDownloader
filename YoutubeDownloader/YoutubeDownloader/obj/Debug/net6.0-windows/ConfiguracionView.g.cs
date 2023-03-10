#pragma checksum "..\..\..\ConfiguracionView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D9AC5FAA372DE53D2E3EC444600ACD6CEA9F7921"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Google.Apis.Requests.Parameters;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using YoutubeDownloader;


namespace YoutubeDownloader {
    
    
    /// <summary>
    /// ConfiguracionView
    /// </summary>
    public partial class ConfiguracionView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\ConfiguracionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProxyState;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\ConfiguracionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.UniformGrid contentDataProxy;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\ConfiguracionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddressText;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\ConfiguracionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PortText;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\ConfiguracionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserText;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\ConfiguracionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PassText;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\ConfiguracionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProxyBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/YoutubeDownloader;component/configuracionview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ConfiguracionView.xaml"
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
            this.ProxyState = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\..\ConfiguracionView.xaml"
            this.ProxyState.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProxyState_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.contentDataProxy = ((System.Windows.Controls.Primitives.UniformGrid)(target));
            return;
            case 3:
            this.AddressText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PortText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.UserText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.PassText = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.ProxyBtn = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\ConfiguracionView.xaml"
            this.ProxyBtn.Click += new System.Windows.RoutedEventHandler(this.ProxyBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

