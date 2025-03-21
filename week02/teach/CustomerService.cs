﻿/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: Add one customer and then serve a customer
        // Expected Result: Display the customer and then delete the customer from the queue
        
        // Console.WriteLine("Test 1");
        // var service = new CustomerService(4);
        // service.AddNewCustomer();
        // service.ServeCustomer();

        // Defect(s) Found: customer is removed before he/she is served.

        Console.WriteLine("=================");

        // Test 2
        // Scenario: Customers A, B, and C come in the order and they are served in the same order.
        // Expected Result: A is served first, and then B.  the last to be served is C.
        
        // Console.WriteLine("Test 2");
        // service = new CustomerService(4);
        // service.AddNewCustomer();
        // service.AddNewCustomer();
        // Console.WriteLine($"Before serving customers: {service}");
        // service.ServeCustomer();
        // service.ServeCustomer();
        // Console.WriteLine($"After serving customers: ${service}");

        // Defect(s) Found: Nope

        Console.WriteLine("=================");

        // Test 3
        // Scenario: Provide service when there is no customer
        // Expected Result: Show error message

        // Console.WriteLine("Test 3");
        // service = new CustomerService(4);
        // service.ServeCustomer();

        // Defect(s) Found: No error message displayed when no customer.

        Console.WriteLine("=================");

        // Test 4
        // Scenario: User specifies the maximum size of -4, which is less than or equal to 0
        // Expected Result: default maximun size is 10
        
        // Console.WriteLine("Test 4");
        // var service = new CustomerService(-4);
        // Console.WriteLine(service);

        // Defect(s) Found: Nope

        // Test 5
        Console.WriteLine("Test 5");
        var service = new CustomerService(1);
        service.AddNewCustomer();
        service.AddNewCustomer();
        Console.WriteLine(service);
        // Defect Found: No error message when exceeding the max size
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count >= _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        if (_queue.Count > 0)
        {
        var customer = _queue[0];
        _queue.RemoveAt(0);
        Console.WriteLine(customer);
        } 
        else {
           Console.WriteLine("No customers in the queue"); 
        }
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}