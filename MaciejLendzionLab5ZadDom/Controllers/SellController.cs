using MaciejLendzionLab5ZadDom.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejLendzionLab5ZadDom.Controllers
{
    /// <summary>
    /// KOntroler sprzedaży
    /// </summary>
    public class SellController : Controller
    {
        //kontekst bazy danych
        private readonly DataBaseContext _context;
        /// <summary>
        /// Konstruktor kontrolera dla sprzedaży
        /// </summary>
        /// <param name="context"></param>
        public SellController(DataBaseContext context)
        {
            //zapisujemy kontekst
            _context = context;
        }

        /// <summary>
        /// Widok strony głównej dla sprzedazy
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            //zwracamy widok
            return View();
        }

        /// <summary>
        /// Widok stworzenia nowego obiektu do sprzedania 
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            //zwrafcamy widok
            return View();
        }

        /// <summary>
        /// Swtoerzenie nowego obiektu i wyświetlnie go
        /// </summary>
        /// <param name="graphicCard"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(GraphicCard graphicCard)
        {
            //zapisujemy nowy przedmiot w bazie
            _context.GraphicCards.Add(graphicCard);
            _context.SaveChanges();

            //wracamy do strony głownej
            return RedirectToAction(nameof(Index));

        }
    }
}
