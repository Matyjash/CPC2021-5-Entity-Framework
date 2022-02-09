using MaciejLendzionLab5ZadDom.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejLendzionLab5ZadDom.Controllers
{
    /// <summary>
    /// Kontroler dla kart graficznych
    /// </summary>
    public class GraphicCardsController : Controller
    {
        // kontekst bazy danych
        private readonly DataBaseContext _context;

        /// <summary>
        /// Konstruktor kontrolera dla kart garficznych
        /// </summary>
        /// <param name="context"></param>
        public GraphicCardsController(DataBaseContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Widok dla Indexu dla działu GraphicCards
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            //zwracamy widok przekazdując mu liste kart graficznych
            return View(_context.GraphicCards.ToList());
        }

        /// <summary>
        /// Widok dla potwierdzenia usunięcia (kupna) kraty
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Delete(int id)
        {
            //znajdujemy obiekt
            var graphicCard = _context.GraphicCards.FirstOrDefault(d => d.GcId.Equals(id));

            //jeżeli go nie ma wyświetlamy komunikat
            if(graphicCard == null)
            {
                return NotFound();
            }

            //zwracamy widok przekazując mu odnaleziony model karty
            return View(graphicCard);
        }

        /// <summary>
        /// Widok dla usunięcia karty graficznej
        /// </summary>
        /// <param name="graphicCard"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Delete(GraphicCard graphicCard)
        {
            //usuawamy karte z bazy danych i zapisuejmy zmiany
            _context.GraphicCards.Remove(graphicCard);
            _context.SaveChanges();

            //wracamy do Indexu
            return RedirectToAction(nameof(Index));
        }
    }
}
