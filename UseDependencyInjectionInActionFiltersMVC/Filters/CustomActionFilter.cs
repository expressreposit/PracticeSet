using Microsoft.AspNetCore.Mvc.Filters;

namespace UseDependencyInjectionInActionFiltersMVC.Filters
{
    //1. Create a custom ActionFilterAttribute class in
    public class CustomActionFilter: ActionFilterAttribute
    {
        private readonly ILogger _logger;
        public CustomActionFilter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger("CustomActionFilter");
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogWarning("Inside OnActionExecuting method...");
            base.OnActionExecuting(context);
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogWarning("Inside OnActionExecuted method...");
            base.OnActionExecuted(context);
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            _logger.LogWarning("Inside OnResultExecuting method...");
            base.OnResultExecuting(context);
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            _logger.LogWarning("Inside OnResultExecuted method...");
            base.OnResultExecuted(context);
        }
    }
}
