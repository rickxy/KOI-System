using KOI_System.Context;
using KOI_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace KOI_System.Controllers
{
    public class SeminarController : Controller
    {
        MVCContext db;
        public SeminarController(MVCContext _db)
        {
            db = _db;
        }
        public IActionResult Record()
        {
            IEnumerable<seminars> Seminars = db.Seminars.Select(s => s).ToList();

            return View(Seminars);
        }

        public IActionResult Delete(int id)
        {
            seminars Seminar = db.Seminars.FirstOrDefault(s => s.Id == id);
            if(Seminar != null)
            {
                db.Remove(Seminar);
                db.SaveChanges();
                return RedirectToAction("Record");
            }

            return View();
        }
    }
}
