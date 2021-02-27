﻿using System.Windows;
using System.Windows.Controls;

namespace UI.Student
{
    public partial class StudentProfile : Window
    {
        //INITIALISATION CODE
        public StudentProfile()
        {
            InitializeComponent();
            Title = "Student's name goes here";
        }
        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                dgBreadcrmbs.ItemsSource = null;
                dgBreadcrmbs.ItemsSource = MainWindow.pagesVisitedTracker;
            }
        }

        //END OF INITIALISATION CODE

        //NAVIGATION CODE
        private void goBack_navigation_btn_Click(object sender, RoutedEventArgs e)
        {
            PageNavigation.GoToNewOrExistingPage(new StudentInformation());
            Hide();
        }

        private void Btn_StudentEnrolment_Click(object sender, RoutedEventArgs e)
        {
            PageNavigation.GoToNewOrExistingPage(new StudentEnrolment());
            Hide();
        }

        private void Btn_StudentResult_Click(object sender, RoutedEventArgs e)
        {
            PageNavigation.GoToNewOrExistingPage(new StudentResultSearch());
            Hide();
        }

        private void dgBreadcrmbs_NavigateToSelectedPage(object sender, DataGridPreparingCellForEditEventArgs e)
        {
            dgBreadcrmbs.CancelEdit();
            PageNavigation.GoToExistingPage(dgBreadcrmbs.SelectedIndex);
            Hide();
        }
        //END OF NAVIGATION CODE
    }
}
