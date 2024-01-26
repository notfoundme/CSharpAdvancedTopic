using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// WAP to create a list of students where each students have
/// 1. name
/// 2. grade
/// Give all the students name that is in class 8
/// </summary>
namespace CaptainMarvel
{
    [Obsolete("use StudentModel2 instead")]
    class StudentModel
    {
        public string name;
        public int grade;

        public StudentModel(string name, int grade) {
            this.name = name;
            this.grade = grade;
        }
    }

    class StudentModel2
    {
        public string name;
        public int grade;

        public StudentModel(string name, int grade)
        {
            this.name = name;
            this.grade = grade;
        }
    }

    class LinQExample {
        public void exampleWithoutLinq() {
            StudentModel2 s1 = new StudentModel2("garima", 10);
            StudentModel s2 = new StudentModel("sulav", 8);
            StudentModel s3 = new StudentModel("ram", 9);
            StudentModel s4 = new StudentModel("laxman", 10);
            StudentModel s5 = new StudentModel("udaya", 8);
            StudentModel s6 = new StudentModel("tesula", 10);

            List<StudentModel> lsStudent = new List<StudentModel> { s1, s2, s3, s4, s5, s6 };

            foreach(StudentModel student in lsStudent)
            {
                if (student.grade == 8) {
                    Console.WriteLine(student.name);
                }
            }
        }

        public void exampleWithLinq()
        {
            StudentModel[] scores = new StudentModel[] { new StudentModel("garima", 10),
                new StudentModel("sulav", 8)
        };
            IEnumerable<StudentModel> scoresFiletered = from item in scores where item.name == "garima" select item;
            
            foreach (StudentModel i in scoresFiletered) {
                Console.WriteLine(i.name);
            }
        }

        public void exampleLinqBasicDatatype() {
            int[] scores = new int[] { 25, 95, 105 };
            IEnumerable<int> scoresFiletered = from item in scores where item > 90 select item;

            foreach (int i in scoresFiletered)
            {
                Console.WriteLine(i);
            }
        }
    }
}
