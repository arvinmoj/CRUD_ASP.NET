
using Data;
using System.Linq;
using ViewModels.Error;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace My_Application.Controllers
{
    public class CRUDController : Infrastructure.BaseControllerWithDatabase
    {
        public CRUDController(DatabaseContext databaseContext) : base(databaseContext)
        {

        }

        public IActionResult Index()
        {
            var displaydata = MyDatabaseContext.Users.ToList();
            return View(displaydata);
        }

    }
}