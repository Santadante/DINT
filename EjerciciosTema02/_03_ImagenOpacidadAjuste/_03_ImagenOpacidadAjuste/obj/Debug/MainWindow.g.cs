﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0D3BA359BA7E0BF55E5ACA1A33DB4DE46C80C8296576DC37653E9FC080BE7F2A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
using _03_ImagenOpacidadAjuste;


namespace _03_ImagenOpacidadAjuste {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgImage;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton altaRadioButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton mediaRadioButton;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton bajaRadioButton;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rellenoRadioButton;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton uniformeRadioButton;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rellenoUniformeRadioButton;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton sinAjusteRadioButton;
        
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
            System.Uri resourceLocater = new System.Uri("/_03_ImagenOpacidadAjuste;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.imgImage = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.altaRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 40 "..\..\MainWindow.xaml"
            this.altaRadioButton.Click += new System.Windows.RoutedEventHandler(this.altaRadioButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.mediaRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 50 "..\..\MainWindow.xaml"
            this.mediaRadioButton.Click += new System.Windows.RoutedEventHandler(this.mediaRadioButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bajaRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 59 "..\..\MainWindow.xaml"
            this.bajaRadioButton.Click += new System.Windows.RoutedEventHandler(this.bajaRadioButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rellenoRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 77 "..\..\MainWindow.xaml"
            this.rellenoRadioButton.Click += new System.Windows.RoutedEventHandler(this.rellenoRadioButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.uniformeRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 87 "..\..\MainWindow.xaml"
            this.uniformeRadioButton.Click += new System.Windows.RoutedEventHandler(this.uniformeRadioButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.rellenoUniformeRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 96 "..\..\MainWindow.xaml"
            this.rellenoUniformeRadioButton.Click += new System.Windows.RoutedEventHandler(this.rellenoUniformeRadioButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.sinAjusteRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 105 "..\..\MainWindow.xaml"
            this.sinAjusteRadioButton.Click += new System.Windows.RoutedEventHandler(this.sinAjusteRadioButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

