using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BatchBash.ViewModel
{
    public class accounts
    {
        public BatchBash.MainPage sender;
        public string Nadpis { get; set; }
        public Command ChangeViewadduser { get; }
        public Command ChangeViewdeluser { get; }
        public Command ChangeViewexit { get; }
        public Command ChangeViewpasswd { get; }
        public Command ChangeViewsu { get; }
        public accounts(BatchBash.MainPage sender)
        {
            Nadpis = "Práce s uživately";
            this.sender = sender;
            ChangeViewadduser = new Command(SwitchViewadduser);
            ChangeViewdeluser = new Command(SwitchViewdeluser);
            ChangeViewexit = new Command(SwitchViewexit);
            ChangeViewpasswd = new Command(SwitchViewpasswd);
            ChangeViewsu = new Command(SwitchViewsu);


        }
        public void SwitchViewadduser() { this.sender.ChangeView(new BatchBash.View.Accounts.adduser(sender)); }
        public void SwitchViewdeluser() { this.sender.ChangeView(new BatchBash.View.Accounts.deluser(sender)); }
        public void SwitchViewexit() { this.sender.ChangeView(new BatchBash.View.Accounts.exit(sender)); }
        public void SwitchViewpasswd() { this.sender.ChangeView(new BatchBash.View.Accounts.passwd(sender)); }
        public void SwitchViewsu() { this.sender.ChangeView(new BatchBash.View.Accounts.su(sender)); }
    }
}
