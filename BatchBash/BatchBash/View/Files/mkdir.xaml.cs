using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BatchBash.View.Files
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class mkdir : ContentPage
	{
        public BatchBash.MainPage sender;
        public mkdir(BatchBash.MainPage sender)
        {
            InitializeComponent();
            this.sender = sender;
            BindingContext = new ViewModel.Files.mkdir(sender);
        }
    }
}