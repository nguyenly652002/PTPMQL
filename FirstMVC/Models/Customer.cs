using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FirstMVC.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
   

    }
}