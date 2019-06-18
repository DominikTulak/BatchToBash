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
	public partial class touch : ContentPage
	{
        public BatchBash.MainPage sender;
        public touch(BatchBash.MainPage sender)
        {
            InitializeComponent();
            this.sender = sender;
            BindingContext = new ViewModel.Files.touch(sender);
        }
    }
}