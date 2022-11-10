using System;

namespace ApiValidator.DTOs
{
    public class CreateCustomer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}
