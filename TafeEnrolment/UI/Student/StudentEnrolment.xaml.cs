﻿using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UI.Student
{
    /// <summary>
    /// Interaction logic for StudentEnrolment.xaml
    /// </summary>
    public partial class StudentEnrolment : Window
    {
        Breadcrumbs brdcrumb_tracker;
        public StudentEnrolment()
        {
            InitializeComponent();
            brdcrumb_tracker = new Breadcrumbs(this.GetType().Name);
        }

        //go back
        private void goBack_navigation_btn_Click(object sender, RoutedEventArgs e)
        {
            PageNavigation.Navigate("StudentProfile");
            Hide();
        }


        private void dgBreadcrmbs_NavigateToSelectedPage(object sender, DataGridPreparingCellForEditEventArgs e)
        {
            string selected_page = dgBreadcrmbs.SelectedItem.ToString();

            //if the current page is NOT the page the user has clicked on
            if (selected_page != this.GetType().Name)
            {
                PageNavigation.Navigate(selected_page);
                Hide();
            }
            dgBreadcrmbs.CancelEdit();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.Visibility == Visibility.Visible)
            {
                dgBreadcrmbs.ItemsSource = brdcrumb_tracker.GetListOfPagesVisited();
            }
        }
    }
}
