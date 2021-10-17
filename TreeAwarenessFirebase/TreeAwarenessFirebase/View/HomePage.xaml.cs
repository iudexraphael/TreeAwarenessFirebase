using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TreeAwarenessFirebase.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void ProjNextPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TreeView());
        }
        private async void MessageNextPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MessageView());
        }
        private async void AboutNextPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutInfo());
        }
        private async void PlantAtGardenPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddMessagePage());
        }
    }
}