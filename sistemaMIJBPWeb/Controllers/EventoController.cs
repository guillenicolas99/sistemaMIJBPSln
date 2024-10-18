using CapaDominio.Entities;
using CapaInfraestructura.Context;
using Microsoft.AspNetCore.Mvc;

namespace sistemaMIJBPWeb.Controllers
{
    public class EventoController : Controller
    {
        private readonly AppDbContext _context;

        public EventoController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var listaEventos = _context.Eventos.ToList();
            return View(listaEventos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Evento evento)
        {
            if (ModelState.IsValid)
            {
                _context.Eventos.Add(evento);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(evento);
        }
    }
}
