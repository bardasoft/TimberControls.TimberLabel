using Xamarin.Forms;

namespace TimberControls.Label
{
    public class TimberLabel : Xamarin.Forms.Label
    {
        #region Bindable Properties

        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create( nameof( CornerRadius ), typeof( int ), typeof( TimberLabel ), 0 );

        public int CornerRadius
        {
            get { return (int)GetValue( CornerRadiusProperty ); }
            set { SetValue( CornerRadiusProperty, value ); }
        }

        public static readonly BindableProperty BorderWidthProperty =
            BindableProperty.Create( nameof( BorderWidth ), typeof( int ), typeof( TimberLabel ), 0 );

        public int BorderWidth
        {
            get { return (int)GetValue( BorderWidthProperty ); }
            set { SetValue( BorderWidthProperty, value ); }
        }

        public static readonly BindableProperty BorderColourProperty =
            BindableProperty.Create( nameof( BorderColour ), typeof( Color ), typeof( TimberLabel ), Color.Black );

        public Color BorderColour
        {
            get { return (Color)GetValue( BorderColourProperty ); }
            set { SetValue( BorderColourProperty, value ); }
        }

        public static readonly BindableProperty PaddingProperty =
            BindableProperty.Create( nameof( Padding ), typeof( Thickness ), typeof( TimberLabel ), new Thickness( 0 ) );

        public Thickness Padding
        {
            get { return (Thickness)GetValue( PaddingProperty ); }
            set { SetValue( PaddingProperty, value ); }
        }

        #endregion // Bindable Properties
    }
}
