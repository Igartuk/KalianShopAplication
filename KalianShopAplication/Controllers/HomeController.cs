using System.Data;
using System.Linq;
using Dapper;
using KalianShopApplication.Domain;
using Microsoft.AspNetCore.Mvc;

namespace KalianShopApplication.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IDbConnection _connection;
        private readonly DataManager dataManager;
        //public HomeController(IDbConnection connection)
        //{
        //    _connection = connection;
        //}

        public HomeController(DataManager dataManager) 
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }
        public IActionResult Contacts()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }
    }
}
