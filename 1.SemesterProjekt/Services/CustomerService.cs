using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1.SemesterProjekt.Service 
{
    public class CustomerService 
    {
        private Database _database = new Database();

        /// <summary>
        /// Written by Ina
        /// Service layer method to update customer by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedCustomer"></param>
        /// <returns>true if customer is found and method call is successful</returns>
        public bool EditCustomerByID(string id, Customer updatedCustomer) 
        { 
            bool isUpdated = _database.UpdateCustomerByID(id, updatedCustomer);
            return isUpdated;
        }



        public List<Customer> ReadCustomersByName(string input) {
            return _database.GetCustomerByName(input);
        }


        /// <summary>
        /// Written by Ina
        /// Update Customer details to set Is Deleted to true
        /// </summary>
        /// <param name="Customer"></param>
        /// <returns>true if customer is found and method call is successful</returns>
        public bool IsDeletedCustomerByID(Customer Customer)
        {
            bool isUpdated = _database.IsDeletedCustomerByID(Customer);
            return isUpdated;
        }

        /// <summary>
        /// Written by Anh
        /// Service layer method to Delete customer by ID
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>return true if customer was succesfully deleted otherwise false</returns>
        public bool DeleteCustomerById(Customer customer)
        {
            bool isDeleted = _database.DeleteCustomerById(customer);
            return isDeleted;
        }
    }
}
