using InternshipTest.Person;
using InternshipTest.Institution.InterLink;
using System;
using System.Collections;
using System.Collections.Generic;

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

        public int GetAverage() {
            int allLevels = 0;
            List<int> levelsOfKnowledge = GetStudentsKnowledge();
            for (int i = 0; i < levelsOfKnowledge.Count; i++) allLevels += levelsOfKnowledge[i];
            return (int) allLevels/levelsOfKnowledge.Count;//TODO: Math.Round()
        }

        public Student[] GetStudentsAsArray() {
            return studentsList.ToArray(typeof(Student)) as Student[];
        }

        public ArrayList GetStudents() {
            return studentsList;
        }

        public string GetStudentsNames() {
            Student[] studentsArray = GetStudentsAsArray();
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

        public List<int> GetStudentsKnowledge() {
            List<int> studentsLevelOfKnowledge = new List<int>();
            Student[] studentsArray = GetStudentsAsArray();
            for (int i = 0;i < studentsArray.GetLength(0);i++) {
                studentsLevelOfKnowledge.Add(studentsArray[i].GetLevelOfKnowledge());
            }
            return studentsLevelOfKnowledge;
        }
    }
}
