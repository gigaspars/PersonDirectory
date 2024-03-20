using MediatR;
using PersonDirectory.Common.Application.Interfaces;

namespace PersonDirectory.Application.PersonPhoneNumber.Command.Update
{
    public class UpdatePersonPhoneNumberCommand : IRequest<Unit>, ITransactionalRequest
    {
        public int PersonId { get; set; }
        public int PersonPhoneNumberId { get; set; }
        public int PhoneNumberTypeId { get; set; }
        public string Number { get; set; }
    }
}
