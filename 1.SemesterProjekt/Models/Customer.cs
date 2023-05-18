using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models
{
    public class Customer
    {
        public Customer(int id, string name, string address, string phoneNo, string email, bool isDeleted) 
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.PhoneNo = phoneNo;
            this.Email = email;
            this.IsDeleted = isDeleted;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
    }
}
