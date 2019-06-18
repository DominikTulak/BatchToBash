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
	public partial class ifconfig : ContentPage
	{
        public BatchBash.MainPage sender;
        public ifconfig(BatchBash.MainPage sender)
        {
            InitializeComponent();
            this.sender = sender;
            BindingContext = new ViewModel.Networking.ifconfig(sender);
        }
    }
}