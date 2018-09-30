using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_codefFirst.Models
{
    [Table(name:"Credits",Schema ="bankApp")]
    public class Credit
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public Person Person { get; set; }

        [Required]
        [Column(TypeName ="smalldatetime")]
        public DateTime Disburs { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }
}
