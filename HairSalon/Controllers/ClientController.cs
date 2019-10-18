using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
    public class ClientController:Controller
    {
        private readonly HairSalonContext _db;
        public ClientController(HairSalonContext db)
        {
            _db = db;
        }

        public ActionResult Create(int id)
        {
            ViewBag.StylistId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Client clients)
        {
            _db.Clients.Add(clients);
            _db.SaveChanges();
            return RedirectToAction("Details", "Stylist", new { id = clients.StylistId });
        }
    }
}