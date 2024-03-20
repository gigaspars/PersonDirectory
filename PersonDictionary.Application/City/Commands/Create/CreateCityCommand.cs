using MediatR;
using PersonDirectory.Common.Application.Interfaces;

namespace PersonDirectory.Application.City.Commands.Create
{
    public class CreateCityCommand : IRequest<int>, ITransactionalRequest
    {
        public string Name { get; set; }
    }
}
