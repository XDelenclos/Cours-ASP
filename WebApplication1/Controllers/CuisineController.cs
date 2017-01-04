using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CuisineController : Controller
    {
        // GET: /Cuisine/
        //[HttpGet]   -> attribut d'action

        [Authorize] // -> possibilité de l'utiliser sans parametre, l'utilisateur doit etre connecter pour utiliser la fonction de recherche.
        //ex  [Authorize(Roles="Admin")] -> l'utilisateur doit etre identifié et faire partie du rôle administrateur.
        
        public ActionResult Search(string name = "french")
        {
            var message = Server.HtmlEncode(name);
            //return RedirectToRoute("Index", "Home");

            //return RedirectToRoute("Default" , new { controller = "Home", action = "About" });

            //return File(Server.MapPath("~/Content/site.css"), "text/css"); // retourne le fichier CSS se situant dans le dossier Content, nommé site.css,
            //on précise ensuite  sous forme de string  son format.


            // return Json(new { Message = message, Name = "Scott" }, JsonRequestBehavior.AllowGet);
            //retourne du Json affichant :
            //{"Message":"french","Name":"Scott"}   ----> ici le message par défaut est "french"

            return Content(message);
        }

        
        
    }
}