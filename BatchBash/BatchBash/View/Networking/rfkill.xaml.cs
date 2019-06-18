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
	public partial class rfkill : ContentPage
	{
        public BatchBash.MainPage sender;
        public rfkill(BatchBash.MainPage sender)
        {
            InitializeComponent();
            this.sender = sender;
            BindingContext = new ViewModel.Networking.rfkill(sender);
        }
    }
}