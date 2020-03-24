using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Karacadir.Northwind.Entities.Concrete
{
    public class ShippingDetails
    {
        //[Required(ErrorMessage = "* Ad bilgisi girmediniz!")]
        public string FirstName { get; set; }
        //[Required(ErrorMessage = "* Soyad bilgisi girmediniz!")]
        public string LastName { get; set; }
        //[Required(ErrorMessage = "* E-posta bilgisi girmediniz!")]
        [DataType(DataType.EmailAddress)]
        //[MinLength(5)]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "* Şehir bilgisi girmediniz!")]
        public string City { get; set; }
        //[Required(ErrorMessage = "* Adres bilgisi girmediniz!")]
        public string Address { get; set; }
        //[Required]
        //[Range(18, 150)]
        //public int Age { get; set; }
    }
}
