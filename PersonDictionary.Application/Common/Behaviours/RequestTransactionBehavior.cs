
using MediatR;
using Microsoft.Extensions.Logging;
using PersonDirectory.Common.Application.Interfaces;
using PersonDirectory.Domain.Interfaces;

namespace PersonDirectory.Application.Common.Behaviours
{
    public class RequestTransactionBehavior<TRequest, TResponse>(ILogger<RequestTransactionBehavior<TRequest, TResponse>> _logger, IUnitOfWork _uof)
        : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var response = default(TResponse);
            if (request is ITransactionalRequest)
            {
                try
                {
                    await _uof.BeginTransactionAsync();

                    var result = await next();

                    await _uof.CommitTransactionAsync();

                    return result;
                }
                catch (Exception ex)
                {
                    _logger.LogInformation($"Rollback Db Transaction for {typeof(TRequest).Name}!" +
                        $"{ex.Message}");

                    await _uof.RollbackTransactionAsync();
                    throw;
                }
            }
            else
                response = await next();

            return response;
        }
    }
}
