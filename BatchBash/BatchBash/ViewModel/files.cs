using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace BatchBash.ViewModel
{
    class files
    {
        public BatchBash.MainPage sender;
        public string Nadpis { get; set; }
        public Command ChangeViewcd { get; }
        public Command ChangeViewmkdir { get; }
        public Command ChangeViewnano { get; }
        public Command ChangeViewtouch { get; }
        public Command ChangeViewls { get; }
        public files(BatchBash.MainPage sender)
        {
            Nadpis = "Práce se soubory";
            this.sender = sender;
            ChangeViewcd = new Command(SwitchViewcd);
            ChangeViewmkdir = new Command(SwitchViewmkdir);
            ChangeViewnano = new Command(SwitchViewnano);
            ChangeViewtouch = new Command(SwitchViewtouch);
            ChangeViewls = new Command(SwitchViewls);


        }
        public void SwitchViewcd() { this.sender.ChangeView(new BatchBash.View.Files.cd(sender)); }
        public void SwitchViewmkdir() { this.sender.ChangeView(new BatchBash.View.Files.mkdir(sender)); }
        public void SwitchViewnano() { this.sender.ChangeView(new BatchBash.View.Files.nano(sender)); }
        public void SwitchViewtouch() { this.sender.ChangeView(new BatchBash.View.Files.touch(sender)); }
        public void SwitchViewls() { this.sender.ChangeView(new BatchBash.View.Files.ls(sender)); }

    }
}
