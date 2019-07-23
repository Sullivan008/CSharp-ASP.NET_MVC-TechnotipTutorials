﻿using CascadingDropdownList.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CascadingDropdownList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /// Vizsgálat, hogy volt-e már bejelentkezett felhasználó,
            /// mert akkor a bejelentkeztetett Index-et jelenítjük meg
            /// a User-nak
            if (Session["UserID"] != null)
            {
                return RedirectToAction("../Example/Index");
            }
            else
            {
                EmployeesDBEntities db = new EmployeesDBEntities();

                /// Eltároljuk a szótár elemeket, hogy egy SelectListBox-ot fel tudjunk tölteni
                /// Szintakszis(Átadandó lista, Melyik attribútumot szeretnénk szállítani, melyik attribútumot jelenítsük meg a View-on
                /// {Kulcs érték párok})
                TempData["CountryDicitionaryTableElements"] = new SelectList(GetCountryDictionaryTableElements(db), "CountryID", "CountryName");
                TempData.Keep();

                return View();
            }
        }

        /// <summary>
        ///     Visszaad egy olyan PartialView-ot, amely tartalmaz egy olyan HTML
        ///     kódot, ami inicializál egy DropDownList-et
        /// </summary>
        /// <param name="CountryID">Az ID-nak megfelelő State-ket kérdezzük le a DB-ből</param>
        /// <returns>Olyan PartialView amely inicializál egy </returns>
        public ActionResult GetStates(int CountryID)
        {
            EmployeesDBEntities db = new EmployeesDBEntities();

            /// Eltároljuk a szótár elemeket, hogy egy SelectListBox-ot fel tudjunk tölteni
            /// Szintakszis(Átadandó lista, Melyik attribútumot szeretnénk szállítani, melyik attribútumot jelenítsük meg a View-on
            /// {Kulcs érték párok})
            TempData["StateDicitionaryTableElements"] = new SelectList(GetStateDictionaryTableElements(db, CountryID), "StateID", "StateName");
            TempData.Keep();

            return PartialView("StateOptionPartial");
        }

        /// <summary>
        ///     Visszatéríti a State Szótár Táblából az összes State elemet
        /// </summary>
        /// <param name="db">Adatbáziskapcsolat</param>
        /// <returns>State szótár tábla összes eleme</returns>
        private List<State> GetStateDictionaryTableElements(EmployeesDBEntities db, int CountryID)
        {
            return db.States.Where(x => x.CountryID == CountryID).ToList();
        }

        /// <summary>
        ///     Visszatéríti a Country Szótár Táblából az összes Country elemet
        /// </summary>
        /// <param name="db">Adatbáziskapcsolat</param>
        /// <returns>Country szótár tábla összes eleme</returns>
        private List<Country> GetCountryDictionaryTableElements(EmployeesDBEntities db)
        {
            return db.Countries.ToList();
        }
    }
}