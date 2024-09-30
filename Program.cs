namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
    //Code for Q1
    Console.WriteLine("Enter a value for a: ");
    int a = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Enter a value for b: ");
    int b = Convert.ToInt16(Console.ReadLine());
    int returned_largestab = LargestNum(a,b);
    Console.WriteLine($"The largest number is {returned_largestab}");



    //call for Code Q2
    Console.WriteLine("Enter a value for A: ");
    int A = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Enter a value for B: ");
    int B = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Enter a value for C: ");
    int C = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Enter a value for D: ");
    int D = Convert.ToInt16(Console.ReadLine());
    int returned_largestq2 = Question2(A,B,C,D);
    Console.WriteLine($"The largest number is {returned_largestq2}");



    //call for Code Q3
    Console.WriteLine("Please enter your username:    ");
    string user_name = Console.ReadLine();
    Console.WriteLine("Please enter your password:    ");
    string pass_word = Console.ReadLine();
    Console.WriteLine("Please enter password again:   ");
    string pass_word2 = Console.ReadLine();
    Console.WriteLine("Please enter your birthyear:   ");
    int birth_year = Convert.ToInt16(Console.ReadLine());
    createAccount(user_name, pass_word, pass_word2, birth_year);

  
    }
      //Code for Q1
      //Write a C# method that:
      //takes as input 2 numbers and returns the largest one
      //call this method in Main() and print the result.
    static int LargestNum(int a, int b){
        int greatest;
        if(a<b){
            return b;
        }
        else{
            return a;
        }
    }   
    /*Code for Q2
    get 4 integers as inputs from the keyboard
    and returns the largest one
    you should use the method from Q1 to solve this exercise. (You will lose 2 points if you didn’t use the method from Q1 to answer this question)
    call this method in Main() and print the result.*/
    static int Question2(int A, int B, int C, int D){
        int max1 = LargestNum(A,B);
        int max2 = LargestNum(C,D);
        int max = LargestNum(max1, max2);
        return max;
    }
    //Code for Q3
    static bool checkAge(int birth_year){
	// calculate the age based on the birth_year (age = current_year - birth_year)
    int current_year = 2024;
    int age = current_year - birth_year;
    if (age>=18){
        return true;
    }
    else{
        return false;
    }
    }
    static void createAccount(string user_name, string pass_word, string pass_word2, int birth_year){
    if(checkAge(birth_year))
    {
        if(pass_word == pass_word2)
        {
        Console.WriteLine("Account is created successfully!");
        }
        else
        {
            Console.WriteLine("Wrong Password");
        }
    }
    else
    {
        Console.WriteLine("Could not create an account!");
    }
    }
}   

    

    

    

 
