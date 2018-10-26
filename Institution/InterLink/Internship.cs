using System.Collections;
using InternshipTest.Person;
using System;

namespace InternshipTest.Institution.InterLink {
    public class Internship {
        private ArrayList studentsList = new ArrayList();
        private string name;
        public Internship(string name) {
            this.name = name;
        }

        public Student[] GetStudents() => studentsList.ToArray(typeof(Student)) as Student[];

        public void PrintStudentsNames() {
            foreach (Student student in studentsList)
                Console.WriteLine(student.GetName());
        }
    }
}
