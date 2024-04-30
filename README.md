# UnitTest
``` mermaid
classDiagram
    class Student {
        +String Name
        +String Surname
        +int Age
        +int countBirthYear(int age)
    }

    class Teacher {
        +String Name
        +String Surname
        +String SubjectOfStudy
        +int Experience
        +int WorkExperience(int year)
    }

    class StudentPay {
        +String Name
        +String Surname
        +int WhoPay(int pay)
    }

    class Program {
        -Student student
        -Teacher teacher
        -StudentPay studentPay
        +void Main()
    }

    Student --|> Teacher
    Student --|> StudentPay
    Program -- Student 
    Program -- Teacher 
    Program -- StudentPay 
```
