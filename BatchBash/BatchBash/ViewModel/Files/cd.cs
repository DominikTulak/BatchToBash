using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BatchBash.ViewModel.Files
{
    class cd : INotifyPropertyChanged
    {
        private string _output { get; set; }
        private string _inputText { get; set; }
        public BatchBash.MainPage sender;
        public string output { get { return _output; } set {
                if(_output != value)
                {
                    _output = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("output"));
                }
                
            }
        }
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
                if(_inputText != value)
                {
                    _inputText = value;
                    output = Model.Files.cd(_inputText);
                    PropertyChanged(this, new PropertyChangedEventArgs("inputText"));
                }
                
            }
        }
        public cd(BatchBash.MainPage sender)
        {
            this.sender = sender;
        }
    }
}
