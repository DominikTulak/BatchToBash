using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BatchBash.ViewModel
{
    public class MainPage 
    {
        public Command ChangeViewNetworking { get; }
        public Command ChangeViewFiles { get; }
        public Command ChangeViewAccounts { get; }
        public Command ChangeViewPrograms { get; }
        public string Nadpis { get; set; }
        public BatchBash.MainPage sender;

        public MainPage (BatchBash.MainPage sender)
		{
            Nadpis = "BashHelper";
            this.sender = sender;
            ChangeViewNetworking = new Command(SwitchViewNetworking);
            ChangeViewFiles = new Command(SwitchViewFiles);
            ChangeViewAccounts = new Command(SwitchViewAccounts);
            ChangeViewPrograms = new Command(SwitchViewPrograms);
        }
        public void SwitchViewNetworking() { this.sender.ChangeView(new BatchBash.View.networking(sender)); }//BatchBash.MainPage.alert("jooo"); }// Navigation.PushModalAsync(new View.networking()); }
        public void SwitchViewFiles() { this.sender.ChangeView(new BatchBash.View.files(sender)); }
        public void SwitchViewAccounts() { this.sender.ChangeView(new BatchBash.View.accounts(sender)); }//BatchBash.MainPage.alert("jooo"); }// Navigation.PushModalAsync(new View.networking()); }
        public void SwitchViewPrograms() { this.sender.ChangeView(new BatchBash.View.programs(sender)); }




    }
}