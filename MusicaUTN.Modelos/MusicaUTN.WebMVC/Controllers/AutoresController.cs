using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicaUTN.Modelos;
using MusicaUTN.UAPI;

namespace MusicaUTN.WebMVC.Controllers
{
    public class AutoresController : Controller
    {

        //private string Url = "https://localhost:7249/api/Pistas";
        private string Url;
        private Crud<Autor> Crud { get; set; }

        public AutoresController(IConfiguration conf)
        {
            this.Url = conf.GetValue<String>("ApiUrl") + "Autores";
            Crud = new Crud<Autor>();
        }

        // GET: PistasController
        public ActionResult Index()
        {
            var datos = Crud.Select(Url);
            return View(datos);
        }

        // GET: PistasController/Details/5
        public ActionResult Details(int id)
        {
            var datos = Crud.Select_ById(Url, id.ToString());
            return View(datos);
        }

        // GET: PistasController/Create
        public ActionResult Create()
        {
            // obtenemos la lista de autores para que sea usada en la Vista en un ComboBox
            //var listaAutores = new Crud<Autor>()
            //    .Select(Url.Replace("Pistas", "Autores"))
            //    .Select(p => new SelectListItem     // transformamos del tipo Autores -> SelectListItem
            //    {
            //        Value = p.Id.ToString(),       // codigo de Autores
            //        Text = p.Nombre                // nombre de autores
            //    })
            //    .ToList();
            //Console.WriteLine(Url);
            //ViewBag.ListaAutores = listaAutores;  // pasamos la lista de Autores a la vista

            return View();
        }

        // POST: PistasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Autor datos)
        {
            try
            {
                Crud.Insert(Url, datos);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(datos);
            }
        }

        // GET: PistasController/Edit/5
        public ActionResult Edit(int id)
        {
            var datos = Crud.Select_ById(Url, id.ToString());
            return View(datos);
        }

        // POST: PistasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Modelos.Autor datos)
        {
            try
            {
                Crud.Update(Url, id.ToString(), datos);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(datos);
            }
        }

        // GET: PistasController/Delete/5
        public ActionResult Delete(int id)
        {
            var datos = Crud.Select_ById(Url, id.ToString());
            return View(datos);
        }

        // POST: PistasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Pista datos)
        {
            try
            {
                Crud.Delete(Url, id.ToString());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(datos);
            }
        }
    }
}
