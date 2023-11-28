using SignalRFastFood.Entities.Models;
using SignalRFastFood.Entities.Repositories.Abstracts;
using SignalRFastFood.Entities.Services.Abstracts;
using SignalRFastFood.Entities.UnitOfWorks;

namespace SignalRFastFood.Business.Services.Concretes;

public class ContactService : Service<Contact>, IContactService
{
    public ContactService(IRepository<Contact> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}