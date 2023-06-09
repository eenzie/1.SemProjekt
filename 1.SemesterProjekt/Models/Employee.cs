﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models
{
    public class Employee
    {
        /// <summary>
        /// Written by Anh
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="shopID"></param>
        public Employee(int id, string name, string phone, Shop shop) 
        {
            this.ID = id;
            this.Name = name;
            this.Phone = phone;
            this.Shop = shop;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Shop Shop { get; set; }

        public override string ToString() {
            return Name;
        }
    }
}
