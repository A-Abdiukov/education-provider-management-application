﻿#pragma checksum "..\..\TeacherInformation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "48326C502718581C8F50E369FD99CEA0F94EFEB749AC162EF1ACE1DF40CCFFBF"
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
using UI;


namespace UI {
    
    
    /// <summary>
    /// TeacherInformation
    /// </summary>
    public partial class TeacherInformation : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 11 "..\..\TeacherInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextbox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\TeacherInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\TeacherInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button goBack_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\TeacherInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgTeacherProfiles;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\TeacherInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkbox_SearchFullTime;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\TeacherInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkbox_SearchPartTime;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\TeacherInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkbox_SearchTeacherNotBasedLocation;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\TeacherInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgBreadcrmbs;
        
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
            System.Uri resourceLocater = new System.Uri("/UI;component/teacherinformation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TeacherInformation.xaml"
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
            
            #line 8 "..\..\TeacherInformation.xaml"
            ((UI.TeacherInformation)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Window_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\TeacherInformation.xaml"
            this.SearchTextbox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SearchTextbox_MouseClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\TeacherInformation.xaml"
            this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.goBack_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\TeacherInformation.xaml"
            this.goBack_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.goBack_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dgTeacherProfiles = ((System.Windows.Controls.DataGrid)(target));
            
            #line 14 "..\..\TeacherInformation.xaml"
            this.dgTeacherProfiles.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.dgTeacherProfiles_MouseRightButtonDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.checkbox_SearchFullTime = ((System.Windows.Controls.CheckBox)(target));
            
            #line 34 "..\..\TeacherInformation.xaml"
            this.checkbox_SearchFullTime.Checked += new System.Windows.RoutedEventHandler(this.checkbox_SearchFullTime_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.checkbox_SearchPartTime = ((System.Windows.Controls.CheckBox)(target));
            
            #line 35 "..\..\TeacherInformation.xaml"
            this.checkbox_SearchPartTime.Checked += new System.Windows.RoutedEventHandler(this.checkbox_SearchPartTime_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.checkbox_SearchTeacherNotBasedLocation = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            this.dgBreadcrmbs = ((System.Windows.Controls.DataGrid)(target));
            
            #line 44 "..\..\TeacherInformation.xaml"
            this.dgBreadcrmbs.PreparingCellForEdit += new System.EventHandler<System.Windows.Controls.DataGridPreparingCellForEditEventArgs>(this.dgBreadcrmbs_NavigateToSelectedPage);
            
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
            
            #line 26 "..\..\TeacherInformation.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnSelect_Click);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 27 "..\..\TeacherInformation.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_CourseHistory_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

