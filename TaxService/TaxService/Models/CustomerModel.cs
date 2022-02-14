using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TaxService.Models
{
    public class CustomerModel
    {
        public long CustomerID { get; set; }

        public Guid CustomerCode { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required, Remote("IsEmailAvailable", "Customers", AdditionalFields = "CustomerID", ErrorMessage = "This email address is already registered. Please try a different one."), DataType(DataType.EmailAddress), RegularExpression(GlobalSettings.RegularExpressions.EmailAddresses, ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? CreatedBy { get; set; }

        public CustomerModel() { }

        public CustomerModel(Customer customer)
        {
            CustomerID = customer.CustomerID;
            CustomerCode = customer.CustomerCode;
            Name = customer.Name;
            Email = customer.Email;
            CreatedDate = customer.CreatedDate;
            ModifiedDate = customer.ModifiedDate;
            CreatedBy = customer.CreatedBy;
        }

        public Customer GetNewCustomer()
        {
            return new Customer
            {
                CustomerCode = Guid.NewGuid(),
                Name = Name,
                Email = Email,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                CreatedBy=CreatedBy
            };
        }

        public Customer UpdateCustomer()
        {
            return new Customer
            {
                CustomerID = CustomerID,
                CustomerCode = CustomerCode,
                Name = Name,
                Email = Email,
                CreatedDate = CreatedDate,
                ModifiedDate = DateTime.Now,
                CreatedBy=CreatedBy
               
            };
        }

    }
}