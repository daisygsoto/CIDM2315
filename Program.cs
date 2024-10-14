namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1 and Q2
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        p1.printInfoP();
        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary (8000);
        p2.printInfoP();

        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.SetGrade(90);
        s1.printInfoS();
        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80);
        s2.printInfoS();

        double diffSalary = p1.GetSalary() - p2.GetSalary();
        double totalGrade = s1.GetGrade() + s2.GetGrade();

        Console.WriteLine($"The difference salary between Alice and Bob is: {diffSalary}");
        Console.WriteLine($"The total grade of Lisa and Tom are: {totalGrade}");
    }

    class Professor
    {
        public string profName;
        public string classTeach;
        private double salary; 

        public void printInfoP(){
        Console.WriteLine($"Professor {profName} teaches {classTeach} and the salary is: {GetSalary()}");
        }
        public void SetSalary(double salary_amount){
            salary = salary_amount;
        }
        public double GetSalary(){
            return salary; 
        }  
    }
    
    class Student
    {
        public string studentName;
        public string classEnroll;
        private double studentGrade;

        public void SetGrade(double newGrade){
            studentGrade = newGrade;
        }
        public double GetGrade(){
            return studentGrade;
        }
        public void printInfoS(){
        Console.WriteLine($"Student {studentName} enrolled in {classEnroll} and the grade is: {GetGrade()}");
        }
    }
}
