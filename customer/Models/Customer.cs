namespace customer.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EMailAddress{ get; set; } = string.Empty;
        public string MobilPhoneNumber { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;



    }
}
