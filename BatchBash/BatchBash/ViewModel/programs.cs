using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BatchBash.ViewModel
{
    class programs
    {
        public BatchBash.MainPage sender;
        public string Nadpis { get; set; }
        public Command ChangeViewinstall { get; }
        public Command ChangeViewremove { get; }
        public Command ChangeViewpurge { get; }
        public Command ChangeViewautoremove { get; }
        public programs(BatchBash.MainPage sender)
        {
            Nadpis = "Práce s uživately";
            this.sender = sender;
            ChangeViewinstall = new Command(SwitchViewinstall);
            ChangeViewremove = new Command(SwitchViewremove);
            ChangeViewpurge = new Command(SwitchViewpurge);
            ChangeViewautoremove = new Command(SwitchViewautoremove);


        }
        public void SwitchViewinstall() { this.sender.ChangeView(new BatchBash.View.Programs.install(sender)); }
        public void SwitchViewremove() { this.sender.ChangeView(new BatchBash.View.Programs.remove(sender)); }
        public void SwitchViewpurge() { this.sender.ChangeView(new BatchBash.View.Programs.purge(sender)); }
        public void SwitchViewautoremove() { this.sender.ChangeView(new BatchBash.View.Programs.autoremove(sender)); }
    }
}
