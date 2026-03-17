# test-opp
นายปุณณภพ เเสนโสม 683450057-7
###  Class Diagram

```mermaid
classDiagram
    person <|-- student
    subject "1" *-- "many" student
    User --> subject : manages

    class person {
        +String FirstName
        +String LastName
    }

    class student {
        +String StudentId
        +Double Score
        +GetGrade() String
    }

    class subject {
        +String SubjectName
        +String SubjectCode
        +List~student~ StudentsInClass
        +subject(name, code)
    }

    class User {
        +subject currentSubject
        +OpenNewClass()
        +AddStudent()
        +ShowMaxMin()
        +ShowAll()
        +ShowAverage()
    }
      
