using MediatR;
using PersonDirectory.Common.Application.Interfaces;

namespace PersonDirectory.Application.PersonRelation.Command.Delete
{
    public class DeletePersonRelationCommand : IRequest<Unit>, ITransactionalRequest
    {
        public int PersonId { get; set; }
        public int RelatedPersonId { get; set; }
        public int PersonRelationTypeId { get; set; }
    }
}
