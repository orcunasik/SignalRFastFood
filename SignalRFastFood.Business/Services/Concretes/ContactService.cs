using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Core.UnitOfWorks;

namespace SignalRFastFood.Business.Services.Concretes;

public class ContactService : Service<Contact>, IContactService
{
    public ContactService(IRepository<Contact> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}