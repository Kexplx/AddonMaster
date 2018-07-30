﻿#pragma checksum "..\..\SetupWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F80932EC9EC339556DA2292C7BAD8F44D0F1C181"
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
    /// SetupWindow
    /// </summary>
    public partial class SetupWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAddonFolderPath;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock xd1;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome btnOpenDirectoryDialogue;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome btnContinue;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblStatus;
        
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
            System.Uri resourceLocater = new System.Uri("/AddonMaster.GUI;component/setupwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SetupWindow.xaml"
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
            
            #line 11 "..\..\SetupWindow.xaml"
            ((AddonMaster.GUI.SetupWindow)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MetroWindow_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 11 "..\..\SetupWindow.xaml"
            ((AddonMaster.GUI.SetupWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MetroWindow_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 17 "..\..\SetupWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 22 "..\..\SetupWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtAddonFolderPath = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\SetupWindow.xaml"
            this.txtAddonFolderPath.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtPath_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.xd1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.btnOpenDirectoryDialogue = ((FontAwesome.WPF.ImageAwesome)(target));
            
            #line 44 "..\..\SetupWindow.xaml"
            this.btnOpenDirectoryDialogue.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btnOpenDirectoryDialogue_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnContinue = ((FontAwesome.WPF.ImageAwesome)(target));
            
            #line 45 "..\..\SetupWindow.xaml"
            this.btnContinue.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btnContinue_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblStatus = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

