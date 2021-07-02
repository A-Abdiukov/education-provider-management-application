﻿namespace BusinessLayer
{
    /// <summary>
    /// Contains information about courses(attended by the student), course outcomes(received by a student) for a specific student ID.
    /// </summary>
    public class StudentResult
    {
        //CONSTRUCTOR

        /// <param name="StudentID">ID of Student e.g 17</param>
        /// <param name="CourseName">Name of the course the student attends e.g Certificate IV in Programming</param>
        /// <param name="CourseLocation">Name of the campus where course is delievered e.g Granville</param>
        /// <param name="Outcome">The outcome of the course for the student e.g Satsifactory</param>
        public StudentResult(int StudentID, string CourseName, string CourseLocation, string Outcome)
        {
            this.StudentID = StudentID;
            this.CourseName = CourseName;
            this.CourseLocation = CourseLocation;
            this.Outcome = Outcome;
        }

        //PROPERTIES
        public int StudentID { get; set; }
        public string CourseName { get; set; }
        public string CourseLocation { get; set; }
        public string Outcome { get; set; }
    }
}
