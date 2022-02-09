using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejLendzionLab5ZadDom.Models
{
    /// <summary>
    /// Kontekst bazy danych
    /// </summary>
    public class DataBaseContext: DbContext
    {

        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {

        }

        //karty graficzne
        public DbSet<GraphicCard> GraphicCards { get; set; }

        //producenci   
        public DbSet<Producer> Producers { get; set; }

        //dilerzy
        public DbSet<Dealer> Dealers { get; set; }

        //oceny
        public DbSet<Rate> Rates { get; set; }
    }
}
