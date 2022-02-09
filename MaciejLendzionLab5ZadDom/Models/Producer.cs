using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaciejLendzionLab5ZadDom.Models
{
    /// <summary>
    /// Model producenta
    /// </summary>
    public class Producer
    {
        //id producenta
        [Key]
        public int ProducerId { get; set; }

        //nazwa producenta
        [Required]
        [MaxLength(50)]
        public string ProducerName { get; set; }

        //lista kart graficznych
        public ICollection<GraphicCard> GraphicCards { get; set; }

    }
}