
using System.Collections.Generic;
using CampusTech.Models;

public interface IReservationRepository
{
    void Add(Reservations r);
    IEnumerable<Reservations> GetAll();
    bool ExistsCodigo(string codigo);
}
