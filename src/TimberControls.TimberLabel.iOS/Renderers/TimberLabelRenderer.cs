using System;
using System.ComponentModel;
using TimberControls.iOS.Renderers;
using TimberControls.Label;
using TimberControls.PlatformControls.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer( typeof( TimberLabel ), typeof( TimberLabelRenderer ) )]

namespace TimberControls.iOS.Renderers
{
    public class TimberLabelRenderer : LabelRenderer
    {
        private UIEdgeInsets m_padding;

        public TimberLabelRenderer()
        {
            m_padding = new UIEdgeInsets();
        }

        protected override void OnElementChanged( ElementChangedEventArgs<Xamarin.Forms.Label> e )
        {
            if( Control == null )
                SetNativeControl( new PaddedLabel() );

            base.OnElementChanged( e );

            if( Control != null )
            {
                UpdateCornerRadius();
                UpdateBorderWidth();
                UpdateBorderColour();
                UpdatePadding();
            }
        }

        protected override void OnElementPropertyChanged( object sender, PropertyChangedEventArgs e )
        {
            base.OnElementPropertyChanged( sender, e );

            if( e.PropertyName == TimberLabel.CornerRadiusProperty.PropertyName )
                UpdateCornerRadius();
            else if( e.PropertyName == TimberLabel.BorderWidthProperty.PropertyName )
                UpdateBorderWidth();
            else if( e.PropertyName == TimberLabel.BorderColourProperty.PropertyName )
                UpdateBorderColour();
            else if( e.PropertyName == TimberLabel.PaddingProperty.PropertyName )
                UpdatePadding();
        }

        private void UpdateCornerRadius()
        {
            TimberLabel label = Element as TimberLabel;
            if( label == null )
                return;

            Layer.CornerRadius = label.CornerRadius;
        }

        private void UpdateBorderWidth()
        {
            TimberLabel label = Element as TimberLabel;
            if( label == null )
                return;

            Layer.BorderWidth = label.BorderWidth;
        }

        private void UpdateBorderColour()
        {
            TimberLabel label = Element as TimberLabel;
            if( label == null )
                return;

            Layer.BorderColor = label.BorderColour.ToCGColor();
        }

        private void UpdatePadding()
        {
            TimberLabel label = Element as TimberLabel;
            if( label == null )
                return;

            m_padding.Top = (nfloat)label.Padding.Top;
            m_padding.Left = (nfloat)label.Padding.Left;
            m_padding.Bottom = (nfloat)label.Padding.Bottom;
            m_padding.Right = (nfloat)label.Padding.Right;

            (Control as PaddedLabel).Padding = m_padding;
        }
    }
}
