﻿#pragma checksum "..\..\..\..\..\UI\Registros\rEstudiantes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BAE817E8C5D26758362B094463420CE657872B8C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RegistroEstudiantesWPF.UI.Registros;
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


namespace RegistroEstudiantesWPF.UI.Registros {
    
    
    /// <summary>
    /// rEstudiantes
    /// </summary>
    public partial class rEstudiantes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\..\UI\Registros\rEstudiantes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EstudianteIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\UI\Registros\rEstudiantes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NombresTextBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\UI\Registros\rEstudiantes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SemestreTextBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\UI\Registros\rEstudiantes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NuevoButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\UI\Registros\rEstudiantes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GuardarButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\UI\Registros\rEstudiantes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EliminarButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RegistroEstudiantesWPF;component/ui/registros/restudiantes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Registros\rEstudiantes.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.EstudianteIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.NombresTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.SemestreTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.NuevoButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\..\UI\Registros\rEstudiantes.xaml"
            this.NuevoButton.Click += new System.Windows.RoutedEventHandler(this.NuevoButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GuardarButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\..\UI\Registros\rEstudiantes.xaml"
            this.GuardarButton.Click += new System.Windows.RoutedEventHandler(this.GuardarButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.EliminarButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\..\UI\Registros\rEstudiantes.xaml"
            this.EliminarButton.Click += new System.Windows.RoutedEventHandler(this.EliminarButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

