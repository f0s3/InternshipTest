using InternshipTest.Person;
using System;
using System.Collections;

namespace InternshipTest.Institution {
    public class University {
        private ArrayList studentsList = new ArrayList();
        string name;
        public University(string name) {
            this.name = name;  
        }

        public void AddStudent(Student student) {
            studentsList.Add(student);
        }

        public Student[] GetStudents() {
            return studentsList.ToArray(typeof(Student)) as Student[];
        }

        public void PrintStudentsNames() {
            foreach (Student student in studentsList)
                Console.WriteLine(student.GetName());
        }
    }
}
