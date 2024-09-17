namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //Code for Q1
        //takes as input a number N, if the number N is a prime number, print “N is prime”, else print “N is non-prime”.
        Console.WriteLine("Input an integer:  ");
        int num = Convert.ToInt16(Console.ReadLine());
        while(num>0){
            if(num%2 == 0 && num>1){
                Console.WriteLine($"{num} is non-prime");
            }
            else{
                Console.WriteLine($"{num} is prime");
            }
            num--;
        }
    
        

        //Code for Q2
        Console.WriteLine("Assign an int value to N:  ");
        int n1= Convert.ToInt16(Console.ReadLine());
        for (int row=0; row<n1; row++){
            for(int col=0; col<n1; col++)
        {
            Console.Write('*');
        }
            Console.WriteLine("");
        }
        //Code for Q3
        Console.WriteLine("Assign an int value to N: ");
        int n2 = Convert.ToInt16(Console.ReadLine());
        for (int row=0; row<n2; row++){
            for(int col=0; col<n2; col++)
            {
                if(row<=col)
                Console.Write('*');
            }
            Console.WriteLine("");
        }
    }
}    





