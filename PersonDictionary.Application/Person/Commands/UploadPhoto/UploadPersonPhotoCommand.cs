using MediatR;
using Microsoft.AspNetCore.Http;
using PersonDirectory.Common.Application.Interfaces;

namespace PersonDirectory.Application.Person.Commands.UploadPhoto
{
    public class UploadPersonPhotoCommand : IRequest<Unit>, ITransactionalRequest
    {
        public int PersonId { get; set; }
        public IFormFile Photo { get; set; }
    }
}
