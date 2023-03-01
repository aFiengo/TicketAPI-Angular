using Microsoft.EntityFrameworkCore;

using Truextend.Rewards.Data;
using Truextend.TicketDispenser.Data.Exceptions;
using Truextend.TicketDispenser.Data.Repository;
using Truextend.TicketDispenser.Data.Repository.Interfaces;
using Truextend.TicketDispenserAPI.Data;

namespace Truextend.TicketDispenser.Data;
public class UnitOfWork : IUnitOfWork
{
    private readonly IZoneRepository _zone;
    private readonly TicketDispenserDBContext _ticketDispenserDBContext;

    public UnitOfWork(TicketDispenserDBContext dbContext)
    {
        _ticketDispenserDBContext = dbContext;
        _zone = new ZoneRepository(_ticketDispenserDBContext);
    }

    public void BeginTransaction()
    {
        _ticketDispenserDBContext.Database.BeginTransaction();
    }

    public void CommitTransaction()
    {
        _ticketDispenserDBContext.Database.CommitTransaction();
    }

    public void RollBackTransaction()
    {
        _ticketDispenserDBContext.Database.RollbackTransaction();
    }

    public void Save()
    {
        try
        {
            BeginTransaction();
            _ticketDispenserDBContext.SaveChanges();
            CommitTransaction();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            RollBackTransaction();
            throw new DatabaseException("Can not save changes, error in Database", ex.InnerException);
        }
        catch (DbUpdateException ex)
        {
            RollBackTransaction();
            throw new DatabaseException("Can not save changes, error in Database", ex.InnerException);
        }
        catch (Exception ex)
        {
            throw new DatabaseException("Can not save changes, error in Database", ex.InnerException);
        }
    }

    public IZoneRepository ZoneRepository
    {
        get { return _zone; }
    }
}
