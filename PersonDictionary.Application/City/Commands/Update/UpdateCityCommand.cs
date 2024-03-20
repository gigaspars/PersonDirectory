using MediatR;
using PersonDirectory.Common.Application.Interfaces;

namespace PersonDirectory.Application.City.Commands.Update
{
    public class UpdateCityCommand : IRequest<Unit>, ITransactionalRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
