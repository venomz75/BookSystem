﻿using System;

namespace BookClasses
{
    public class clsCustomers
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int CustomerID { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}