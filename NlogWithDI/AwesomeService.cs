using Microsoft.Extensions.Logging;

namespace NlogWithDI
{
    internal class AwesomeService
    {
        private readonly ILogger<AwesomeService> _logger;

        public AwesomeService(ILogger<AwesomeService> logger)
        {
            _logger = logger;
        }

        public void DoAction(string name)
        {
            _logger.LogDebug(20, "Doing hard work! {Action}", name);
        }
    }
}
