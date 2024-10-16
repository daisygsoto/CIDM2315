namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
       Customer Alice = new Customer(input_cus_id: 110, input_cus_name:"Alice", input_cus_age:28 );
       Alice.PrintCusInfo();

       Customer Bob = new Customer(input_cus_id: 111, input_cus_name:"Bob", input_cus_age:30);
       Bob.PrintCusInfo();

       Alice.ChangeID(220);
       Alice.PrintCusInfo();

       Bob.ChangeID(221);
       Bob.PrintCusInfo();
       
       Alice.CompareAge(Bob);
    }
    class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;
    
    public Customer(int input_cus_id, string input_cus_name, int input_cus_age){
    cus_id = input_cus_id;
    cus_name = input_cus_name;
    cus_age = input_cus_age;
    }

    
    public void ChangeID(int input_new_id){
    cus_id = input_new_id;
    }

    
    public void PrintCusInfo(){
    Console.WriteLine($"Customer:{cus_id}, Name:{cus_name}, Age:{cus_age}");
    }
    public void CompareAge(Customer objCustomer){
        if(this.cus_age > objCustomer.cus_age){
            Console.WriteLine($"{this.cus_name} is older.");
        }
        else{
            Console.WriteLine($"{objCustomer.cus_name} is older.");
        }
    }

}
}
