using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Domain.Models
{
    public class User
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }

        private User() { }

        public User(Guid id, string firstName, string lastName, DateTime dateOfBirth)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("FirstName is required");

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("LastName is required");

            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public int GetAge()
        {
            var today = DateTime.UtcNow;
            var age = today.Year - DateOfBirth.Year;

            if (DateOfBirth.Date > today.AddYears(-age))
                age--;

            return age;
        }

        public void updateuser(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public void UpdateFirstName(string firstName)
        {
            FirstName = firstName;
        }
    }
}
