using System.Collections.Generic;
using System.Web.Http;
using WebServices.Models;

namespace WebServices.Controllers
{
    public class ReservationController : ApiController
    {
        readonly IReservationRepository repository = ReservationRepository.GetRepository();

        public IEnumerable<Reservation> GetAllReservations()
        {
            return repository.GetAll();
        }

        public Reservation GetReservation(int id)
        {
            return repository.Get(id);
        }

        public Reservation PostReservation(Reservation item)
        {
            return repository.Add(item);
        }

        [HttpPut]
        public bool UpdateReservation(Reservation item)
        {
            return repository.Update(item);
        }

        public void DeleteReservation(int id)
        {
            repository.Remove(id);
        }
    }
}
