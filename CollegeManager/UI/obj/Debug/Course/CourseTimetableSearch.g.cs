﻿#pragma checksum "..\..\..\Course\CourseTimetableSearch.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AD1F14E05CC96D7E6E3E483C014540DD787DABBB664D9588CB469759755C5D75"
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
    /// CourseTimetableSearch
    /// </summary>
    public partial class CourseTimetableSearch : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Course\CourseTimetableSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBack_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Course\CourseTimetableSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgTimetable;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Course\CourseTimetableSearch.xaml"
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
            System.Uri resourceLocater = new System.Uri("/View;component/course/coursetimetablesearch.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Course\CourseTimetableSearch.xaml"
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
            
            #line 8 "..\..\..\Course\CourseTimetableSearch.xaml"
            ((View.CourseTimetableSearch)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Course\CourseTimetableSearch.xaml"
            ((View.CourseTimetableSearch)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Window_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GoBack_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Course\CourseTimetableSearch.xaml"
            this.GoBack_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.GoBack_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DgTimetable = ((System.Windows.Controls.DataGrid)(target));
            
            #line 32 "..\..\..\Course\CourseTimetableSearch.xaml"
            this.DgTimetable.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DgTimetable_MouseRightButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DgNavigationBar = ((System.Windows.Controls.DataGrid)(target));
            
            #line 58 "..\..\..\Course\CourseTimetableSearch.xaml"
            this.DgNavigationBar.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DgNavigationBar_NavigateToSelectedPage);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

