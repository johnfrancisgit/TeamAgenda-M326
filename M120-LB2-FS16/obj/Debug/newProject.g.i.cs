﻿#pragma checksum "..\..\newProject.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3DCD02203D47CFE1F17E31DF2F6EF367"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using M120_LB2_FS16;
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


namespace M120_LB2_FS16 {
    
    
    /// <summary>
    /// newProject
    /// </summary>
    public partial class newProject : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\newProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox projName;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\newProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox projGesamt;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\newProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox projOffene;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\newProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker projStart;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\newProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker projEnd;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\newProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox projAktiv;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\newProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnID;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\newProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button projSubmit;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\newProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock success;
        
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
            System.Uri resourceLocater = new System.Uri("/M120-LB2-FS16;component/newproject.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\newProject.xaml"
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
            this.projName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.projGesamt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.projOffene = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.projStart = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.projEnd = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.projAktiv = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.btnID = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.projSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\newProject.xaml"
            this.projSubmit.Click += new System.Windows.RoutedEventHandler(this.btnProj_Handler);
            
            #line default
            #line hidden
            return;
            case 9:
            this.success = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

