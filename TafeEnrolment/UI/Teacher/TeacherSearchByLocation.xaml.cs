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

namespace UI
{
    /// <summary>
    /// Interaction logic for TeacherSearchByLocation.xaml
    /// </summary>
    public partial class TeacherSearchByLocation : Window
    {
        public TeacherSearchByLocation()
        {
            InitializeComponent();
        }

        //go back
        private void goBack_navigation_btn_Click(object sender, RoutedEventArgs e)
        {
            TeacherInformation pageobj = new TeacherInformation();
            pageobj.Show();
            Close();
        }
    }
}