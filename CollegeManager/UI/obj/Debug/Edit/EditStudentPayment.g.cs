﻿#pragma checksum "..\..\..\Edit\EditStudentPayment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "53E0902362329BE833E50BDC971982A5603DE87924CD376AB4698B6E123B63CD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace View.Edit {
    
    
    /// <summary>
    /// EditStudentPayment
    /// </summary>
    public partial class EditStudentPayment : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 15 "..\..\..\Edit\EditStudentPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBack_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Edit\EditStudentPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgNavigationBar;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Edit\EditStudentPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxSelectStudent;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Edit\EditStudentPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgStudentEnrolment;
        
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
            System.Uri resourceLocater = new System.Uri("/View;component/edit/editstudentpayment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Edit\EditStudentPayment.xaml"
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
            
            #line 8 "..\..\..\Edit\EditStudentPayment.xaml"
            ((View.Edit.EditStudentPayment)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Edit\EditStudentPayment.xaml"
            ((View.Edit.EditStudentPayment)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Window_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GoBack_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Edit\EditStudentPayment.xaml"
            this.GoBack_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.GoBack_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DgNavigationBar = ((System.Windows.Controls.DataGrid)(target));
            
            #line 35 "..\..\..\Edit\EditStudentPayment.xaml"
            this.DgNavigationBar.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DgNavigationBar_NavigateToSelectedPage);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ComboBoxSelectStudent = ((System.Windows.Controls.ComboBox)(target));
            
            #line 103 "..\..\..\Edit\EditStudentPayment.xaml"
            this.ComboBoxSelectStudent.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxSelectStudent_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DgStudentEnrolment = ((System.Windows.Controls.DataGrid)(target));
            
            #line 116 "..\..\..\Edit\EditStudentPayment.xaml"
            this.DgStudentEnrolment.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DgStudentEnrolment_MouseRightButtonDown);
            
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
            case 6:
            
            #line 131 "..\..\..\Edit\EditStudentPayment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEditPayment_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

