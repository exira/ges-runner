using System.Collections.Generic;
using System.Diagnostics;

namespace GesRunner
{
    public class ServiceWrapper
    {
        private readonly EventStoreServiceConfiguration _configuration;
        private Process _process;

        public ServiceWrapper(EventStoreServiceConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Start()
        {
            var processMapper = new ProcessMapper();
            var info = processMapper.GetProcessStartInfo(_configuration);

            var process = Process.Start(info);
            process.Exited += (sender, args) => Stop();

            _process = process;
        }

        public void Stop()
        {
            _process.Refresh();

            if (_process.HasExited)
                return;

            _process.Kill();
            _process.WaitForExit();
            _process.Dispose();
            _process = null;
        }
    }
}
