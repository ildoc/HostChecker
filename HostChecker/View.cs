using HostChecker.Class;
using System.ComponentModel;

namespace HostChecker
{
    public class View : INotifyPropertyChanged
    {
        private Model _model;

        public View(Model model)
        {
            _model = model;
        }

        public void UpdateData()
        {
            OnPropertyChanged("hostList");
        }

        public Host Check(string host)
        {
            return _model.Check(host);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
