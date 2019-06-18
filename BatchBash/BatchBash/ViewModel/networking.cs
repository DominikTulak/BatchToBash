using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BatchBash.ViewModel
{
    class networking 
    {
        public BatchBash.MainPage sender;
        public string Nadpis { get; set; }
        public Command ChangeViewping { get; }
        public Command ChangeViewifconfig { get; }
        public Command ChangeViewiwconfig { get; }
        public Command ChangeViewrfkill { get; }
        public Command ChangeViewdhclient { get; }
        public networking(BatchBash.MainPage sender)
        {
            Nadpis = "Práce se sítí";
            this.sender = sender;
            ChangeViewping = new Command(SwitchViewping);
            ChangeViewifconfig = new Command(SwitchViewifconfig);
            ChangeViewiwconfig = new Command(SwitchViewiwconfig);
            ChangeViewrfkill = new Command(SwitchViewrfkill);
            ChangeViewdhclient = new Command(SwitchViewdhclient);


        }
        public void SwitchViewping() { this.sender.ChangeView(new View.Networking.ping(sender)); }
        public void SwitchViewifconfig() { this.sender.ChangeView(new View.Networking.ifconfig(sender)); }
        public void SwitchViewiwconfig() { this.sender.ChangeView(new View.Networking.iwconfig(sender)); }
        public void SwitchViewrfkill() { this.sender.ChangeView(new View.Networking.rfkill(sender)); }
        public void SwitchViewdhclient() { this.sender.ChangeView(new View.Networking.dhclient(sender)); }

    }
}
