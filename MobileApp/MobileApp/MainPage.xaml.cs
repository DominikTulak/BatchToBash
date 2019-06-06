using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void Handle_Clicked(object sender, EventArgs e)
        {
            switch((sender as Button).Text)
            {
                case "Práce se sítí":
                    Page1 view = new Page1();
                    //Přepnout na NetworkingView
                    break;
                case "Práce se soubory":
                    //Přepnout na FilesView
                    break;
                default:
                    DisplayAlert("Chyba", "Neplatná operace", "OK");
                    break;
            }

        }
    }
}
