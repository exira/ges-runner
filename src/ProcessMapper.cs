using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace GesRunner
{
    public class ProcessMapper
    {
        public ProcessStartInfo GetProcessStartInfo(EventStoreServiceConfiguration instance)
        {
            var arguments = GetProcessArguments(instance);

            return new ProcessStartInfo(instance.Executable, arguments)
            {
                UseShellExecute = false
            };
        }

        private string GetProcessArguments(EventStoreServiceConfiguration instance)
        {
            return string.Format("--config=\"{0}\"", instance.ConfigPath);
        }
    }
}
