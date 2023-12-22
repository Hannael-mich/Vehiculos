using BusinessVehiculos;
using DataVehiculos.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebVehiculos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        BusVehiculos bus = new BusVehiculos();
        BusGrupo busG = new BusGrupo(); 

        public ActionResult Index()
        {
            try
            {
                List<Productos1> ls = bus.Obtener();
                return View("Index",ls);
                
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
            }
            return View("Index");
        }

        // GET: Home/Details/5

        public ActionResult Buscar(string valor)
        {
            try
            {
                List<Productos1> ls = bus.Buscar(valor);
                TempData["msj"] = $"La busqueda fue exitosa con {valor}";
                return View("Index", ls);
            }
            catch (Exception ex)
            {
                TempData["error"]=ex.Message; 
            }
            return View("Index");
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            List<Grupo> lsG = busG.Obtener();
            try
            {
                ViewBag.CveGpo = new SelectList(lsG, "CveGpo", "Descripcion");
                TempData["mjs"] = $"Se Obtuvo correctamente el vehiculo";
                return View("");
            }
            catch (Exception ex)
            {
                TempData["error"]=ex.Message;
            }
            return View("");
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult CreateBD(Productos1 p)
        {
            try
            {
                bus.Agregar(p);
                TempData["mjs"] = $"Se creo correctamente el productos {p.Productos}";
                return RedirectToAction("Index");
                
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                List<Grupo> lsG = busG.Obtener();
                

                ViewBag.Marcaid = new SelectList(lsG, "idM", "NombreM");
                return View("Create");
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(string id)
        {
            try
            {
                Productos1 p = bus.Obtener(id);
                List<Grupo> lsG = busG.Obtener();

                ViewBag.CveGpo = new SelectList(lsG, "CveGpo", "Descripcion");
                TempData["mjs"] = "Se edito";
                return View(p);
            }
            catch (Exception ex)
            {
                TempData["error"] =ex.Message;
            }
            return View("Index");
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult EditBD(Productos1 p)
        {
            try
            {
                bus.Editar(p);
                TempData["mjs"] = $"Se edito correctamente el producto {p.Productos}";
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                TempData["error"] = ex.Message;
            }
            return RedirectToAction("Index");
        }

        // GET: Home/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: Home/Delete/5
        //[HttpPost]
        public ActionResult Delete(Productos1 p)
        {
            try
            {
                // TODO: Add delete logic here
                bus.Borrar(p);
                TempData["mjs"] = $"Se Dio de baja correctamente el producto {p.Productos}";
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                TempData["error"] = ex.Message;
            }
            return RedirectToAction("Index");
        }
    }
}
