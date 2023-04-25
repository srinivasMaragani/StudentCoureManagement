using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    // Class for Student
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public Student(int studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }
    }

    // Class for Course
    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public Course(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }
    }

    // Class for Enrollment
    class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Enrollment(int enrollmentId, int studentId, int courseId)
        {
            EnrollmentId = enrollmentId;
            StudentId = studentId;
            CourseId = courseId;
        }
    }
}
