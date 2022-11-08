# How to create animated chart in Xamarin.Forms

[Xamarin.Forms Charts](https://www.syncfusion.com/xamarin-ui-controls/xamarin-charts) will animate seamlessly in two ways: when you first load the chart or when you redraw it after modifying the data points. This section explains both ways of animating chart control using [EnableAnimation](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSeries.html#Syncfusion_SfChart_XForms_ChartSeries_EnableAnimation) property and [Animate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSeries.html#Syncfusion_SfChart_XForms_ChartSeries_Animate) method.

## How to animate a chart on loading

Using the built-in APIs, we can animate the chart with regulating duration. The [EnableAnimation](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSeries.html#Syncfusion_SfChart_XForms_ChartSeries_EnableAnimation) property is used to create an animated chart and the [AnimationDuration](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSeries.html#Syncfusion_SfChart_XForms_ChartSeries_AnimationDuration) property in the chart series is used to control the speed of the animation and its default value is set to 1.

```
…
<syncfusion:ColumnSeries EnableAnimation="True" AnimationDuration="0.8" Color="White" Spacing="0.3"  ItemsSource="{Binding Data}" XBindingPath="XValue" YBindingPath="YValue1"/>
…
```

![Animated chart in Xamarin.Forms](https://github.com/SyncfusionExamples/How-to-create-animated-chart-in-Xamarin.Forms/blob/main/Create-Animated-Charts-and-Graphs.gif)

## To animate on programmatically

Consider the use case like to add data point dynamically to this series with having animation then, it will be achieved by using the Animate method of series as shown in below.
```
<StackLayout Margin="30">
    <syncfusion:SfChart BackgroundColor="#d11f5b"  HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand">
        <syncfusion:SfChart.PrimaryAxis>
            <syncfusion:CategoryAxis LabelPlacement="BetweenTicks" ShowMajorGridLines="False">
                …
            </syncfusion:CategoryAxis>
        </syncfusion:SfChart.PrimaryAxis>
        <syncfusion:SfChart.SecondaryAxis>
            <syncfusion:NumericalAxis EdgeLabelsDrawingMode="Fit" ShowMinorGridLines="False" ShowMajorGridLines="False" >
               …
            </syncfusion:NumericalAxis>
        </syncfusion:SfChart.SecondaryAxis>
        <syncfusion:ColumnSeries x:Name="series" EnableAnimation="True" AnimationDuration="0.8" Color="White" Spacing="0.3"  ItemsSource="{Binding Data}" XBindingPath="XValue" YBindingPath="YValue1"/>
    </syncfusion:SfChart>
    <Button Text="Add data point" Clicked="Button_Clicked"/>
</StackLayout>
```

![Animate Xamarin.Forms chart programmatically](https://github.com/SyncfusionExamples/How-to-create-animated-chart-in-Xamarin.Forms/blob/main/Programmatically-animated-chart.gif)

KB article - [How to create animated chart in Xamarin.Forms](https://www.syncfusion.com/kb/12481/how-to-create-animated-chart-in-xamarin-forms)

## See also

[How to make animation work on the chart in release mode with Android Proguard](https://www.syncfusion.com/kb/10729/how-to-make-animation-work-on-chart-in-release-mode-with-android-proguard)

[How to group stacking series in Xamarin.Forms Chart](https://www.syncfusion.com/kb/11724/how-to-group-stacking-series-in-the-xamarin-forms-chart)

[How to perform zooming function in Xamarin.Forms Chart](https://help.syncfusion.com/xamarin/charts/zoompan#%22enable-zooming%22)
