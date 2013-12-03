using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls.Expressions;

namespace WebServices.Models
{
    public interface IReservationRepository
    {
        IEnumerable<Reservation> GetAll();
        Reservation Get(int id);
        Reservation Add(Reservation item);
        void Remove(int id);
        bool Update(Reservation item);
    }

    public class ReservationRepository : IReservationRepository
    {
        private List<Reservation> data = new List<Reservation>
        {
            new Reservation{ReservationId = 1, ClientName = "Adam", Location = "London"},
            new Reservation{ReservationId = 2, ClientName = "Steve", Location = "New York"},
            new Reservation{ReservationId = 3, ClientName = "Jacqui", Location = "Paris"},
        };


        private static readonly ReservationRepository repo = new ReservationRepository();

        public static IReservationRepository GetRepository()
        {
            return repo;
        }

        public IEnumerable<Reservation> GetAll()
        {
            return data;
        }

        public Reservation Get(int id)
        {
            return data.FirstOrDefault(r => r.ReservationId == id);
        }

        public Reservation Add(Reservation item)
        {
            item.ReservationId = data.Count + 1;
            data.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            var item = Get(id);
            if (item != null)
                data.Remove(item);
        }

        public bool Update(Reservation item)
        {
            var stored = Get(item.ReservationId);
            if (stored == null)
                return false;

            stored.Location = item.Location;
            stored.ClientName = item.ClientName;
            return true;
        }
    }
}