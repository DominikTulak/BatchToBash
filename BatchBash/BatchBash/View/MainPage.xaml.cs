using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BatchBash.ViewModel;

namespace BatchBash
{
    public partial class MainPage : ContentPage
    {
        public static MainPage that;

        public MainPage()
        {
            InitializeComponent();
            that = this;
            BindingContext = new ViewModel.MainPage(this);
        }
        public void ChangeView(Xamarin.Forms.Page newView){
            Navigation.PushModalAsync(newView);
        }
        
    }
}
