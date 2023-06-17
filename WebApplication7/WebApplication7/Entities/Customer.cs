using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace WebApplication7.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string CustomerFirstName { get; set; }

        public string CustomerLastName { get; set; }

        public char CustomerGender { get; set; }


        public DateTime CustomerDOB { get; set; }


        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }

}

}
