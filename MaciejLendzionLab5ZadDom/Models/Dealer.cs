using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejLendzionLab5ZadDom.Models
{
    /// <summary>
    /// Model dealera
    /// </summary>
    public class Dealer
    {
        //id dealera
        [Key]
        public int DealerId { get; set; }

        //jego nazwa
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        //jego mail
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        //id jego oceny
        public int RateId { get; set; }

        //ocena
        public Rate Rate { get; set; }
    }
}
