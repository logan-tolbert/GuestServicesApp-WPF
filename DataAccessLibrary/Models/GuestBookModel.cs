using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestServicesLibrary.Models
{
    internal class GuestBookModel
    {
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public int GroupSize { get; set; }

        public string? Comment { get; set; }
       
        //TODO: create properties to store date and time of visit
        //private string _date { get; set;}
        //private string _time { get; set; }

    }
}
