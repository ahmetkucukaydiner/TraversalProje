﻿using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entities.Concrete;

namespace Traversal.Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        private IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void TAdd(Reservation entity)
        {
            _reservationDal.Add(entity);
        }

        public void TDelete(Reservation entity)
        {
            _reservationDal.Delete(entity);
        }

        public void TUpdate(Reservation entity)
        {
            _reservationDal.Update(entity);
        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetList();
        }

        public Reservation TGetByID(int id)
        {
            return _reservationDal.Get(x => x.Id == id);
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            return _reservationDal.GetListWithReservationByWaitApproval(id);
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            return _reservationDal.GetListWithReservationByPrevious(id);
        }

        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            return _reservationDal.GetListWithReservationByAccepted(id);
        }
    }
}
