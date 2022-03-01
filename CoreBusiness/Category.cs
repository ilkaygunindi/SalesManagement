using System;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
