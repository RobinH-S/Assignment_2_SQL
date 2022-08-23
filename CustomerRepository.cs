using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SQLCoding
{
    public class CustomerRepository : ICustomerRepository<Customer>
    {

        //Returns list of rows have been affected by query, false if rows affected = 0
        public List <Customer> GetCustomersData()
        {
            List<Customer> customers = new ();

            try
            {
                //Connection address from CustomerDBConfig class.                Not working?
                using SqlConnection conn = new SqlConnection(CustomerDBConfig.GetConnectionString());
                conn.Open();
            
                string sql = "Select CustomerId, FirstName, LastName, Country, PostalCode, Phone FROM Customer";
                //string sql1 = "SELECT * From Customer ";
                //Running sql query on Table at conn address
                using SqlCommand command = new SqlCommand(sql, conn);
                using SqlDataReader myReader = command.ExecuteReader();

                //Looping through all columns to a
                while (myReader.Read())
                {


                    Console.WriteLine(myReader.GetInt32(0));
                    for (int i = 1; i < myReader.FieldCount; i++)
                    {
                        if (!myReader.IsDBNull(i))
                        { Console.WriteLine(myReader.GetString(i)); }
                        else
                        { Console.WriteLine("NULL"); }
                    }

                    Customer customer = new ()
                    {
                        Id = myReader.GetInt32(0),
                        FirstName = myReader["FirstName"].ToString(),
                        LastName = myReader["LastName"].ToString(),
                        Country = myReader["Country"].ToString(),
                        PostalCode = myReader["PostalCode"].ToString() ,
                        Phone = myReader["Phone"].ToString(),
                    };
                    //Console.WriteLine(myReader.GetString(1));

                    customers.Add(customer);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return customers;
        }


        //Adding data to intances of costumer data, and appending instance to a list

        /*

        Console.WriteLine(command.ExecuteNonQuery() + "Rows effected of query");
                //return command.ExecuteNonQuery() > 0;
            }


            //Catch exceptions from Warrens Example
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;

        }
        */

        public Customer GetCustomer(int custId)
        {
            List<Customer> g = GetCustomersData();
            Console.WriteLine(g.ElementAt(custId));
            return g.ElementAt(custId);
            /*
            //Connection address from CustomerDBConfig class.                Not working?
            using SqlConnection conn = new SqlConnection(CustomerDBConfig.GetConnectionString());
            conn.Open();
            string sql = "Select CustomerId, FirstName, LastName, Country, PostCode, Phone  FROM Customer WHERE id = ";

            //Running sql query on Table at conn address
            using SqlCommand command = new SqlCommand(sql, conn);

            using SqlDataReader myReader = command.ExecuteReader();


            //Returns 
            Customer cust = new();
            */
        }
        //Returns boolean true if rows have been affected by query, false if rows affected = 0
        public bool DeleteCustomer(Customer customer)
        {

            /* Mal til Query
            string sql = "SELECT * From Customer ";
            //Running sql query on Table at conn address
            using (SqlCommand command = new SqlCommand(sql, conn))

            //Console.WriteLine(command.ExecuteNonQuery() + "Rows effected of query");
            return command.ExecuteNonQuery() > 0;
            */
            throw new NotImplementedException();
        }

        /*
        public List<Customer> GetAllCustomers()
        {
            List<Customer> Customers = new ();
            return Customers;
        }
        */
        public bool UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool ReadData(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomerData(int limit, int offset)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int custId)
        {
            throw new NotImplementedException();
        }
    }
}

//CRUD
//Create connection
//Set up our SQL
//Excecute query on DB
//Handle results
