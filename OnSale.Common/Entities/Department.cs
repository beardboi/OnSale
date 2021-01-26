using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnSale.Common.Entities
{
    public class Department
    {
        /*
         * The id of the Department.
         */
        [Key]
        public int Id { get; set; }

        /*
         * The name of the Department.
         */
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        /*
         * The list of cities.
         */ 
        public ICollection<City> Cities { get; set; }

        /*
         * To diplay the number of departments.
         */
        [DisplayName("Department number")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;

        [NotMapped]
        [JsonIgnore]
        public int IdCountry { get; set; }

    }
}
