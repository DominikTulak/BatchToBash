using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BatchBash.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class networking : ContentPage
	{
        public BatchBash.MainPage sender;
		public networking (MainPage sender)
		{
			InitializeComponent ();
            this.sender = sender;
            BindingContext = new ViewModel.networking(sender);
        }
        public void ChangeView(Xamarin.Forms.Page newView)
        {
            Navigation.PushModalAsync(newView);
        }
    }
}