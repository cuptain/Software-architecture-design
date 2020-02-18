using System;

namespace Lab6_Proxy
{
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string BirthDate { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }    

        public string Address { get; set; }
    }
}