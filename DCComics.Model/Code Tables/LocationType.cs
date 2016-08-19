using DCComics.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCComics.Model.Code_Tables
{
    [Table("Location_Type")]
    public class LocationType : AuditableEntity<long>
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("LOCATION_TYPE_SEQ")]
        public byte LocationTypeId { get; set; }

        [MaxLength(20)]
        [Column("LOCATION_TYPE_CODE")]
        [Display(Name = "Location Type Code")]
        public string LocationTypeCode { get; set; }

        [MaxLength(100)]
        [Column("LOCATION_TYPE_DESC")]
        [Display(Name = "Location Type Description")]
        public string LocationTypeDesc { get; set; }

        [Column("START_DATE")]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }

        [Column("END_DATE")]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
    }
}
