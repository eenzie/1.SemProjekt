using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Service 
{
    public class CustomerService 
    {
        /// <summary>
        /// Written by Ina
        /// Service layer method to update customer by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedCustomer"></param>
        /// <returns>true if customer is found and method call is successful</returns>
        public bool EditCustomerByID(string id, Customer updatedCustomer) 
        { 
            Database database = new Database();
            bool isUpdated = database.UpdateCustomerByID(id, updatedCustomer);
            return isUpdated;
        }

        /// <summary>
        /// Update Customer details to set Is Deleted to true
        /// </summary>
        /// <param name="Customer"></param>
        /// <returns>true if customer is found and method call is successful</returns>
        public bool IsDeletedCustomerByID(Customer Customer)
        {
            Database database = new Database();
            bool isUpdated = database.IsDeletedCustomerByID(Customer);
            return isUpdated;
        }
    }
}
