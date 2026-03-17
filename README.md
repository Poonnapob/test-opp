# test-opp
ายปุณณภพ เเสนโสม 683450057-7
classDiagram
    %% Inheritance: student inherits from person
    person <|-- student
    
    %% Composition: subject contains a list of students
    subject "1" *-- "many" student
    
    %% Association: User manages subject
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
