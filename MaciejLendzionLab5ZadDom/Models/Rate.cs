using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejLendzionLab5ZadDom.Models
{
    /// <summary>
    /// Model oceny dilera
    /// </summary>
    public class Rate
    {
        //id oceny
        [Key]
        public int RateId { get; set; }

        //opis oceny
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

    }
}
