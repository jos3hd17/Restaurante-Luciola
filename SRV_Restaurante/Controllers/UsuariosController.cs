using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SRV_Restaurante.Models;
using System.Web.Http;

namespace SRV_Restaurante.Controllers
{
    public class UsuariosController : Controller
    {
        private RestauranteEntities db = new RestauranteEntities();
        private ProceduresEntities sp = new ProceduresEntities();   

       // Http Get validates user information, and return it into a json 
        [System.Web.Http.Route("Login"), System.Web.Http.HttpGet]
        public JsonResult Login(string nombre, string pass)
        {
           var login = sp.Valida_ingreso(nombre, pass).ToList();
           return Json(login, JsonRequestBehavior.AllowGet);
        }


      
        // GET: Usuarios/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

       
        // GET: Usuarios/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }
        

        // GET: Usuarios/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

       
    }
}
