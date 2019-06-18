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
    public partial class nano : ContentPage
    {
        public BatchBash.MainPage sender;
        public nano(BatchBash.MainPage sender)
        {
            InitializeComponent();
            this.sender = sender;
            BindingContext = new ViewModel.Files.nano(sender);
        }

    }
}