using ApiValidator.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiValidator.DTOs
{
    public class CreateCustomer : IValidatableObject
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateofBirth { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var errors = new List<ValidationResult>();

            if (!ValidateEmail.IsValidEmail(Email))
                errors.Add(new ValidationResult($"{nameof(Email)}: Email inválido.", new[] { nameof(Email) }));

            if (string.IsNullOrEmpty(Name))
                errors.Add(new ValidationResult($"{nameof(Name)}: El nombre no puede ser nulo.", new[] { nameof(Name) }));

            if (Name.Length < 3)
                errors.Add(new ValidationResult($"{nameof(Name)}: El nombre debe tener al menos 3 caracteres.", new[] { nameof(Name) }));

            var diffDays = (DateTime.Now - DateofBirth).TotalDays;
            var age = Math.Truncate(diffDays / 365);
            if (age <= 18)
            {
                errors.Add(new ValidationResult($"{nameof(DateofBirth)}: Es menor de edad.", new[] { nameof(DateofBirth) }));
            }

            return errors;
        }
    }
}
