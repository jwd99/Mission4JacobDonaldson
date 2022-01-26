using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4JacobDonaldson.Models
{
    public class FormResponse
    { //sets each field but the last 3 to requred and the first value is the primary key
        
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        
        [Required]
        public int Year { get; set; }
        [Required]
        public string DirectorFirstName { get; set; }
        [Required]
        public string DirectorLastName { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        //keeps notes field to a limit of 25 characters
        [MaxLength(25)]
        public string Notes { get; set; }

    }
}
