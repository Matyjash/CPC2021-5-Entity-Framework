using MaciejLendzionLab5ZadDom.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejLendzionLab5ZadDom.Controllers
{
    /// <summary>
    /// Kontroler do dealerów części
    /// </summary>
    public class DealersController : Controller
    {
        //kontekst bazy danych
        private readonly DataBaseContext _context;

        /// <summary>
        /// Konstruktor kontrolera
        /// </summary>
        /// <param name="context"></param>
        public DealersController(DataBaseContext context)
        {
            //przypisanie kontekstu
            _context = context;
        }

        /// <summary>
        /// Widok dla Indexu działu Dealers
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            //zwracamy widok przekazując mu liste dilerów
            return View(_context.Dealers.ToList());
        }

        /// <summary>
        /// Widok dla podstrony Rates dzialu Dealers
        /// </summary>
        /// <returns></returns>
        public IActionResult Rates()
        {
            //zwracamy widok przekazując mu liste ocen
            return View(_context.Rates.ToList());
        }
    }
}
