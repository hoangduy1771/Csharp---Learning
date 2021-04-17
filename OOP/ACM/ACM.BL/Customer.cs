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

        public string FirstName { get; set; } // auto implemented propety - the backing field is auto implemented


        private string _lastName; // backing field
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

    }
}
