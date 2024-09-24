namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
    //Code for Q1
    //Q1 (4 points): Write a C# method that:
    //takes as input 2 numbers and returns the largest one
    //call this method in Main() and print the result.
    Console.WriteLine("Enter a value for a: ");
    int a = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Enter a value for b: ");
    int b = Convert.ToInt16(Console.ReadLine());
    int returned_largest = LargestNum(a,b);
    Console.WriteLine($"The largest number is {returned_largest}");


    // call question2
    Console.WriteLine("Enter an integer N: ");
    int n = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Enter the side of a shape (left or right): ");
    string side = Console.ReadLine();
    Console.WriteLine($"N is:{n}; Shape is {side}");
    Question2(n,side);
    

    }
    static int LargestNum(int a, int b){
        int greatest = (a > b)? a:b;
        return greatest;
    }
    //Code for Q2
    //take as an integer number N and a shape (left or right); 
    //if the shape is left and N = 5, print values of N and shape, and a left-side triangle with 5 rows, like the following example:
    //if the shape is right and N = 5, print values of N and shape, and a right-side triangle with 5 rows, like the following example:
    static void Question2(int n, string side)
    {
        if (side == "left"){
            PrintLeftTri(n);
        }
        else{
            PrintRightTri(n);
        }
    }
    static void PrintLeftTri(int n){
        for(int i=1; i<=n; i++){
            for(int j=1; j<=i; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void PrintRightTri(int n)
    {
        for(int i=1; i<=n; i++){
            for(int j=1; j<= n - i;j++){
                Console.Write(" ");
            }
            for (int j =1; j<=i; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }    
}

