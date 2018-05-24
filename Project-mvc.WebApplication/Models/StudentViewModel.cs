using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Project_mvc.WebApplication.Models
{
    public class StudentViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Uzupelnij pole name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Surname { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public string SelectedProvince { get; set; }
        public IEnumerable<SelectListItem> Provinces { get; set; }
    }
}