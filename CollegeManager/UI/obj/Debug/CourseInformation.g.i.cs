﻿#pragma checksum "..\..\CourseInformation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3B98E3A562D478F10358BAEDFB6C2B24FE8DCC98EA7AA45B7B93269A0915DA3B"
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


namespace View {
    
    
    /// <summary>
    /// CourseInformation
    /// </summary>
    public partial class CourseInformation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\CourseInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBack_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\CourseInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button courseNotOffered_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\CourseInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clusterUnitCourse_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\CourseInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button subjectsNotAllocated_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\CourseInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button courseTimetables_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\CourseInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgNavigationBar;
        
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
            System.Uri resourceLocater = new System.Uri("/View;component/courseinformation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CourseInformation.xaml"
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
            
            #line 8 "..\..\CourseInformation.xaml"
            ((View.CourseInformation)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 9 "..\..\CourseInformation.xaml"
            ((View.CourseInformation)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Window_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GoBack_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\CourseInformation.xaml"
            this.GoBack_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.GoBack_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.courseNotOffered_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\CourseInformation.xaml"
            this.courseNotOffered_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.CourseNotOffered_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.clusterUnitCourse_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\CourseInformation.xaml"
            this.clusterUnitCourse_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.ClusterUnitCourse_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.subjectsNotAllocated_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\CourseInformation.xaml"
            this.subjectsNotAllocated_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.SubjectsNotAllocated_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.courseTimetables_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\CourseInformation.xaml"
            this.courseTimetables_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.CourseTimetables_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DgNavigationBar = ((System.Windows.Controls.DataGrid)(target));
            
            #line 69 "..\..\CourseInformation.xaml"
            this.DgNavigationBar.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DgNavigationBar_NavigateToSelectedPage);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
