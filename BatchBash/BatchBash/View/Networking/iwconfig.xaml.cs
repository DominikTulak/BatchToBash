using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BatchBash.View.Networking
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class iwconfig : ContentPage
	{
        public BatchBash.MainPage sender;
        public iwconfig(BatchBash.MainPage sender)
        {
            InitializeComponent();
            this.sender = sender;
            BindingContext = new ViewModel.Networking.iwconfig(sender);
        }
    }
}