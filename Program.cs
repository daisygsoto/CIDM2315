namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(customerName:"Alice", customerAge:33, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus2 = new Customer(customerName:"Bob", customerAge:23, customerCity:"Amarillo", customerCredit:226);
        Customer cus3 = new Customer(customerName:"Cathy", customerAge:45, customerCity:"Amarillo", customerCredit:89.0);
        Customer cus4 = new Customer(customerName:"David", customerAge:58, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus5 = new Customer(customerName:"Jack", customerAge:28, customerCity:"Canyon", customerCredit:561.6);
        Customer cus6 = new Customer(customerName:"Tom", customerAge:36, customerCity:"Canyon", customerCredit:98.4);
        Customer cus7 = new Customer(customerName:"Tony", customerAge:24, customerCity:"Canyon", customerCredit:18.5);
        Customer cus8 = new Customer(customerName:"Sam", customerAge:35, customerCity:"Canyon", customerCredit:228.3);
        Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};

         // call Q1 method
        TotalCredits(customer_list);
        // call Q2 method
        AmarilloAverageAge(customer_list);
        // call Q3 method
        CanyonAge(customer_list); 
    }

    public static void TotalCredits(Customer[] customer_list){
        double totalCredits = 0;
        foreach(var Customer in customer_list){
            totalCredits += Customer.customerCredit;
        }
        Console.WriteLine($"Q1:The total credits: {totalCredits} ");

    }
    public static void AmarilloAverageAge(Customer[] customer_list){
        double totalAmarilloAverageAge = 0;
        double count = 0;
        foreach(var Customer in customer_list){
            if(Customer.customerCity == "Amarillo")
            {
                totalAmarilloAverageAge += Customer.customerAge;
                count++;
            }
        }
        double averageAge = count > 0 ? totalAmarilloAverageAge / count : 0;
        Console.WriteLine($"Q2: The average age in Amarillo: {averageAge}");
    }
    public static void CanyonAge(Customer[] customer_list){
        Console.WriteLine("Q3: Customers who live in Canyon and over 30 years old:");
        foreach (var Customer in customer_list)
        {
            if(Customer.customerCity == "Canyon" && Customer.customerAge > 30){
                Console.WriteLine(Customer.customerName);
            
            }
        }
        
    }

}

    class Customer
    {
        public string customerName {get; set;} = string.Empty;
        public int customerAge {get; set;} = 0;
        public string customerCity {get;set;} = string.Empty;
        public double customerCredit {get;set;} = 0;
        //constructor
        public Customer(string customerName, int customerAge, string customerCity, double customerCredit){
            this.customerName = customerName;
            this.customerAge = customerAge;
            this.customerCity = customerCity;
            this.customerCredit = customerCredit;
        }
    }
 