

using PracticeOOP;

//Creating an instance of the Student class
Student myStudent1 = new Student("Sean Adeyemi", 30);

//Calling the ShowStudentDetails method
myStudent1.ShowStudentDetails();
myStudent1.ShowGraduationStatus();

Console.WriteLine();
myStudent1.UpdateGrade(80);

Console.WriteLine();

//Creating an instance of the PostGraduate class
PostGraduate myPostGraduate1 = new PostGraduate("Jessica Philip", 90);


myPostGraduate1.ShowThesisStatus();

Console.WriteLine();

myPostGraduate1.ShowGraduationStatus();