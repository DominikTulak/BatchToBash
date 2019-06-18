using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BatchBash.ViewModel.Networking
{
    class rfkill : INotifyPropertyChanged
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
        public bool sudo { get { return _sudo; } set { if (_sudo != value) { _sudo = value; PropertyChanged(this, new PropertyChangedEventArgs("sudo")); output = Model.Networking.rfkill(state, sudo, inputText); } } }
        private bool _state { get; set; }
        public bool state { get { return _state; } set { if (_state != value) { _state = value; PropertyChanged(this, new PropertyChangedEventArgs("state")); output = Model.Networking.rfkill(state, sudo, inputText); } } }

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
                    output = Model.Networking.rfkill(state, sudo, inputText);
                    PropertyChanged(this, new PropertyChangedEventArgs("inputText"));
                }

            }
        }
        public rfkill(BatchBash.MainPage sender)
        {
            this.sender = sender;
        }
    }
}
