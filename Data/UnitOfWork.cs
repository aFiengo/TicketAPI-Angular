using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Data.Exceptions;
using Truextend.TicketDispenser.Data.Repository;
using Truextend.TicketDispenser.Data.Repository.Interfaces;

namespace Truextend.TicketDispenser.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        //TODO complete the interfaces
        private readonly TicketDbContext _ticketDBContext;
        private readonly ICategoryRepository _category;
        private readonly IEventRepository _event;
        private readonly IEventZoneRepository _eventZone;
        private readonly ITicketRepository _ticket;
        private readonly IUserRepository _user;
        private readonly IVenueRepository _venue;
        private readonly IZoneRepository _zone;
        private readonly IZoneVenueRepository _zoneVenue;

        public UnitOfWork(TicketDbContext dbContext)
        {
            _ticketDBContext = dbContext;
            _user = new UserRepository(_ticketDBContext);
            _venue = new VenueRepository(_ticketDBContext);
            _category = new CategoryRepository(_ticketDBContext);
            _event = new EventRepository(_ticketDBContext);
        }
        public void BeginTransaction()
        {
            _ticketDBContext.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _ticketDBContext.Database.CommitTransaction();
        }

        public void RollBackTransaction()
        {
            _ticketDBContext.Database.RollbackTransaction();
        }

        public void Save()
        {
            try
            {
                BeginTransaction();
                _ticketDBContext.SaveChanges();
                CommitTransaction();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                RollBackTransaction();
                string message = $"Error to save changes on Database -> Save() {Environment.NewLine}Message: {ex.Message}{Environment.NewLine}";
                throw new DatabaseException("Can not save changes, error in Database", ex.InnerException);
            }
            catch (DbUpdateException ex)
            {
                RollBackTransaction();
                string message = $"Error to save changes on Database -> Save() {Environment.NewLine}Message: {ex.Message}{Environment.NewLine}";
                throw new DatabaseException("Can not save changes, error in Database", ex.InnerException);
            }
            catch (Exception ex)
            {
                string message = $"Error to save changes on Database -> Save() {Environment.NewLine}Message: {ex.Message}{Environment.NewLine}";
                throw new DatabaseException("Can not save changes, error in Database", ex.InnerException);
            }
        }
        public ICategoryRepository CategoryRepository
        {
            get { return _category; }
        }
        public IEventRepository EventRepository
        { 
            get { return _event; }
        }
        public IEventZoneRepository EventZoneRepository 
        {
            get { return _eventZone; }
        }
        public ITicketRepository TicketRepository 
        { 
            get { return _ticket; }
        }
        public IUserRepository UserRepository
        {
            get { return _user; }
        }
        public IVenueRepository VenueRepository 
        {
            get { return _venue; }
        }
        public IZoneRepository ZoneRepository 
        {
            get { return _zone; }
        }
        public IZoneVenueRepository ZoneVenueRepository 
        {
            get { return _zoneVenue; }
        }
    }
}
