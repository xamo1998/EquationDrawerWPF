﻿#pragma checksum "..\..\PersonalizeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D2DBB0EC5BB8ABCB376FD9C6D683AA6D62BDB280"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EquationDrawerApplication;
using EquationDrawerApplication.Model;
using EquationDrawerApplication.Models;
using EquationDrawerApplication.ViewModels.Converter;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace EquationDrawerApplication {
    
    
    /// <summary>
    /// PersonalizeWindow
    /// </summary>
    public partial class PersonalizeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\PersonalizeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView equationsPersonalizeTable;
        
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
            System.Uri resourceLocater = new System.Uri("/EquationDrawerApplication;component/personalizewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PersonalizeWindow.xaml"
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
            this.equationsPersonalizeTable = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            
            #line 82 "..\..\PersonalizeWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.onCheckButtonListener);
            
            #line default
            #line hidden
            
            #line 82 "..\..\PersonalizeWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.onCheckButtonListener);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 83 "..\..\PersonalizeWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.onCheckButtonListener);
            
            #line default
            #line hidden
            
            #line 83 "..\..\PersonalizeWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.onCheckButtonListener);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 84 "..\..\PersonalizeWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.onCheckButtonListener);
            
            #line default
            #line hidden
            
            #line 84 "..\..\PersonalizeWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.onCheckButtonListener);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 85 "..\..\PersonalizeWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.onCheckButtonListener);
            
            #line default
            #line hidden
            
            #line 85 "..\..\PersonalizeWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.onCheckButtonListener);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 102 "..\..\PersonalizeWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).SelectionChanged += new System.Windows.RoutedEventHandler(this.onIntervalListener);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 104 "..\..\PersonalizeWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).SelectionChanged += new System.Windows.RoutedEventHandler(this.onIntervalListener);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 105 "..\..\PersonalizeWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).SelectionChanged += new System.Windows.RoutedEventHandler(this.onIntervalListener);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 107 "..\..\PersonalizeWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).SelectionChanged += new System.Windows.RoutedEventHandler(this.onIntervalListener);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

