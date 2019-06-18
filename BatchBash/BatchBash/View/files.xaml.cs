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
	public partial class files : ContentPage
	{
        public BatchBash.MainPage sender;
		public files (MainPage sender)
		{
			InitializeComponent ();
            this.sender = sender;
            BindingContext = new ViewModel.files(sender);
        }
        public void ChangeView(Xamarin.Forms.Page newView)
        {
            Navigation.PushModalAsync(newView);
        }

    }
}