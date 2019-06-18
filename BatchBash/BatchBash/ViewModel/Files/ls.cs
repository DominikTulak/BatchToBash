using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BatchBash.ViewModel.Files
{
    class ls : INotifyPropertyChanged
    {
        private string _output { get; set; }
        private bool _humanReadable { get; set; }
        private bool _recursive { get; set; }
        private bool _longFormat { get; set; }
        private bool _hiddenFiles { get; set; }
        public BatchBash.MainPage sender;
        public string output { get { return _output; } set { if (_output != value) { _output = value; PropertyChanged(this, new PropertyChangedEventArgs("output")); output = Model.Files.ls(longFormat, hiddenFiles, recursive, humanReadable); } } }
        public bool humanReadable { get { return _humanReadable; } set { if (_humanReadable != value) { _humanReadable = value; PropertyChanged(this, new PropertyChangedEventArgs("humanReadable")); output = Model.Files.ls(longFormat, hiddenFiles, recursive, humanReadable); } } }
        public bool recursive { get { return _recursive; } set { if (_recursive != value) { _recursive = value; PropertyChanged(this, new PropertyChangedEventArgs("recursive")); output = Model.Files.ls(longFormat, hiddenFiles, recursive, humanReadable); } } }
        public bool longFormat { get { return _longFormat; } set { if (_longFormat != value) { _longFormat = value; PropertyChanged(this, new PropertyChangedEventArgs("longFormat")); output = Model.Files.ls(longFormat, hiddenFiles, recursive, humanReadable); } } }
        public bool hiddenFiles { get { return _hiddenFiles; } set { if (_hiddenFiles != value) { _hiddenFiles = value; PropertyChanged(this, new PropertyChangedEventArgs("hiddenFiles")); output = Model.Files.ls(longFormat, hiddenFiles, recursive, humanReadable); } } }
        public event PropertyChangedEventHandler PropertyChanged;
        
        public ls(BatchBash.MainPage sender)
        {
            this.sender = sender;
        }
    }
}
