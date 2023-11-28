namespace SignalRFastFood.Entities.UnitOfWorks;

public interface IUnitOfWork
{
    Task CommitAsync();
    void Commit();
}