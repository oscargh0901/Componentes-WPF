#pragma checksum "..\..\..\ModalReservas.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5CCE24E4F6261FF7EE80D6D849E0FBC14D7B737F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using DI02_Tarea_Garcia_Hernandez_Oscar;
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


namespace DI02_Tarea_Garcia_Hernandez_Oscar {
    
    
    /// <summary>
    /// ModalReserva
    /// </summary>
    public partial class ModalReserva : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\ModalReservas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxAula;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\ModalReservas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxProfesor;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\ModalReservas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxAlumnos;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\ModalReservas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePickerFecha;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\ModalReservas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAceptar;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\ModalReservas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCancelar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DI02_Tarea_Garcia_Hernandez_Oscar;V1.0.0.0;component/modalreservas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ModalReservas.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\ModalReservas.xaml"
            ((System.Windows.Controls.Grid)(target)).AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.Validation_Error));
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxAula = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\ModalReservas.xaml"
            this.TextBoxAula.LostFocus += new System.Windows.RoutedEventHandler(this.TextBoxAula_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextBoxProfesor = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\ModalReservas.xaml"
            this.TextBoxProfesor.LostFocus += new System.Windows.RoutedEventHandler(this.TextBoxProfesor_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TextBoxAlumnos = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\ModalReservas.xaml"
            this.TextBoxAlumnos.LostFocus += new System.Windows.RoutedEventHandler(this.TextBoxAlumnos_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DatePickerFecha = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.ButtonAceptar = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\ModalReservas.xaml"
            this.ButtonAceptar.Click += new System.Windows.RoutedEventHandler(this.ButtonAceptar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\ModalReservas.xaml"
            this.ButtonCancelar.Click += new System.Windows.RoutedEventHandler(this.ButtonCancelar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

