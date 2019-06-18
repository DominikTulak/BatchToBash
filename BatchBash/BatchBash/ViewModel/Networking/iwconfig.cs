﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BatchBash.ViewModel.Networking
{
    class iwconfig : INotifyPropertyChanged
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
        public bool sudo { get { return _sudo; } set { if (_sudo != value) { _sudo = value; PropertyChanged(this, new PropertyChangedEventArgs("sudo")); output = Model.Networking.iwconfig(all,sudo); } } }
        private bool _all { get; set; }
        public bool all { get { return _all; } set { if (_all != value) { _all = value; PropertyChanged(this, new PropertyChangedEventArgs("all")); output = Model.Networking.iwconfig(all, sudo); } } }
        
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
                    output = Model.Networking.iwconfig(all, sudo);
                    PropertyChanged(this, new PropertyChangedEventArgs("inputText"));
                }

            }
        }
        public iwconfig(BatchBash.MainPage sender)
        {
            this.sender = sender;
        }
    }
}
