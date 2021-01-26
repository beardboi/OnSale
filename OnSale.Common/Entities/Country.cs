using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnSale.Common.Entities
{
    public class Country
    {
        /*
         * The id of the country.
         * Unique
         */ 
        [Key]
        public int Id { get; set; }

        /*
         * The name of the country.
         * Required, MaxLength = 50
         */
        [MaxLength(50, ErrorMessage = "The field {0} must contain less than {1} characters.")]
        [Required]
        public string Name { get; set; }

        /*
         * The list of departments.
         */
        public ICollection<Department> Departments { get; set; }

        /*
         * The number of deparments.
         */
        public int DepartmentsNumber => Departments == null ? 0 : Departments.Count;
    }
}
