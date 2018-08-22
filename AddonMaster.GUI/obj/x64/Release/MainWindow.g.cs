﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "429D19CAF709F48790941ED2AAB053C51EC8260E"
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
        
        
        #line 31 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LblAddonList;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome ImgAdd;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblEmptyList;
        
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
            this.LblAddonList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.ImgAdd = ((FontAwesome.WPF.ImageAwesome)(target));
            
            #line 57 "..\..\..\MainWindow.xaml"
            this.ImgAdd.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgAdd_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.LblEmptyList = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            
            #line 59 "..\..\..\MainWindow.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgReport_MouseDown);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 60 "..\..\..\MainWindow.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImageAwesome_MouseDown);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 61 "..\..\..\MainWindow.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImageAwesome_MouseDown);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 62 "..\..\..\MainWindow.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImageAwesome_MouseDown);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 64 "..\..\..\MainWindow.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImageAwesome_MouseDown_1);
            
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
            
            #line 45 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 47 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 48 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 50 "..\..\..\MainWindow.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgUpdate_MouseDown);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 51 "..\..\..\MainWindow.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgRemove_MouseDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

