﻿#pragma checksum "..\..\..\View\AuthorizationWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "90F186CD3FBDAFDCA388187425307680"
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
    /// AuthorizationWindow
    /// </summary>
    public partial class AuthorizationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\View\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginTextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\View\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\View\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSignIn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonRegstration;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\View\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
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
            System.Uri resourceLocater = new System.Uri("/Client;component/view/authorizationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\AuthorizationWindow.xaml"
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
            this.loginTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\View\AuthorizationWindow.xaml"
            this.loginTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBoxGotFocus);
            
            #line default
            #line hidden
            
            #line 17 "..\..\..\View\AuthorizationWindow.xaml"
            this.loginTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.loginTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PasswordTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\View\AuthorizationWindow.xaml"
            this.PasswordTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBoxGotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonSignIn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\View\AuthorizationWindow.xaml"
            this.ButtonSignIn.Click += new System.Windows.RoutedEventHandler(this.ButtonSignInClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonRegstration = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\View\AuthorizationWindow.xaml"
            this.ButtonRegstration.Click += new System.Windows.RoutedEventHandler(this.ButtonRegestrationClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\View\AuthorizationWindow.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

