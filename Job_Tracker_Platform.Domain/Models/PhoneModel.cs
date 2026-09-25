using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Domain.Models
{
    public class PhoneModel
    {
        public Guid Id { get; private set; }

        public string Number { get; private set; }

        public PhoneType Type { get; private set; }

        public Guid CustomerId { get; private set; }

        public User Customer { get; private set; }

        private PhoneModel() { }

        public PhoneModel(string number, PhoneType phoneType, Guid customerId)
        {
            if(number == null)
            {
                throw new ArgumentNullException(nameof(number));
            }

            if(phoneType == null)
            {
                throw new ArgumentNullException(nameof(phoneType));
            }
            
            if(customerId == null)
            {
                throw new ArgumentNullException(nameof(customerId));
            }

            Number = number;
            phoneType = phoneType;
            CustomerId = customerId;

        }
    }

    public enum PhoneType
    {
        Mobile,
        Home,
        Work,
        Other
    }
}
