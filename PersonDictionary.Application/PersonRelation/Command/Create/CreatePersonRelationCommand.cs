using MediatR;
using PersonDirectory.Common.Application.Interfaces;

namespace PersonDirectory.Application.PersonRelation.Command.Create
{
    public class CreatePersonRelationCommand : IRequest<int>, ITransactionalRequest
    {
        public int PersonId { get; set; }
        public int RelatedPersonId { get; set; }
        public int PersonRelationTypeId { get; set; }
    }
}
