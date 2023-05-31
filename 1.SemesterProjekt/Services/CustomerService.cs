using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Repositories;
using _1.SemesterProjekt.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1.SemesterProjekt.Service {
    public class CustomerService {
        private Database_Customer _database = new Database_Customer();

        public bool CreateCustomer(Customer customer) {

            if (customer.ID != 0) {
                LogService.LogError("Cannot create an already existing customer", nameof(CustomerService), nameof(CreateCustomer));
                return false;
            }

            if (string.IsNullOrWhiteSpace(customer.Name)) {
                LogService.LogError("A customer is required to have a name!", nameof(CustomerService), nameof(EditCustomer));
                return false;
            }

            return _database.CreateCustomer(customer);
        }


        /// <summary>
        /// Written by Ina
        /// Service layer method to update customer by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedCustomer"></param>
        /// <returns>true if customer is found and method call is successful</returns>
        public bool EditCustomer(Customer updatedCustomer) {
            if (updatedCustomer.ID == 0) {
                LogService.LogError("Cannot update not existing customer", nameof(CustomerService), nameof(EditCustomer));
                return false;
            }

            if (string.IsNullOrWhiteSpace(updatedCustomer.Name)) {
                LogService.LogError("A customer is required to have a name!", nameof(CustomerService), nameof(EditCustomer));
                return false;
            }

            return _database.UpdateCustomerInDatabase(updatedCustomer);


        }


        public List<Customer> ReadAllCustomers() {
            return _database.GetAllCustomers();
        }

        public List<Customer> ReadCustomersByName(string input, int? postcode = null) {
            List<Customer> customers = _database.GetCustomerByName(input);

            if (postcode != null) {
                return customers.Where(c => c.PostCode == postcode).ToList();
            }

            return customers;
        }

        public Customer ReadCustomerById(int id) {
            return _database.GetCustomerById(id);
        }

        public List<Customer> ReadCustomerByEmail(string email) {
            return _database.GetCustomerByEmail(email);
        }



        /// <summary>
        /// Written by Ina
        /// Update Customer details to set Is Deleted to true
        /// </summary>
        /// <param name="Customer"></param>
        /// <returns>true if customer is found and method call is successful</returns>
        public bool SetCustomerAsIsDeleted(Customer customer) {
            bool isUpdated = _database.MarkCustomerAsIsDeleted(customer);
            return isUpdated;
        }

        /// <summary>
        /// Written by Anh
        /// Service layer method to Delete customer by ID
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>return true if customer was succesfully deleted otherwise false</returns>
        public bool DeleteCustomer(Customer customer) {
            bool isDeleted = _database.DeleteCustomer(customer);
            return isDeleted;
        }
    }
}
