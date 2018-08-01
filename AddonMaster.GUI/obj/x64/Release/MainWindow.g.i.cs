﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66F219B45F01CF8FD17E69DA58FCDACC93F0A739"
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 13 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbAddonList;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome imgAdd;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblEmptyList;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome Spinner;
        
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
            System.Uri resourceLocater = new System.Uri("/AddonMaster.GUI;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
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
            
            #line 11 "..\..\..\MainWindow.xaml"
            ((AddonMaster.GUI.MainWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lbAddonList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.imgAdd = ((FontAwesome.WPF.ImageAwesome)(target));
            
            #line 37 "..\..\..\MainWindow.xaml"
            this.imgAdd.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgAdd_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblEmptyList = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.Spinner = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            case 8:
            
            #line 40 "..\..\..\MainWindow.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgReport_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 41 "..\..\..\MainWindow.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImageAwesome_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 42 "..\..\..\MainWindow.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImageAwesome_MouseDown);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 43 "..\..\..\MainWindow.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImageAwesome_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 30 "..\..\..\MainWindow.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgUpdate_MouseDown);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 32 "..\..\..\MainWindow.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgRemove_MouseDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

