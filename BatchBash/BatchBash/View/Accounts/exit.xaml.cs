using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BatchBash.View.Accounts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class exit : ContentPage
	{
        public BatchBash.MainPage sender;
        public exit(BatchBash.MainPage sender)
        {
            InitializeComponent();
            this.sender = sender;
            BindingContext = new ViewModel.Accounts.exit(sender);
        }
    }
}