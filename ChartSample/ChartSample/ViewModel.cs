using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ChartSample
{
    public class ChartModel
    {
        public string XValue { get; set; }

        public double YValue1 { get; set; }
    
    }
    public class ViewModel
    {
        public ObservableCollection<ChartModel> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<ChartModel>();

            Data.Add(new ChartModel() { XValue = "Jan", YValue1 = 37 });
            Data.Add(new ChartModel() { XValue = "Feb", YValue1 = 37 });
            Data.Add(new ChartModel() { XValue = "Mar", YValue1 = 39 });
            Data.Add(new ChartModel() { XValue = "Apr", YValue1 = 43 });
            Data.Add(new ChartModel() { XValue = "May", YValue1 = 48 });
            Data.Add(new ChartModel() { XValue = "Jun", YValue1 = 54 });
            Data.Add(new ChartModel() { XValue = "Jul", YValue1 = 57 });
        }
    }
}
