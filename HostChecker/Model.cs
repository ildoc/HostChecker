using HostChecker.Class;
using System.Net.NetworkInformation;

namespace HostChecker
{
    public class Model
    {
        public Host Check(string host)
        {
            bool status = false;
            PingReply pingReply;
            using (var ping = new Ping())
                pingReply = ping.Send(host);
            if (pingReply.Status == IPStatus.Success)
                status = true;
            return new Host(host, status);
        }
    }
}
