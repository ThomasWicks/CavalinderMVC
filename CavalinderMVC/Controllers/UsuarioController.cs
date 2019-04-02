using CavalinderMVC.AppService;
using CavalinderMVC.Models;
using CavalinderMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CavalinderMVC.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioAppService _usuarioAppService;
        List<string> errors = new List<string>();

        public UsuarioController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }
        // GET: Usuario
        public ActionResult Index()
        {
            return View(_usuarioAppService.GetAll());
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuario/Login
        public ActionResult Login()
        {
            return View(new UsuarioViewModelLogin());
        }

        // POST: Usuario/Login
        [HttpPost]
        public ActionResult Login(UsuarioViewModelLogin usuarioLogin)
        {
            try
          {
                errors = _usuarioAppService.Logar(usuarioLogin);
                if(errors.Count <= 0)
                {
                return RedirectToAction("Index");
                }
                else
                {
                    return View(usuarioLogin);
                }
            }
            catch (Exception e)
            {
                return View(usuarioLogin);
            }
        }
        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View(new UsuarioViewModel());
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(UsuarioViewModel usuario)
        {
            try
            {
                errors = _usuarioAppService.Insert(usuario);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View(usuario);
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel = _usuarioAppService.GetById(id);
            return View(usuarioViewModel);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(UsuarioViewModel usuarioViewModel)
        {
            try
            {
                errors = _usuarioAppService.Update(usuarioViewModel);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View(usuarioViewModel);
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel = _usuarioAppService.GetById(id);
            return View(usuarioViewModel);
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, UsuarioViewModel usuarioViewModel)
        {
            try
            {
                errors = _usuarioAppService.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(usuarioViewModel);
            }
        }
    }
}
