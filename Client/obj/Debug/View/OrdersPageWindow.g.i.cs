﻿#pragma checksum "..\..\..\View\OrdersPageWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2AA284CBC02C714921BB132769A0F7C0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Client.View;
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


namespace Client.View {
    
    
    /// <summary>
    /// OrdersPageWindow
    /// </summary>
    public partial class OrdersPageWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\View\OrdersPageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FindOrderButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\OrdersPageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateOrderButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\OrdersPageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenOrderButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\View\OrdersPageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleOrderButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\View\OrdersPageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox OrdersListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Client;component/view/orderspagewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\OrdersPageWindow.xaml"
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
            this.FindOrderButton = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.CreateOrderButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\View\OrdersPageWindow.xaml"
            this.CreateOrderButton.Click += new System.Windows.RoutedEventHandler(this.CreateOrderButtonClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.OpenOrderButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\View\OrdersPageWindow.xaml"
            this.OpenOrderButton.Click += new System.Windows.RoutedEventHandler(this.OpenOrderButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeleOrderButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\View\OrdersPageWindow.xaml"
            this.DeleOrderButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButtonClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.OrdersListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

