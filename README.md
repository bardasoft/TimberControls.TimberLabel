#  TimberControls.TimberLabel
A custom Xamarin.Forms.Label control that adds support for padding, rounded corners and, borders on iOS and Android.

# How to use
Clone the repository and add the projects from the `src` folder into the appropriate projects within your solution as references. Then use the control in XAML as below, or from C# in your code-behind file (See the example project for a demo):
``` xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:timber="clr-namespace:TimberControls.Label;assembly=TimberControls.TimberLabel"
             x:Class="TimberLabel.Example.MainPage">

    <timber:TimberLabel
        TextColor="White"
        BackgroundColor="Blue"
        Padding="10"
        CornerRadius="10"
        BorderWidth="2"
        BorderColour="Black"
        Text="TimberLabel with padding, rounded corners and a border!"
        HorizontalTextAlignment="Center"/>

</ContentPage>
```
**Special Note for iOS:** Make sure to add `[assembly: Preserve( typeof( TimberLabelRenderer ), AllMembers = true )]` within your iOS `AppDelegate.cs` to avoid the renderer being linked out.

### Additional Label Properties:
**Property** | **Type** | **Description**
-------------|----------|----------------
CornerRadius | int | Sets the corner radius of the label
BorderWidth | int | Sets the width of the border for the label
BorderColour | [Color](https://developer.xamarin.com/api/type/Xamarin.Forms.Color/) | Sets the colour of the border for the label
Padding | [Thickness](https://developer.xamarin.com/api/type/Xamarin.Forms.Thickness/) | Sets the padding for the label

## Screenshots
Android | iOS
--------|----
![TimberLabel.Example.Android](/Screenshots/android.png) | ![TimberLabel.Example.iOS](/Screenshots/ios.png)
