using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistedProjectsOn_OOPS
{

    struct Student
    {
        public int Assessment;
        public string Name;
        public string Class;
        public string Section;
    }
    struct Teacher
    {
        public string ReferenceMaterials;
        public string Name;
        public string ExamPreparation;
        public string Documents;
        public string Class;
        public string Section;
    }
    struct Subject
    {
        public string Books;
        public int SubjectCode;
        public string Name;
        public string LabGuides;
        public Teacher AssignedTeacher;
    }
    class Classes
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            List<Subject> subjects = new List<Subject>();

            students.Add(new Student
            {
                Assessment = 1,
                Name = "Dinesh",
                Class = "6",
                Section = " A"
            });
            students.Add(new Student
            {
                Assessment = 2,
                Name = "Madhuri",
                Class = "12",
                Section = "B"
            });
            teachers.Add(new Teacher
            {
                ReferenceMaterials = "Materials 1",
                Name = "Teacher 1",
                ExamPreparation = "Preparation 1",
                Documents = "Docs 1",
                Class = "10",
                Section = "A"
            });
            teachers.Add(new Teacher
            {
                ReferenceMaterials = "Materials 2",
                Name = "Teacher 2",
                ExamPreparation = "Preparation 2",
                Documents = "Docs 2",
                Class = "12",
                Section = "B"
            });

            subjects.Add(new Subject
            {
                Books = "Books 1",
                SubjectCode = 101,
                Name = "Kannada",
                LabGuides = "Guides 1",
                AssignedTeacher = teachers[0]
            });
            subjects.Add(new Subject
            {
                Books = "Book2",
                SubjectCode = 102,
                Name = "English",
                LabGuides = "Guides 2",
                AssignedTeacher = teachers[1]
            });

            // Print students
            Console.WriteLine("Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"Assessment: {student.Assessment}, Name: {student.Name}, Class: {student.Class}, Section: {student.Section}");
            }

            // Print teachers
            Console.WriteLine("\nTeachers:");
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"Name: {teacher.Name}, Class: {teacher.Class}, Section: {teacher.Section}");
            }

            // Print subjects
            Console.WriteLine("\nSubjects:");
            foreach (var subject in subjects)
            {
                Console.WriteLine($"Subject Code: {subject.SubjectCode}, Name: {subject.Name}, Books: {subject.Books}, Lab Guides: {subject.LabGuides}");
                Console.WriteLine($"Assigned Teacher - Name: {subject.AssignedTeacher.Name}, Class: {subject.AssignedTeacher.Class}, Section: {subject.AssignedTeacher.Section}\n");
            }


            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}