using SQLCoding;
using System;

class Program
{

    // Main Method
    static public void Main()
    {
        CustomerRepository customerRepository = new CustomerRepository();
        //customerRepository.GetCustomersData();
        customerRepository.GetCustomer(12);
        /*
        try
        {

            //Connection address from CustomerDBConfig class.                Not working?
            using SqlConnection connection = new SqlConnection(CustomerDBConfig.GetConnectionString());
            connection.Open();



            using SqlCommand command = new SqlCommand("SELECT * FROM Professor", connection);
            using SqlDataReader myReader = command.ExecuteReader();

            while (myReader.Read())
            {

            }
            catch (SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        */
    }

}
