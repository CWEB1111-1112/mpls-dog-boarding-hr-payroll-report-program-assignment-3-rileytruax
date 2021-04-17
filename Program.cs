using System;
//Riley Truax 4/16/21
namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Global Declarations
            int numOfDays, serviceTotal;
            string dogName, services, kindOfService, name;


            Console.WriteLine("Welcome to Minneapolis Dog Boarding.");
            Console.WriteLine("Please enter your name:");
            name = (Console.ReadLine());
            
            Console.WriteLine($"Hello {name}! What is your dog's name?");
            dogName = Console.ReadLine();
            
            Console.WriteLine("How many days will your dog be staying with us?");
            numOfDays = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Would you like to add additional services?");
            services = Console.ReadLine();
            while(services != "No" || services != "Yes"){
                Console.WriteLine("Invalid response, please enter 'Yes' or 'No'.");
                Console.WriteLine("Would you like to add additional services?");
                services = Console.ReadLine();
                if(services == "No" || services =="Yes"){
                    break;
                }
            }
                if(services == "No"){
                    serviceTotal = computeRate1(numOfDays);
                    Console.WriteLine($"{dogName} will be staying with us for {numOfDays} days and will not receive any additional services. That brings your total to ${serviceTotal}. Have a good day!");
                }
                if(services == "Yes"){
                    Console.WriteLine($"Which services would you like to include?");
                    Console.WriteLine($"Please use 'A' for bathing and grooming or 'C' for only bathing");
                    kindOfService = Console.ReadLine();
                    while(kindOfService != "A" || kindOfService != "C"){
                        Console.WriteLine("Please use 'A' for bathing and grooming or 'C' for only bathing");
                        kindOfService = Console.ReadLine();
                        if(kindOfService == "A" || kindOfService == "C"){
                            break;
                        }
                    }
                        if(kindOfService == "A"){
                        serviceTotal = computeRate2(numOfDays, kindOfService);
                        Console.WriteLine($"{dogName} will be staying with us for {numOfDays} days and will receive the bathing and grooming service (A). That brings your total to ${serviceTotal}. Have a good day!");
                        }else if(kindOfService == "C"){
                        serviceTotal = computeRate2(numOfDays, kindOfService);
                        Console.WriteLine($"{dogName} will be staying with us for {numOfDays} days and will receive the bathing service (C). That brings your total to ${serviceTotal}. Have a good day!");
                        }   
                }  
        }

        //Overloaded mehod with one argument
        static int computeRate1(int numOfDays){
            int total = numOfDays * 75;
            return total;
        }

        //Overloaded method with two arguments
        static int computeRate2(int numOfDays, string kindOfService){
            int total;
            total = 0;
            if(kindOfService == "A"){
                total = numOfDays * 169;
            }else if(kindOfService == "C"){
                total = numOfDays * 112;
            }
            return total;   
        }
       
    }
}
