using System;
namespace StudentRegistrationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Registration courseRegister = new Registration();
            Course course = courseRegister.RegisterStudent("maths", "John Doe", "Mathematical Science", 5.0);
            Console.WriteLine(courseRegister.GetCourses());
        }
    }





    class Registration
    {
        // initialize database
        StudentDB studentDB = new StudentDB();
        CourseDB courseDB = new CourseDB();


        // get all students
        public Student[] GetStudents()
        {
            return studentDB.GetAll();
        }


        // get all courses
        public Course[] GetCourses()
        {
            return courseDB.GetAll();
        }

        // register a student for a course
        public Course RegisterStudent(string courseName, string sName, string sDepartment, double sGpa)
        {

            Student? s = studentDB.Get(sName);
            Student student;
            Course course;

            // if student does not exist in database create student and add to database   
            if (s == null)
            {
                student = new Student(sName, sDepartment, sGpa);
                studentDB.AddStudent(student);
            }
            else
            {
                student = s;
            }


            Course? c = courseDB.Get(courseName);
            // if course does not exist in database create course and add to database   
            if (c == null)
            {
                course = new Course(courseName);

                courseDB.AddCourse(course);
            }
            else
            {
                course = c;
            }

            course.RegisterStudent(student);
            return course;
        }

    }

}
