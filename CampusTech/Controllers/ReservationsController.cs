
using Microsoft.AspNetCore.Mvc;
using CampusTech.Models;

public class ReservationsController : Controller
{
    private readonly IReservationRepository _repo;

    public ReservationsController(IReservationRepository repo)
    {
        _repo = repo;
    }

    public IActionResult Index()
    {
        var reservas = _repo.GetAll();
        return View(reservas);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Reservations model)
    {
        if (model.FechaReserva < DateTime.Today)
            ModelState.AddModelError("FechaReserva", "La fecha no puede ser en el pasado.");

        if (TimeSpan.Parse(model.HoraFin) <= TimeSpan.Parse(model.HoraInicio))
            ModelState.AddModelError("HoraFin", "La hora fin debe ser mayor que la hora inicio.");

        if (_repo.ExistsCodigo(model.CodigoReserva))
            ModelState.AddModelError("CodigoReserva", "Este código ya existe.");

        if (!ModelState.IsValid)
            return View(model);

        _repo.Add(model);
        return RedirectToAction("Index");
    }
}
