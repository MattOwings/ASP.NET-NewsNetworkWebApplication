using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_BloggingNewsSite.Models
{
    public class FinalProject_BloggingNewsSiteModel
    {
        [Key]
        public int ItemID { get; set; }
        [Required(ErrorMessage = "Enter a Title for the Work")]
        public string Title { get; set; } 
        [Required(ErrorMessage = "Enter the Author of the Work")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Enter the Date of the Work")]
        public string Date { get; set; }
        [Required(ErrorMessage = "Enter the Body text of the Work")]
        public string Body { get; set; }
        [Required(ErrorMessage = "Provide a Short Summary of the Work")]
        public string Summary { get; set; }
        public string Link { get; set; }

    }
}
