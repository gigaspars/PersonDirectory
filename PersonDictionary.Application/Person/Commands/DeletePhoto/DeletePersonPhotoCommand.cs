using MediatR;
using PersonDirectory.Common.Application.Interfaces;

namespace PersonDirectory.Application.Person.Commands.DeletePhoto
{
    public class DeletePersonPhotoCommand : IRequest<Unit>, ITransactionalRequest
    {
        public int PersonId { get; set; }
    }
}
