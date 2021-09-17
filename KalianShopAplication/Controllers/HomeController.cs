using System.Data;
using System.Linq;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace KalianShopApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDbConnection _connection;

        public HomeController(IDbConnection connection)
        {
            _connection = connection;
        }

        //public IActionResult Index()
        //{ 
        //    var tt = _connection.Query("SELECT * FROM Customers").ToList();

        //    return View();
        //}
    }
}
