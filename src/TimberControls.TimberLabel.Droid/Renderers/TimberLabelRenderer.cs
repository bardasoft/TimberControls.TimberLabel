using Android.Content;
using Android.Graphics.Drawables;
using System.ComponentModel;
using TimberControls.Droid.Helpers;
using TimberControls.Droid.Renderers;
using TimberControls.Label;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer( typeof( TimberLabel ), typeof( TimberLabelRenderer ) )]

namespace TimberControls.Droid.Renderers
{
    public class TimberLabelRenderer : LabelRenderer
    {
        private GradientDrawable m_background;

        /// <summary>
        /// Used only to ensure the renderer is not linked out
        /// </summary>
        public static void InitRenderer()
        {
        }

        public TimberLabelRenderer( Context context )
            : base( context )
        {
            m_background = new GradientDrawable();
            m_background.SetShape( ShapeType.Rectangle );
        }

        protected override void OnElementChanged( ElementChangedEventArgs<Xamarin.Forms.Label> e )
        {
            base.OnElementChanged( e );

            if( Control != null )
            {
                UpdatePadding();
            }
        }

        protected override void OnLayout( bool changed, int l, int t, int r, int b )
        {
            base.OnLayout( changed, l, t, r, b );

            TimberLabel label = Element as TimberLabel;
            if( label == null )
                return;

            m_background.SetColor( label.BackgroundColor.ToAndroid() );

            int cornerRadiusPx = ConversionHelpers.ConvertDPToPixels( label.CornerRadius );
            m_background.SetCornerRadius( cornerRadiusPx );

            int borderWidthPx = ConversionHelpers.ConvertDPToPixels( label.BorderWidth );
            m_background.SetStroke( borderWidthPx, label.BorderColour.ToAndroid() );

            Background = m_background;
        }

        protected override void OnElementPropertyChanged( object sender, PropertyChangedEventArgs e )
        {
            base.OnElementPropertyChanged( sender, e );

            if( e.PropertyName == VisualElement.BackgroundColorProperty.PropertyName )
                Invalidate();
            else if( e.PropertyName == TimberLabel.CornerRadiusProperty.PropertyName )
                Invalidate();
            else if( e.PropertyName == TimberLabel.BorderWidthProperty.PropertyName )
                Invalidate();
            else if( e.PropertyName == TimberLabel.BorderColourProperty.PropertyName )
                Invalidate();
            else if( e.PropertyName == TimberLabel.PaddingProperty.PropertyName )
                UpdatePadding();
        }

        private void UpdatePadding()
        {
            TimberLabel label = Element as TimberLabel;
            if( label == null )
                return;

            int left = ConversionHelpers.ConvertDPToPixels( (int)label.Padding.Left + label.BorderWidth );
            int top = ConversionHelpers.ConvertDPToPixels( (int)label.Padding.Top + label.BorderWidth );
            int right = ConversionHelpers.ConvertDPToPixels( (int)label.Padding.Right + label.BorderWidth );
            int bottom = ConversionHelpers.ConvertDPToPixels( (int)label.Padding.Bottom + label.BorderWidth );

            Control.SetPadding( left, top, right, bottom );
        }
    }
}