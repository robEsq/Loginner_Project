﻿#pragma checksum "..\..\..\..\..\MVVM\View\RegisterView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2690FD586EFFE8F57529566D74D884329625B3CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Assessment_LoginSystem.MVVM.View;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Assessment_LoginSystem.MVVM.View {
    
    
    /// <summary>
    /// RegisterView
    /// </summary>
    public partial class RegisterView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\..\MVVM\View\RegisterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Assessment_LoginSystem.MVVM.View.RegisterView rv;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\MVVM\View\RegisterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock authentication;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\MVVM\View\RegisterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox registerUsername;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\..\MVVM\View\RegisterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox registerPassword;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\MVVM\View\RegisterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox autoGeneratePasswordDisplay;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\..\MVVM\View\RegisterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox GeneratePassword;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Assessment_LoginSystem;component/mvvm/view/registerview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\MVVM\View\RegisterView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.rv = ((Assessment_LoginSystem.MVVM.View.RegisterView)(target));
            return;
            case 2:
            this.authentication = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.registerUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.registerPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.autoGeneratePasswordDisplay = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.GeneratePassword = ((System.Windows.Controls.CheckBox)(target));
            
            #line 81 "..\..\..\..\..\MVVM\View\RegisterView.xaml"
            this.GeneratePassword.Checked += new System.Windows.RoutedEventHandler(this.GeneratePassword_Checked);
            
            #line default
            #line hidden
            
            #line 82 "..\..\..\..\..\MVVM\View\RegisterView.xaml"
            this.GeneratePassword.Unchecked += new System.Windows.RoutedEventHandler(this.GeneratePassword_Unchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 91 "..\..\..\..\..\MVVM\View\RegisterView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Register_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

