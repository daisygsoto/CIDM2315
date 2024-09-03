namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        //Code for Homework1
        //The linear line equation is Z=4X^2 + 3Y; when X = 2.5, Y = 3.3
        decimal X = 2.5m;
        decimal Y = 3.3m;
        decimal Z = (4*(X*X))+(3*Y);

        Console.WriteLine("X = {0}, Y = {1}", X, Y);
        Console.WriteLine("The value of Z is {0}", Z);


    }
}
