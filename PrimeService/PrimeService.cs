using System;

namespace Prime.Services
{
    public class Program
    {
        Student student = new Student();
        Teacher teacher = new Teacher();
        StrudentPay strudentPay = new StrudentPay();
        public void Main()
        {
            student.Age = 19;
            student.Name = "Александр";
            student.Surmane = "Александров";

            teacher.Name = "Николай";
            teacher.Surmane = "Николаевич";
            teacher.workExperirnce(2020);

            strudentPay.Age = 18;
            strudentPay.Name = "Петров";
            strudentPay.Surmane = "Петрович";
            strudentPay.whoPay(1500000);
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Surmane { get; set; }
        public int Age { get; set; }
        public int countBirthYear(int age)
        {
            return 2024 - age;
            throw new NotImplementedException("Please create a test.");
        }
    } 

    public class Teacher : Student
    {
        public string subjectOfStusy { get; set; }
        public int experirnce { get; set; }
        public int workExperirnce(int year)
        {
            return 2024 - year;
            throw new NotImplementedException("Please create a test.");
        }
    }

    public class StrudentPay : Student
    {
        public int whoPay(int pay)
        {
            return pay * 2;
        }
    }
}