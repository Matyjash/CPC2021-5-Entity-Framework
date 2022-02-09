using MaciejLendzionLab5ZadDom.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejLendzionLab5ZadDom.Controllers
{
    /// <summary>
    /// Kontroler dla producentów
    /// </summary>
    public class ProducersController : Controller
    {
        // kontekst bazy danych
        private readonly DataBaseContext _context;

        /// <summary>
        /// Konstruktor kontrolera dla producentów
        /// </summary>
        /// <param name="context"></param>
        public ProducersController(DataBaseContext context)
        {
            //zapisujemy kontekst
            _context = context;
        }

        /// <summary>
        /// Widok strony głównej Producentów
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            //zwradamy widok przekazując mu listę producentów
            return View(_context.Producers.ToList());
        }
    }
}
