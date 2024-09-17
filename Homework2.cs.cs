namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1: Input grade letters such that A:4, B:3, C:2, D:1, F:0
        // wrong letter print "Wrong Letter Grade!"
        Console.WriteLine("Please input a letter grade:  ");
        string letter = Console.ReadLine();
        
        if(letter == "A"){
            Console.WriteLine("GPA: 4");
        }
        else if (letter == "B"){
            Console.WriteLine("GPA: 3");
        }
        else if (letter == "C"){
            Console.WriteLine("GPA: 2");
        }
        else if (letter == "D"){
            Console.WriteLine("GPA: 1");
        }
        else if (letter == "F"){
            Console.WriteLine("GPA: 0");
        }
        else {
            Console.WriteLine("Wrong Letter Grade!");
        }
        // Code for Q2
        {
            Console.WriteLine("Please input the first num: ");
            string first_num = Console.ReadLine();
            Console.WriteLine("Please input the second num: ");
            string second_num = Console.ReadLine();
            Console.WriteLine("Please input the third num: ");
            string third_num = Console.ReadLine();
            

            int n1 = Convert.ToInt16(first_num);
            int n2 = Convert.ToInt16(second_num);
            int n3 = Convert.ToInt16(third_num);

            if(n1<n2){
                if(n1<n3){
                    Console.WriteLine($"The smallest value is: {n1}");
                }
                else{//n1>n3
                    Console.WriteLine($"The smallest value is: {n3}");
                }

            }
            else{//n2<n3
                    if(n2<n3){
                        Console.WriteLine($"The smallest value is: {n2}");
                    }
                    else{//n3<n2
                        Console.WriteLine($"The smallest value is: {n3}");
                    }
                }

        }

        // Code for Bouns Question 

    }
}
