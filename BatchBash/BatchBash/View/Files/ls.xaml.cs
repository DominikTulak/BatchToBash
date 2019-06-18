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
    public partial class ls
	{
        public BatchBash.MainPage sender;
        public ls(BatchBash.MainPage sender)
        {
            InitializeComponent();
            this.sender = sender;
            BindingContext = new ViewModel.Files.ls(sender);
        }
    }
}