using DCComics.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCComics.Model
{
    [Table("Person")]
    public class Person: AuditableEntity<long>
    {
        [Required]
        [MaxLength(50)]
        [Display (Name= "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
    }
}
