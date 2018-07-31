#pragma checksum "..\..\InfoWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36EEBEC3EF301D7D7401A25AF1017C0DDCD6087B"
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


namespace AddonMaster.GUI
{


    /// <summary>
    /// InfoWindow
    /// </summary>
    public partial class InfoWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector
    {


#line 20 "..\..\InfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMainWindow;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AddonMaster.GUI;component/infowindow.xaml", System.UriKind.Relative);

#line 1 "..\..\InfoWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 14 "..\..\InfoWindow.xaml"
                    ((AddonMaster.GUI.InfoWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);

#line default
#line hidden
                    return;
                case 2:

#line 16 "..\..\InfoWindow.xaml"
                    ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImageAwesome_MouseDown);

#line default
#line hidden
                    return;
                case 3:

#line 17 "..\..\InfoWindow.xaml"
                    ((FontAwesome.WPF.ImageAwesome)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImageAwesome_MouseDown);

#line default
#line hidden
                    return;
                case 4:
                    this.txtMainWindow = ((System.Windows.Controls.TextBox)(target));

#line 20 "..\..\InfoWindow.xaml"
                    this.txtMainWindow.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtMainWindow_TextChanged);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox txtAddAddonWindow;
    }
}

