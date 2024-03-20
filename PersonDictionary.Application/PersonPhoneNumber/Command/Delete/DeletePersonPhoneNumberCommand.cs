using MediatR;
using PersonDirectory.Common.Application.Interfaces;

namespace PersonDirectory.Application.PersonPhoneNumber.Command.Delete
{
    public class DeletePersonPhoneNumberCommand : IRequest<Unit>, ITransactionalRequest
    {
        public int PersonId { get; set; }
        public int PersonPhoneNumberId { get; set; }
    }
}
