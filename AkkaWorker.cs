namespace TradePlacementWorker
{
    public class AkkaWorker : BackgroundService
    {
        private readonly ILogger<AkkaWorker> _logger;

        public AkkaWorker(ILogger<AkkaWorker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}