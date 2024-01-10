using System.Diagnostics;
using MediatR;
using Microsoft.Extensions.Logging;

namespace TrainTicketManagement.Application.Common.Behaviours;

public class PerformanceBehaviour<TRequest, TResponse>: IPipelineBehavior<TRequest,TResponse>
    where TRequest: notnull, IRequest<TResponse>
{
    private readonly ILogger _logger;
    private readonly Stopwatch _timer;
    
    public PerformanceBehaviour(ILogger<TRequest> logger)
    {
        _timer = new Stopwatch();
        _logger = logger;
    }


    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        _timer.Start();
    
        var response = await next();
        
        _timer.Stop();
    
        var elapsed = _timer.ElapsedMilliseconds;
    
        if (elapsed > 500)
        {
            var requestName = typeof(TRequest).Name;
        
            _logger.LogInformation("TrainTicketManagement Long Running Request: {Name} ({elapsed} miliseconds){@Request}"
                ,requestName,elapsed ,request);
        }
    
        return response;
    
    }

}