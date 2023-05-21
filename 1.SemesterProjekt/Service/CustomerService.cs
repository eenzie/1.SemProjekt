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
        public bool EditCustomerByID (string id, Customer updatedCustomer)
        {
            Database database = new Database();
            bool isUpdated = database.UpdateCustomerByID(id, updatedCustomer);
            return isUpdated;
        }

    }
}
