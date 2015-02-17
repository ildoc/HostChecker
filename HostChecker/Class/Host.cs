namespace HostChecker.Class
{
    public class Host
    {
        private string _hostname;
        private bool _status;

        public string Hostname
        {
            get { return _hostname; }
            set { _hostname = value; }
        }

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public Host(string Hostname, bool Status)
        {
            _hostname = Hostname;
            _status = Status;
        }
    }
}
