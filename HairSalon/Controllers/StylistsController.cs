using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    [HttpGet("/stylists")]
    public ActionResult Index()
    {
    }

    [HttpPost("/stylists")]
    public ActionResult Create(string stylistName, string stylistDescription)
    {
    }

    [HttpGet("/stylists/new")]
    public ActionResult New()
    {
    }

    [HttpGet("/stylists/{id}")]
    public ActionResult Show(int id)
    {
    }

    [HttpPost("/stylists/{stylistId}/clients")]
    public ActionResult Create(int stylistId, string clientTitle, string clientDescription, string clientPrice, string clientDate)
    {
    }
  }
}