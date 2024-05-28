
namespace _240401_01.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();    

        public string PrintToExportDelimited()
        {
            return $"{CustomerId};{Name};{EmailAddress}";
        }

        public override string ToString()
        {            
            return $"{CustomerId} - {this.Name} - {EmailAddress}";
        }
    }
}