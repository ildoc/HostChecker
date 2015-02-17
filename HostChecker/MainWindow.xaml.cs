using HostChecker.Class;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace HostChecker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Model _model;
        private View _view;

        public MainWindow()
        {
            InitializeComponent();

            _model = new Model();
            _view = new View(_model);



            List<Host> items = new List<Host>();

            items.Add(_view.Check("google.com"));
            items.Add(_view.Check("ildoc.it"));
            items.Add(_view.Check("prometeus.net"));
            hostList.ItemsSource = items;

        }
    }
}
