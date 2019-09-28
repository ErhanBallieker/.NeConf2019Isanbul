using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetCore.WorkerService
{
    public class TimedWorker : IHostedService, IDisposable
    {
        private int executionCount = 0;
        private readonly ILogger<TimedWorker> _logger;
        private Timer _timer;

        public TimedWorker(ILogger<TimedWorker> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service running.");
            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(3));
            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            executionCount++;
            _logger.LogInformation("Timed Hosted Service is working. Count: {Count}", executionCount);
        }

        public Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service is stopping.");
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
