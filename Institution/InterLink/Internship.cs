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

        public string GetStudentsNames() {
            Student[] studentsArray = GetStudents();
            string s = "[ ";
            if (studentsArray.GetLength(0) == 0) s = "";
            for (int i = 0;i < studentsArray.GetLength(0);i++) {
                if (studentsList.Count - 1 == i) {
                    s += studentsArray[i].GetName();
                    if (s.EndsWith(", ")) s = s.Remove(s.Length - 2);
                    s += " ]";
                } else { 
                    s += studentsArray[i].GetName();
                    s += ", ";
                }
            }
            return s;
        }

        public void AddStudentsFromUniversity(University university) {
            foreach (Student s in university.GetStudents()) {
                if (s.GetLevelOfKnowledge() > university.GetAverage()) {
                    studentsList.Add(s);
                }
            }
        }
    }
}
