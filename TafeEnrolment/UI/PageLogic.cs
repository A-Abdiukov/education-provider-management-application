﻿using System.Windows;

namespace UI
{
    public class PageLogic
    {
        public static string SearchBoxReplaceDefaultValue(string searchboxText)
        {
            return searchboxText == "Enter keywords by which criteria to search" ? "" : searchboxText;
        }

        public static void SearchStudent(string searchQuery, bool? searchPartTime, bool? searchFullTime, bool? searchNoFees)
        {
            searchQuery = SearchBoxReplaceDefaultValue(searchQuery);

            int v = 0;
            if ((bool)searchPartTime) { v += 4; } //x
            if ((bool)searchFullTime) { v += 2; } //y
            if ((bool)searchNoFees) { v += 1; } //z

            switch (v)
            {
                case 0: // all false
                    MessageBox.Show("Search everyone" + searchQuery);
                    break;
                case 1: // z is true
                    MessageBox.Show("Search no fees " + searchQuery);
                    break;
                case 2: // y is true
                    MessageBox.Show("Search full time " + searchQuery);
                    break;
                case 3: // z and y are true
                    MessageBox.Show("Search full time no fees " + searchQuery);
                    break;
                case 4: // x is true
                    MessageBox.Show("Search part time " + searchQuery);
                    break;
                case 5: //x and z are true
                    MessageBox.Show("Search part time no fees " + searchQuery);
                    break;
                case 6: //x and y are true
                    MessageBox.Show("Error! Both part time and full time tick boxes are ticked " + searchQuery);
                    break;
            }
        }

        public static void SearchTeacher(string searchQuery, bool? searchPartTime, bool? searchFullTime, bool? searchNotBaseLocation)
        {
            searchQuery = SearchBoxReplaceDefaultValue(searchQuery);
            int v = 0;
            if ((bool)searchPartTime) { v += 4; } //x
            if ((bool)searchFullTime) { v += 2; } //y
            if ((bool)searchNotBaseLocation) { v += 1; } //z

            switch (v)
            {
                case 0: // all false
                    MessageBox.Show("Search everyone " + searchQuery);
                    break;
                case 1: // z is true
                    MessageBox.Show("Show teachers who are not teaching at their base location " + searchQuery);
                    break;
                case 2: // y is true
                    MessageBox.Show("Search full time " + searchQuery);
                    break;
                case 3: // z and y are true
                    MessageBox.Show("Search full time and not teaching at their base location " + searchQuery);
                    break;
                case 4: // x is true
                    MessageBox.Show("Search part time " + searchQuery);
                    break;
                case 5: //x and z are true
                    MessageBox.Show("Search part time and not teaching at their base location " + searchQuery);
                    break;
                case 6: //x and y are true
                    MessageBox.Show("Error! Both part time and full time tick boxes are ticked " + searchQuery);
                    break;
            }
        }

        public static void SearchCourseTimetable(string searchQuery)
        {
            searchQuery = SearchBoxReplaceDefaultValue(searchQuery);

            MessageBox.Show(searchQuery);
        }

        public static void SearchTeacherCourseHistory(string searchQuery, bool? searchPastCourse, bool? searchPresentCourse)
        {
            searchQuery = SearchBoxReplaceDefaultValue(searchQuery);

            int v = 0;
            if ((bool)searchPastCourse) { v += 2; } //x
            if ((bool)searchPresentCourse) { v += 1; } //y

            switch (v)
            {
                case 0:
                case 3:
                    MessageBox.Show("Search everyone " + searchQuery);
                    break;
                case 1: // y is true
                    MessageBox.Show("Show past courses" + searchQuery);
                    break;
                case 2: // x is true
                    MessageBox.Show("Search current courses " + searchQuery);
                    break;
            }

        }


    }
}