﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models
{
    public class Glasses : Product
    {
        /// <summary>
        /// Written by Anh
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="brand"></param>
        /// <param name="price"></param>
        /// <param name="stock"></param>
        /// <param name="strength"></param>
        /// <param name="glassType"></param>
        /// <param name="coating"></param>
        /// <param name="isSunglasses"></param>
     public Glasses(int id, string name, string brand, decimal price, int stock, double strength, string glassType, string coating, bool isSunglasses) : base(id, name, brand, price, stock)
        {
            Strength = strength;
            GlassType = glassType;
            Coating = coating;
            IsSunglasses = isSunglasses;
        }

        public double Strength { get; set; }
        public string GlassType { get; set; }
        public string Coating { get; set; }
        public bool IsSunglasses { get; set; }

    }
}
