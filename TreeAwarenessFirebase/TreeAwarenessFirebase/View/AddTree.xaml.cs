using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TreeAwarenessFirebase.Model;
using TreeAwarenessFirebase.ViewModel;
using TreeAwarenessFirebase.Services;

namespace TreeAwarenessFirebase.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTree : ContentPage
    {
        public AddTree()
        {
            InitializeComponent();
            BindingContext = new TreesViewModel();
        }


    }
}