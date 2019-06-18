using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BatchBash.View.Programs
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class purge : ContentPage
	{
        public BatchBash.MainPage sender;
        public purge(BatchBash.MainPage sender)
        {
            InitializeComponent();
            this.sender = sender;
            BindingContext = new ViewModel.Programs.purge(sender);
        }
    }
}