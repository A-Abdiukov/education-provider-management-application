﻿using System;
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
    /// Interaction logic for StudentProfile.xaml
    /// </summary>
    public partial class StudentProfile : Window
    {
        public StudentProfile()
        {
            InitializeComponent();
            Title = "Placeholder text";
            textbox_name.Text = "Placeholder text";
            textbox_placeholder.Text = "Student's position : " + "Full Time";
            textbox_placeholder2.Text = "Student's name : " + "Placeholder text";



            bool student_paid_fees = true;

            textbox_placeholder3.Text = student_paid_fees ? 
                "The student has paid fees" : "The student has not paid fees";

        }

        //go back
        private void goBack_navigation_btn_Click(object sender, RoutedEventArgs e)
        {
            StudentInformation pageobj = new StudentInformation();
            pageobj.Show();
            Close();
        }
    }
}
