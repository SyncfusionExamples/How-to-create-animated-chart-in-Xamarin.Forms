using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChartSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Data is a collection of Model which is populated to the series.
            (BindingContext as ViewModel).Data.Add(new ChartModel() { XValue = "Aug", YValue1 = 90 });
            //Animate() is used to animate the series
            series.Animate();
        }
    }
}
