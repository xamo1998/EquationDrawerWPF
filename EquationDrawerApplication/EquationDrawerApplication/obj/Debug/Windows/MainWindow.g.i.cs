﻿#pragma checksum "..\..\..\Windows\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5AA2102DC5D3ECA3A9230E5F3ADD8FF9BCBD1A7F"
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
using EquationDrawerApplication.ViewModels;
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


namespace EquationDrawerApplication {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 22 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zoomOutButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zoomInButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button homeButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button functionButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button personalizeButton;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exportButton;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView equationsListView;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas myCanvas;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel coordsStackPanel;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox coordXTextBox;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox coordYTextBox;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel buttonStackPanel;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pointerButton;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image cursorImage;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dragButton;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image moveImage;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rectButton;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image rectImage;
        
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
            System.Uri resourceLocater = new System.Uri("/EquationDrawerApplication;component/windows/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\MainWindow.xaml"
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
            
            #line 20 "..\..\..\Windows\MainWindow.xaml"
            ((System.Windows.Controls.ToolBar)(target)).Loaded += new System.Windows.RoutedEventHandler(this.ToolBar_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.zoomOutButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Windows\MainWindow.xaml"
            this.zoomOutButton.Click += new System.Windows.RoutedEventHandler(this.zoomOutButtonListener);
            
            #line default
            #line hidden
            return;
            case 3:
            this.zoomInButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Windows\MainWindow.xaml"
            this.zoomInButton.Click += new System.Windows.RoutedEventHandler(this.zoomInButtonListener);
            
            #line default
            #line hidden
            return;
            case 4:
            this.homeButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Windows\MainWindow.xaml"
            this.homeButton.Click += new System.Windows.RoutedEventHandler(this.homeButtonListener);
            
            #line default
            #line hidden
            return;
            case 5:
            this.functionButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Windows\MainWindow.xaml"
            this.functionButton.Click += new System.Windows.RoutedEventHandler(this.functionsButtonListener);
            
            #line default
            #line hidden
            return;
            case 6:
            this.personalizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Windows\MainWindow.xaml"
            this.personalizeButton.Click += new System.Windows.RoutedEventHandler(this.personalizeInButtonListener);
            
            #line default
            #line hidden
            return;
            case 7:
            this.exportButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Windows\MainWindow.xaml"
            this.exportButton.Click += new System.Windows.RoutedEventHandler(this.exportButtonListener);
            
            #line default
            #line hidden
            return;
            case 8:
            this.equationsListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 11:
            this.myCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 141 "..\..\..\Windows\MainWindow.xaml"
            this.myCanvas.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MyCanvas_MouseEnter);
            
            #line default
            #line hidden
            
            #line 141 "..\..\..\Windows\MainWindow.xaml"
            this.myCanvas.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MyCanvas_MouseLeave);
            
            #line default
            #line hidden
            
            #line 141 "..\..\..\Windows\MainWindow.xaml"
            this.myCanvas.MouseMove += new System.Windows.Input.MouseEventHandler(this.onMouseMoved);
            
            #line default
            #line hidden
            
            #line 141 "..\..\..\Windows\MainWindow.xaml"
            this.myCanvas.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.onMouseDown);
            
            #line default
            #line hidden
            
            #line 141 "..\..\..\Windows\MainWindow.xaml"
            this.myCanvas.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.onMouseUp);
            
            #line default
            #line hidden
            
            #line 141 "..\..\..\Windows\MainWindow.xaml"
            this.myCanvas.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.onMouseUp);
            
            #line default
            #line hidden
            
            #line 141 "..\..\..\Windows\MainWindow.xaml"
            this.myCanvas.Loaded += new System.Windows.RoutedEventHandler(this.onLoadedCanvas);
            
            #line default
            #line hidden
            
            #line 141 "..\..\..\Windows\MainWindow.xaml"
            this.myCanvas.SizeChanged += new System.Windows.SizeChangedEventHandler(this.onSizeChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.coordsStackPanel = ((System.Windows.Controls.StackPanel)(target));
            
            #line 145 "..\..\..\Windows\MainWindow.xaml"
            this.coordsStackPanel.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MyStack_MouseEnter);
            
            #line default
            #line hidden
            
            #line 145 "..\..\..\Windows\MainWindow.xaml"
            this.coordsStackPanel.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MyStack_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 13:
            this.coordXTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.coordYTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.buttonStackPanel = ((System.Windows.Controls.StackPanel)(target));
            
            #line 150 "..\..\..\Windows\MainWindow.xaml"
            this.buttonStackPanel.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MyStack_MouseEnter);
            
            #line default
            #line hidden
            
            #line 150 "..\..\..\Windows\MainWindow.xaml"
            this.buttonStackPanel.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MyStack_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 16:
            this.pointerButton = ((System.Windows.Controls.Button)(target));
            
            #line 151 "..\..\..\Windows\MainWindow.xaml"
            this.pointerButton.Click += new System.Windows.RoutedEventHandler(this.onDifferentCursorListener);
            
            #line default
            #line hidden
            return;
            case 17:
            this.cursorImage = ((System.Windows.Controls.Image)(target));
            return;
            case 18:
            this.dragButton = ((System.Windows.Controls.Button)(target));
            
            #line 154 "..\..\..\Windows\MainWindow.xaml"
            this.dragButton.Click += new System.Windows.RoutedEventHandler(this.onDifferentCursorListener);
            
            #line default
            #line hidden
            return;
            case 19:
            this.moveImage = ((System.Windows.Controls.Image)(target));
            return;
            case 20:
            this.rectButton = ((System.Windows.Controls.Button)(target));
            
            #line 157 "..\..\..\Windows\MainWindow.xaml"
            this.rectButton.Click += new System.Windows.RoutedEventHandler(this.onDifferentCursorListener);
            
            #line default
            #line hidden
            return;
            case 21:
            this.rectImage = ((System.Windows.Controls.Image)(target));
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
            case 9:
            
            #line 104 "..\..\..\Windows\MainWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.functionCheckBoxListener);
            
            #line default
            #line hidden
            
            #line 104 "..\..\..\Windows\MainWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.functionCheckBoxListener);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 106 "..\..\..\Windows\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.onTouchEllipseEvent);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

