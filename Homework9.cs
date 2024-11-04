namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        var student1 = new Student (111, "Alice");
        var student2 = new Student (222, "Bob");
        var student3 = new Student (333, "Cathy");
        var student4 = new Student (444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>{
            {"Alice", 4.0},
            {"Bob", 3.6},
            {"Cathy", 2.5},
            {"David", 1.8}
        };

        if(!gradebook.ContainsKey("Tom")){
            gradebook["Tom"] = 3.3;
        }
        double averageGPA = gradebook.Values.Average();
        Console.WriteLine($"Average GPA: {averageGPA} ");

        foreach(var student in Student.studentList)
        {
            string name = student.GetstudentName();
            if (gradebook.ContainsKey(name) && gradebook[name] > averageGPA){
                student.PrintInfo();
            }
        }
    }

}


class Student 
{
private int studentID;
public int GetstudentID(){
    return studentID;
}
public void SetstudentID(int newID){
    studentID = newID;
}
private string studentName;
public string GetstudentName(){
    return studentName;
}
public void SetstudentName(string newName){
    studentName = newName;
}
//to print student ID and name
public void PrintInfo(){
    Console.WriteLine($"Student's ID: {studentID}, Student's Name: {studentName}");
} 
public static List<Student> studentList = new List<Student>();
public Student(int studentID, string studentName){
    this.studentID = studentID;
    this.studentName = studentName;
    studentList.Add(this);
}  
}
