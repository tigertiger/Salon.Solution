using System;
using System.Linq;
using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
  {
    _db = db;
  }

    public ActionResult Index()
    {
      List<Client>model = _db.Clients.ToList();
      return View(model);
    }
  }
}