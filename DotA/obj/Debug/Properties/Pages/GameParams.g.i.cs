﻿#pragma checksum "..\..\..\..\Properties\Pages\GameParams.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A78C85E7438AB482268AC8C82AECA898"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DotA.Properties.Pages;
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


namespace DotA.Properties.Pages {
    
    
    /// <summary>
    /// GameParams
    /// </summary>
    public partial class GameParams : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Properties\Pages\GameParams.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas CMain;
        
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
            System.Uri resourceLocater = new System.Uri("/DotA;component/properties/pages/gameparams.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Properties\Pages\GameParams.xaml"
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
            this.CMain = ((System.Windows.Controls.Canvas)(target));
            
            #line 13 "..\..\..\..\Properties\Pages\GameParams.xaml"
            this.CMain.Loaded += new System.Windows.RoutedEventHandler(this.CMain_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 14 "..\..\..\..\Properties\Pages\GameParams.xaml"
            ((System.Windows.Controls.Label)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Label_MouseEnter);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\..\Properties\Pages\GameParams.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Label_MouseLeave);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\..\Properties\Pages\GameParams.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.StartClickHandler);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 38 "..\..\..\..\Properties\Pages\GameParams.xaml"
            ((System.Windows.Controls.Label)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Label_MouseEnter);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\..\Properties\Pages\GameParams.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Label_MouseLeave);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\..\Properties\Pages\GameParams.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.BackClickHandler);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
