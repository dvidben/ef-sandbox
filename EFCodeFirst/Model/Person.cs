using System;
using System.Collections.Generic;

namespace EFCodeFirst.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
