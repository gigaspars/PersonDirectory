using MediatR;
using PersonDirectory.Common.Application.Interfaces;

namespace PersonDirectory.Application.Person.Commands.Delete
{
    public class DeletePersonCommand : IRequest<Unit>, ITransactionalRequest
    {
        public int Id { get; set; }
    }
}
