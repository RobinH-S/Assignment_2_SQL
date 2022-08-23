namespace SQLCoding
{
    public interface ICustomerRepository <Customer>
    {
        public List<Customer> GetCustomersData();         //Get all costumers from database table costumer. Takes int costumers id as parameter (Task1)
        public bool AddCustomer(Customer customer);                       // Adds a new Costumer object to the database.  (task 5)

        /// <summary>
        /// Takes a customer object as parameter
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool ReadData(Customer customer);                         //
        public List<Customer> GetCustomerData(int limit, int offset);     //Get subset of all costumers with wanted columns. Takes int limit and int ofset as parameter  (Task4)
        public Customer GetCustomerById(int custId);                      //Get specific costumer. Takes int costumers id as parameter (task 2)
        public bool DeleteCustomer(Customer customer);
        public bool UpdateCustomer(Customer customer);                  // (Task 6)



    }
}
