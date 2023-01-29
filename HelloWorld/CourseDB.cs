namespace StudentRegistrationApp

{
    class CourseDB
    {
        public Course[] Courses = new Course[] { };




        // add Course to database
        public void AddCourse(Course c)
        {
            c.id = Courses.Length; 
            Courses.Append(c);


        }

        // get a Course by id
        public Course? Get(string name)
        {
            foreach (Course c in Courses)
            {
                if (c.name == name)
                {
                    return c;
                }
            }
            return null;
        }

        // get all Courses 

        public Course[] GetAll()
        {
            return Courses;
        }

        // update all Courses 

        public bool Update(int id, string aName)
        {
            Course c = new Course(aName);
            Courses[id] = c;
            return true;

        }
        // delete Course
        public bool Delete(int id)
        {
            Courses = Courses.Where(s => s.id != id).ToArray();
            return true;

        }
    }
}

