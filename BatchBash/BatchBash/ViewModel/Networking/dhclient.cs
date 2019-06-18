using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BatchBash.ViewModel.Networking
{
    class dhclient : INotifyPropertyChanged
    {
        private string _output { get; set; }
        private string _inputText { get; set; }
        public BatchBash.MainPage sender;
        public string output
        {
            get { return _output; }
            set
            {
                if (_output != value)
                {
                    _output = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("output"));
                }

            }
        }
        private bool _sudo { get; set; }
        public bool sudo { get { return _sudo; } set { if (_sudo != value) { _sudo = value; PropertyChanged(this, new PropertyChangedEventArgs("sudo")); output = Model.Networking.dhclient(release,sudo,inputText); } } }
        private bool _release { get; set; }
        public bool release { get { return _release; } set { if (_release != value) { _release = value; PropertyChanged(this, new PropertyChangedEventArgs("release")); output = Model.Networking.dhclient(release, sudo, inputText); } } }

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        public string inputText
        {
            get
            {
                return _inputText;
            }
            set
            {
                if (_inputText != value)
                {
                    _inputText = value;
                    output = Model.Networking.dhclient(release, sudo, inputText);
                    PropertyChanged(this, new PropertyChangedEventArgs("inputText"));
                }

            }
        }
        public dhclient(BatchBash.MainPage sender)
        {
            this.sender = sender;
        }
    }
}

