using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models
{
    public class Customer
    {
        /// <summary>
        /// Written by Anh
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="postcode"></param>
        /// <param name="phoneNo"></param>
        /// <param name="email"></param>
        /// <param name="isDeleted"></param>
        public Customer(int id, string name, string address, int postcode, string phoneNo, string email, bool isDeleted) 
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.PostCode= postcode;
            this.PhoneNo = phoneNo;
            this.Email = email;
            this.IsDeleted = isDeleted;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PostCode { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
    }
}
