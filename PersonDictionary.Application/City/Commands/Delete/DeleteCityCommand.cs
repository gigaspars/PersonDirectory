using MediatR;
using PersonDirectory.Common.Application.Interfaces;

namespace PersonDirectory.Application.City.Commands.Delete
{
    public class DeleteCityCommand : IRequest<Unit>, ITransactionalRequest
    {
        public int Id { get; set; }
    }
}
