﻿using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest {
    class Program {
        static void Main(string[] args) {
            var alex = new Student("Alex");
            alex.SetKnowledge(new Knowledge(5));
            University university = new University("CH.U.I.");
            university.AddStudent(new Student("Andrew Kostenko", new Knowledge(4)));
            university.AddStudent(new Student("Julia Veselkina", new Knowledge(7)));
            university.AddStudent(new Student("Maria Perechrest"));
            university.AddStudent(alex);

            Internship internship = new Internship("Interlink");
            internship.AddStudentsFromUniversity(university);
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudentsNames());
            Console.WriteLine("List of university students:");
            Console.WriteLine(university.GetStudentsNames());
        }
    }
}
