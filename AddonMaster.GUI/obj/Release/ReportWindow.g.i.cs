﻿#pragma checksum "..\..\ReportWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "979130FCAA6A77489425BE281D11851DFAE57709"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using MahApps.Metro.Controls;
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


namespace AddonMaster.GUI {
    
    
    /// <summary>
    /// ReportWindow
    /// </summary>
    public partial class ReportWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\ReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtContent;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkboxBug;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkboxFeedback;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome imgSend;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\ReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome spinner;
        
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
            System.Uri resourceLocater = new System.Uri("/AddonMaster.GUI;component/reportwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ReportWindow.xaml"
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
            
            #line 13 "..\..\ReportWindow.xaml"
            ((AddonMaster.GUI.ReportWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtContent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.checkboxBug = ((System.Windows.Controls.CheckBox)(target));
            
            #line 33 "..\..\ReportWindow.xaml"
            this.checkboxBug.Checked += new System.Windows.RoutedEventHandler(this.checkboxBug_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.checkboxFeedback = ((System.Windows.Controls.CheckBox)(target));
            
            #line 34 "..\..\ReportWindow.xaml"
            this.checkboxFeedback.Checked += new System.Windows.RoutedEventHandler(this.checkboxFeedback_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.imgSend = ((FontAwesome.WPF.ImageAwesome)(target));
            
            #line 35 "..\..\ReportWindow.xaml"
            this.imgSend.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgSend_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.spinner = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            case 7:
            
            #line 48 "..\..\ReportWindow.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImageAwesome_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 49 "..\..\ReportWindow.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImageAwesome_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 50 "..\..\ReportWindow.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImageAwesome_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

