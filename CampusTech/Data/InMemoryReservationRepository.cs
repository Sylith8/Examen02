
using System.Collections.Generic;
using System.Linq;
using CampusTech.Models;

public class InMemoryReservationRepository : IReservationRepository
{
    private static List<Reservations> _data = new List<Reservations>();

    public void Add(Reservations r) => _data.Add(r);

    public IEnumerable<Reservations> GetAll() => _data;

    public bool ExistsCodigo(string codigo) => _data.Any(x => x.CodigoReserva == codigo);
}
saddasdasd