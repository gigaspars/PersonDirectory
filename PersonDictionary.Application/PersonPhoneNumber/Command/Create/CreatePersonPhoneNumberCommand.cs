using MediatR;
using PersonDirectory.Common.Application.Interfaces;

namespace PersonDirectory.Application.PersonPhoneNumber.Command.Create
{
    public class CreatePersonPhoneNumberCommand : IRequest<Unit>, ITransactionalRequest
    {
        public int PersonId { get; set; }
        public int PhoneNumberTypeId { get; set; }
        public string PhoneNumber { get; set; }
    }
}
