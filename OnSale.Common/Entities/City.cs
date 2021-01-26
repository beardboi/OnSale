using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnSale.Common.Entities
{
    public class City
    {
        /*
         * The Id of the City.
         * Unique
         */ 
        [Key]
        public int Id { get; set; }

        /*
         * The name of the City
         */
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [NotMapped]
        [JsonIgnore]
        public int IdDepartment { get; set; }
    }
}
