using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId) // this Constructor is created for the unit test
        {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; } // auto implemented propety


        private string _lastName;
        public string LastName { get => _lastName; set => _lastName = value; } // property

        public string Fullname
        {
            get
            {
                string fullName = LastName;

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += " ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        /// <summary>
        /// Validate the customer data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Saves current customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves defined customer

            return true;
        }

        /// <summary>
        /// Retrieve one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // Codes retrieves the defines customer

            return new Customer();
        }

        /// <summary>
        /// Retrieve all customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

    }
}
