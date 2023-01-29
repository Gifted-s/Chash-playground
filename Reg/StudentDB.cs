namespace StudentRegistrationApp

{
    class StudentDB
    {
        public Student[] Students = new Student[] { };

        // add student to database
        public void AddStudent(Student student)
        {
            student.id = Students.Length;
            Students.Append(student);
        }

        // get a student by id
        public Student? Get(string name)
        {
            foreach (Student s in Students)
            {
                if (s.name == name)
                {
                    return s;
                }
            }
            return null;
        }

        // get all students 

        public Student[] GetAll()
        {
            return Students;
        }

        // update all students 

        public bool Update(int id, string aName, string aDepartment, double aGpa)
        {
            Student s = new Student(aName, aDepartment, aGpa);
            Students[id] = s;
            return true;

        }
        // delete student
        public bool Delete(int id)
        {
            Students = Students.Where(s => s.id != id).ToArray();
            return true;

        }
    }
}

