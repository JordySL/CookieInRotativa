using Proyecto.MVC5.Models;
using Rotativa;
using Rotativa.Options;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.MVC5.Controllers
{
    public class UsuariosController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Vistas()
        {
            return View();
        }
        public ActionResult Pdf()
        {
            return new ViewAsPdf("Vistas")
            {
                FileName = "Fee_Challan.pdf",
                PageOrientation = Orientation.Landscape,
                PageSize = Size.A4,
                PageMargins = { Left = 10, Right = 10, Top = 15, Bottom = 22 },
                MinimumFontSize = 7,
                PageHeight = 40
            };
        }
        public string Login(string userName, string passWord)
        {
            Usuarios u = new Usuarios();
            var model = u.ReturnList().Where(x => x.UserName == userName && x.Password == passWord).SingleOrDefault();
            HttpCookie UserCookie = new HttpCookie("Usuarios", model.UserName);
            UserCookie.Expires.AddDays(10);
            HttpContext.Response.SetCookie(UserCookie);
            HttpCookie NewCookie = Request.Cookies["Usuarios"];
            return NewCookie.Value;
        }
        public string Cookie()
        {
            Usuarios u = new Usuarios();
            HttpCookie UserCookie = new HttpCookie("Usuarios", u.UserName);
            UserCookie.Expires.AddDays(10);
            HttpContext.Response.SetCookie(UserCookie);
            HttpCookie NewCookie = Request.Cookies["Usuarios"];
            return NewCookie.Value;
        }
    }
}