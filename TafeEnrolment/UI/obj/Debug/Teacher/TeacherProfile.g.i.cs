﻿#pragma checksum "..\..\..\Teacher\TeacherProfile.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A3ED1DAA12E4B7684F2D7C5E5FB1C62C07856BA524CECA1FABCAB0F23BDD8BDE"
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
using UI.Teacher;


namespace UI.Teacher {
    
    
    /// <summary>
    /// TeacherProfile
    /// </summary>
    public partial class TeacherProfile : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Teacher\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_name;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Teacher\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_placeholder;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Teacher\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_placeholder2;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Teacher\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_placeholder3;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Teacher\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button goBack_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Teacher\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_teacherCourseHistory;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Teacher\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_placeholder3;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Teacher\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_placeholder1;
        
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
            System.Uri resourceLocater = new System.Uri("/UI;component/teacher/teacherprofile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Teacher\TeacherProfile.xaml"
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
            this.textbox_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.textbox_placeholder = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.textbox_placeholder2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.textbox_placeholder3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.goBack_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Teacher\TeacherProfile.xaml"
            this.goBack_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.goBack_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Btn_teacherCourseHistory = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.Btn_placeholder3 = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.Btn_placeholder1 = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
