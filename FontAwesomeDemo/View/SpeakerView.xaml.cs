using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FontAwesomeDemo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpeakerView : ContentPage
    {
        public SpeakerView()
        {
            InitializeComponent();
        }
        protected async void IB_Clicked(object sender, EventArgs e)
        {
            var ib = sender as ImageButton;
            var url = ib.CommandParameter.ToString();
            //Console.WriteLine($"Requested URL: {url}");

            await Browser.OpenAsync(url);
        }
    }
}