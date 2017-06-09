using Microsoft.Extensions.Logging;

namespace TestFunctions
{
    public class Logger
    {
        private Microsoft.Extensions.Logging.ILogger _logger;

        public Logger(Microsoft.Extensions.Logging.ILogger logger)
        {
            _logger = logger;
        }


        public void Log(string message)
        {
            _logger.LogTrace(message);
        }
    }
}
