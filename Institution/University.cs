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
    }
}
