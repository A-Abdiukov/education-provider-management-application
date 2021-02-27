﻿using System.Collections.Generic;
using System.Windows;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //declaring a tracker that has all the pages
        //the page visited tracker can only hold 10 pages, however as the program size increases, this number should be changed
        public static List<Window> pagesVisitedTracker = new List<Window>();

        public MainWindow()
        {
            InitializeComponent();
        }

        //Navigation
        private void NavigateTeacherInfo_Click(object sender, RoutedEventArgs e)
        {
            PageNavigation.GoToNewPage(new TeacherInformation());
            this.Visibility = Visibility.Hidden;
        }

        private void NavigateCourseInfo_Click(object sender, RoutedEventArgs e)
        {
            PageNavigation.GoToNewPage(new CourseInformation());
            this.Visibility = Visibility.Hidden;
        }

        private void NavigateStudentInfo_Click(object sender, RoutedEventArgs e)
        {
            PageNavigation.GoToNewPage(new StudentInformation());
            this.Visibility = Visibility.Hidden;
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.Visibility == Visibility.Visible)
            {
                for (int i = 1; i < pagesVisitedTracker.Count; i++)
                {
                    pagesVisitedTracker[i].Close();
                }
                pagesVisitedTracker.Clear();
                pagesVisitedTracker.Add(this);
            }
        }
    }
}
