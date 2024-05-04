using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models{
    public class Employee{
        [Key]
        public int ID { get; set; }
        [Column("empname")]
        public string? EName { get; set; }
        public int? Salary { get; set; }
        [Column("empDesignation")]
        public string? Designation { get; set; }
    }
}