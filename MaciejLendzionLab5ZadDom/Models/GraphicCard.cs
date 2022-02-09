using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejLendzionLab5ZadDom.Models
{
    /// <summary>
    /// Model karty graficznej
    /// </summary>
    public class GraphicCard
    {
        //id karty
        [Key]
        public int GcId { get; set; }
        //id producenta
        [Required]
        public int ProducerId { get; set; }
        //producent
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
        
        //nazwa karty

        [MaxLength(50)]
        public string Name { get; set; }
        //cena
        [Required]
        public int Price { get; set; }

       
    }
}
